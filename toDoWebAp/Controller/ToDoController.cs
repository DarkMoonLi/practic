using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace toDoWebAp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        ToDoRepositore repositore = new ToDoRepositore();
        public ToDoController()
        {
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public List<ToDoDto> Get()
        {
            return repositore.GetAll();
        }


        // POST api/<ValuesController>
        [HttpPost]
        public int Post([FromBody] ToDoDto toDoDto)
        {
            return repositore.Create(toDoDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToDoDto toDoDto)
        {
            repositore.Update(id, toDoDto);
        }
    }
}
