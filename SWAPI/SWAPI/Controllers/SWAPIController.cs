using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StarWarsAPI.Models;

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
    }
}