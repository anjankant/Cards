using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cards : ControllerBase
    {
        [HttpGet("GetCards")]
        public IActionResult GetCards()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.magicthegathering.io/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("v1/cards?page=311").Result;
            if (response.IsSuccessStatusCode)
            {
                return Ok(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return BadRequest("this is bad request.");
            }
        }


        [HttpGet("GetCards/{name}")]
        public IActionResult GetCardsByName(string name)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.magicthegathering.io/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("v1/cards?page=311").Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonString);
                var result = myDeserializedClass.cards.Where(x => x.name == name).ToList();
                return Ok(result);
            }
            else
            {
                return BadRequest("this is bad request.");
            }
        }

        [HttpGet("GetCardsByColor/{color}")]
        public IActionResult GetCardsByColor(string color)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.magicthegathering.io/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("v1/cards?page=311").Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonString);
                var result = myDeserializedClass.cards.Where(x => x.colors.Contains(color)).ToList();
                return Ok(result);
            }
            else
            {
                return BadRequest("this is bad request.");
            }
        }

        [HttpGet("GetCardsByTypes/{type}")]
        public IActionResult GetCardsByTypes(string type)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.magicthegathering.io/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("v1/cards?page=311").Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonString);
                var result = myDeserializedClass.cards.Where(x => x.types.Contains(type)).ToList();
                return Ok(result);
            }
            else
            {
                return BadRequest("this is bad request.");
            }
        }
    }
}
