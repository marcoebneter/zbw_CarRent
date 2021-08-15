using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CarManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarClassController : ControllerBase
    {
        private readonly IClassService _service;
        private readonly IMapper _mapper;

        public CarClassController(IClassService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<CarClassController>
        [HttpGet]
        public IEnumerable<ClassDto> Get()
        {
            return _service.GetAll().Select(car => _mapper.Map<ClassDto>(car)).ToList();
        }

        // GET api/<CarClassController>/5
        [HttpGet("{id}")]
        public IEnumerable<ClassDto> Get(Guid id)
        {
            return _service.GetById(id).Select(car => _mapper.Map<ClassDto>(car)).ToList();
        }

        // POST api/<CarClassController>
        [HttpPost]
        public void Post([FromBody] ClassDto entity)
        {
            _service.Add(_mapper.Map<Class>(entity));
        }

        // PUT api/<CarClassController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] ClassDto entity)
        {
            _service.Update(_mapper.Map<Class>(entity));
        }

        // DELETE api/<CarClassController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeleteById(id);
        }
    }
}
