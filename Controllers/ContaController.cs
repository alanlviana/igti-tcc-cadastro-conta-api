using System;
using System.Collections.Generic;
using igti_tcc_cadastro_conta_api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace igti_tcc_cadastro_conta_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        // POST api/conta
        [HttpPost]
        public void Post([FromBody] Conta conta)
        {
        }

        // PUT api/conta/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Conta conta)
        {
        }

        [HttpGet]
        public string Get(){
            var hostname = Environment.GetEnvironmentVariable("HOSTNAME");
            return hostname;
        }
    }
}