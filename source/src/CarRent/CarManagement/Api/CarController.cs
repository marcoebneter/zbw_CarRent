using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CarManagement.Api;
using CarRent.CarManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _service;
        private readonly IMapper _mapper;

        public CarController(ICarService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarDto> Get()
        {
            return _service.GetAll().Select(car => _mapper.Map<CarDto>(car)).ToList();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public IEnumerable<CarDto> Get(Guid id)
        {
            return _service.GetById(id).Select(car => _mapper.Map<CarDto>(car)).ToList();
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] CarDto entity)
        {
            _service.Add(_mapper.Map<Car>(entity));
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CarDto entity)
        {
            _service.Update(_mapper.Map<Car>(entity));
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeleteById(id);
        }
    }
}
