using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CustomerManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlzController : ControllerBase
    {
        private readonly IPlzService _service;
        private readonly IMapper _mapper;

        public PlzController(IPlzService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<PlzController>
        [HttpGet]
        public List<PlzCodeDto> Get()
        {
            return _service.GetAll().Select(entity => _mapper.Map<PlzCodeDto>(entity)).ToList();
        }

        // GET api/<PlzController>/5
        [HttpGet("{id}")]
        public List<PlzCodeDto> Get(Guid id)
        {
            return _service.GetById(id).Select(entity => _mapper.Map<PlzCodeDto>(entity)).ToList();
        }

        // POST api/<PlzController>
        [HttpPost]
        public void Post([FromBody] PlzCodeDto entity)
        {
            _service.Add(_mapper.Map<Plz>(entity));
        }

        // PUT api/<PlzController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] PlzCodeDto entity)
        {
            var c = _mapper.Map<Plz>(entity);
            c.id = id;
            _service.Update(c);
        }

        // DELETE api/<PlzController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.RemoveById(id);
        }
    }
}
