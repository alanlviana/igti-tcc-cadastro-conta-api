using System.Collections.Generic;
using igti_tcc_cadastro_conta_api.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}