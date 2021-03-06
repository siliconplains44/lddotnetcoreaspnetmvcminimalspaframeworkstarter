﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace netcoreldspaframework.WebApis
{
    [Produces("application/json")]
    [Route("api/HelloWorld")]
    public class HelloWorldController : Controller
    {
        // GET: api/HelloWorld
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }

        // GET: api/HelloWorld/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/HelloWorld
        [HttpPost]
        public IEnumerable<string> Post([FromBody]string value)
        {
            return new String[] { "Hello", "World" };
        }
        
        // PUT: api/HelloWorld/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
