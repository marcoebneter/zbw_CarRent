using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.Common.Infrastructure.Mapper;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CustomerManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public List<CustomerDto> Get()
        {
            return _service.GetAll().Select(entity => _mapper.Map<CustomerDto>(entity)).ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public List<CustomerDto> Get(Guid id)
        {
            return _service.GetById(id).Select(entity => _mapper.Map<CustomerDto>(entity)).ToList();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDto entity)
        {
            _service.Update(_mapper.Map<Customer>(entity));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] CustomerDto entity)
        {
            var c = _mapper.Map<Customer>(entity);
            c.id = id;
            _service.Update(c);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.RemoveById(id);
        }
    }
}
