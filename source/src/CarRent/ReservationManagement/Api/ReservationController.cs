using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRent.ReservationManagement.Application;
using CarRent.ReservationManagement.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.ReservationManagement.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _service;
        private readonly IMapper _mapper;

        public ReservationController(IReservationService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<ReservationController>
        [HttpGet]
        public List<ReservationDto> Get()
        {
            return _service.GetAll().Select(entity => _mapper.Map<ReservationDto>(entity)).ToList();
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public List<ReservationDto> Get(Guid id)
        {
            return _service.GetById(id).Select(entity => _mapper.Map<ReservationDto>(entity)).ToList();
        }

        // POST api/<ReservationController>
        [HttpPost]
        public void Post([FromBody] ReservationDto entity)
        {
            _service.Add(_mapper.Map<Reservation>(entity));
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] ReservationDto entity)
        {
            var c =_mapper.Map<Reservation>(entity);
            c.id = id;
            _service.Update(c);
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.RemoveById(id);
        }
    }
}
