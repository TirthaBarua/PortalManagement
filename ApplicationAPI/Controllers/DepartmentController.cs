using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentService service;
        public DepartmentController(DepartmentService service)
        {
            this.service = service;
        }


        [HttpGet("all")]

        public IActionResult All()
        {
            var data = service.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = service.Get(id);
            return Ok(data);


        }

        [HttpPost("Create")]
        public IActionResult Create(DepartmentDTO d)
        {
            var res = service.Create(d);
            if (res == true)
            {
                return Ok(res);
            }
            else
            {
               return BadRequest(res);
            }
        }

        [HttpPost("Update")]
        public IActionResult Update(DepartmentDTO d)
        {
            var res = service.Update(d);
            if (res == true)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var res = service.Delete(id);
            if (res == true)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
        }
        [HttpGet("all/employees")]
        public IActionResult GetWithEmployees()
        {
            var data = service.GetWithEmployees();
            return Ok(data);
        }
        [HttpGet("find/{name}")]
        public IActionResult FindByName(string name)
        {
            var data = service.FindByName(name);
            return Ok(data);
        }

    }
}

