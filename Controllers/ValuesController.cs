﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using keylookup.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace keylookup.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ICache cache;
        public ValuesController(ICache cache)
        {
           
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
