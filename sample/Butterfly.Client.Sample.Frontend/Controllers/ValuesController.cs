﻿using System.Net.Http;
using System.Threading.Tasks;
using Housecool.Butterfly.Client.Tracing;
using Microsoft.AspNetCore.Mvc;

namespace Housecool.Butterfly.Client.Sample.Frontend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<string> Get([FromServices] HttpClient httpClient, [FromServices] IServiceTracer tracer)
        {
            return await httpClient.GetStringAsync("http://localhost:5002/api/values");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
