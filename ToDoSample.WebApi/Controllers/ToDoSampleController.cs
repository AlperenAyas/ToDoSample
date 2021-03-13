using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoSample.Business.Abstract;

namespace ToDoSample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoSampleController : ControllerBase
    {
        private readonly IToDoSampleService _service;

        public ToDoSampleController(IToDoSampleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("[action]/id")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpGet("[action]/title")]
        public IActionResult GetByTitle(string title)
        {
            return Ok(_service.GetByTitle(title));
        }

        [HttpPost]
        public IActionResult Create(ToDoSample.Entities.Concrete.ToDoSample model)
        {
            _service.Create(model);
            return Ok("Yeni Kayıt Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(ToDoSample.Entities.Concrete.ToDoSample model)
        {
            _service.Update(model);
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
