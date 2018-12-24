using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SWAPI.Models;
using SWAPI.ViewModels;

namespace SWAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SWAPIController : Controller
    {
        //Primeiro EndPoint
        [HttpGet]
        public async Task<List<People>> ObterPersonagens()
        {
            Json personagens = null;
            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://swapi.co/api/people/");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                personagens = JsonConvert.DeserializeObject<Json>(stringResult);
            }

            personagens.results = personagens.results.OrderBy(y => y.Films.Count()).ThenBy(y => y.name).ToList();

            return personagens.results;
        }

        //2º EndPoint
        [HttpGet("{id}")]
        public async Task<PeopleFilmViewModel> ObterPersonagensPorId(int id)
        {
            PeopleFilmViewModel people = null;
            List<string> films = new List<string>();

            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://swapi.co/api/people/" + id);
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                people = JsonConvert.DeserializeObject<PeopleFilmViewModel>(stringResult);

            }

            for (int i = 0; i < people.films.Length; i++)
            {
                response.Dispose();
                response = await httpClient.GetAsync(people.films[i]);
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var film = JsonConvert.DeserializeObject<Film>(stringResult);

                    films.Add(film.title);
                }
            }

            people.filmslist = films;

            return people;
        }

        //3 Endpoint

        [HttpGet]
        public async Task<List<People>> ObterPersonagensHumano()
        {
            HumanViewModel human = null;
            List<string> Humanos = new List<string>();
            int mass = 0;

            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://swapi.co/api/species/1");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                human = JsonConvert.DeserializeObject<HumanViewModel>(stringResult);
            }

            for (int i = 0; i < human.people.Length; i++)
            {
                response.Dispose();
                response = await httpClient.GetAsync(human.people[i]);
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var StringHumanos = JsonConvert.DeserializeObject<People>(stringResult);

                    int value = 0;
                    var MassInt = Int32.TryParse(StringHumanos.mass, out value);

                    mass = mass + value;
                }
            }

            var ContaHumanos = human.people.Length;

            var Media = mass / ContaHumanos;

            return human.results;
        }
    }
}