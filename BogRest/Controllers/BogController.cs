using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BogLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BogRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BogController : ControllerBase
    {
        private static readonly List<Bog> bogs = new List<Bog>()
        {
            new Bog("Starry night", "MoonMoon", 420, "123456789moon"),
            new Bog("Long kiss goodbye", "I don't know", 500, "1133224455678"),
            new Bog("Artemis Fowl", "Eoin Colfer", 390, "2135468791234")
            
        };
            // GET: api/Bog
        [HttpGet]
        public IEnumerable<Bog> Get()
        {
            return bogs;
        }

        // GET: api/Bog/5
        [HttpGet("{id}", Name = "Get")]
        public Bog Get(string id)
        {
            return bogs.Find(i =>i.Isbn13 == id);
        }

        // POST: api/Bog
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
        }

        // PUT: api/Bog/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Bog value)
        {
            Bog bog = Get(id);
            if (bog != null)
            {
                bog.Isbn13 = value.Isbn13;
                bog.Forfatter = value.Forfatter;
                bog.Sidetal = value.Sidetal;
                bog.Titel = value.Titel;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Bog bog = Get(id);
            bogs.Remove(bog);
        }
    }
}
