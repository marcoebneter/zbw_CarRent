using System;
using System.Collections.Generic;
using AutoMapper;
using CarRent.Common.Infrastructure.Mapper;
using CarRent.Common.Interfaces;
using CarRent.CustomerManagement.Api;
using CarRent.CustomerManagement.Application;
using CarRent.CustomerManagement.Domain;
using FluentAssertions;
using Moq;
using Xunit;

namespace CarRent.Tests
{
    public class TestCustomerManagement
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _service;
        private readonly Mock<IRepository<Customer, Guid>> _repoMock;
        private readonly List<Customer> _customers;

        private readonly Plz _plz = new Plz()
        {
            id = Guid.NewGuid(),
            city = "Appenzell",
            plz = "9050",
            country = "Switzerland"
        };

        public TestCustomerManagement()
        {
            _customers = new List<Customer>()
            {
                new Customer()
                {
                    id = Guid.NewGuid(),
                    firstname = "Marco",
                    lastname = "Ebneter",
                    street = "Teststrasse 12",
                    plz = _plz,
                    plzId = _plz.id
                }
            };
            _mapper = new Mapper(new MapperConfiguration(conf => { conf.AddProfile(typeof(CustomerMapper)); }));
            _repoMock = new Mock<IRepository<Customer, Guid>>();
            _repoMock.Setup(x => x.GetAll()).Returns(_customers);
            _repoMock.Setup(x => x.Insert(It.IsAny<Customer>()));
            _service = new CustomerService(_repoMock.Object);
        }

        [Fact]
        public void TestGetAll()
        {
            var controller = new CustomerController(_service, _mapper);

            var result = controller.Get();

            result.Should().NotBeEmpty().And.BeEquivalentTo(_customers, o => o.ExcludingMissingMembers());
        }
    }
}
