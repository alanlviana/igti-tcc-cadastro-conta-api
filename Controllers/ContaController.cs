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
        public List<object> Get(){
        
            var enumerator = Environment.GetEnvironmentVariables().GetEnumerator();
            var list = new List<object>();
            while (enumerator.MoveNext())
            {
                list.Add(new{Chave = enumerator.Key, Valor = enumerator.Value});
            }

            return list;
        }

        [HttpGet("{id}")]
        public string GetById(string id){
        
            var enumerator = Environment.GetEnvironmentVariables().GetEnumerator();
            string idValue = "";
            while (enumerator.MoveNext())
            {
                if (id == enumerator.Key.ToString()){
                    idValue = enumerator.Value.ToString();
                }
            }

            return idValue;
        }
    }
}