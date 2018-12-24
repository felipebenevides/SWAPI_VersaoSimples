using System;
using System.Collections.Generic;
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
        public async Task<PeopleFilm> ObterPersonagensPorId(int id)
        {
            PeopleFilm people = null;
            List<string> films = new List<string>();

            var httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://swapi.co/api/people/" + id);
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                people = JsonConvert.DeserializeObject<PeopleFilm>(stringResult);

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

    }
}