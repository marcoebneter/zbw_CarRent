using System;
using System.Collections.Generic;
using AutoMapper;
using CarRent.CarManagement.Application;
using CarRent.CarManagement.Domain;
using CarRent.Common.Infrastructure.Mapper;
using CarRent.Common.Interfaces;
using CarRent.Controllers;
using FluentAssertions;
using Moq;
using Xunit;

namespace CarRent.Tests
{
    public class TestCarManagement
    {
        private readonly IMapper _mapper;
        private readonly ICarService _service;
        private readonly Mock<IRepository<Car, Guid>> _repoMock;
        private readonly List<Car> _cars;

        private readonly Class _einfach = new Class()
        {
            id = new Guid(),
            dailyFee = 30,
            carClassType = CarClassTypes.Einfachklasse
        };
        private readonly Class _mittel = new Class()
        {
            id = new Guid(),
            dailyFee = 50,
            carClassType = CarClassTypes.Mittelklasse
        };
        private readonly Class _luxus = new Class()
        {
            id = new Guid(),
            dailyFee = 100,
            carClassType = CarClassTypes.Luxusklasse
        };


        public TestCarManagement()
        {
            var carClasses = new List<Class>()
            {
                _einfach,
                _mittel,
                _luxus
            };

            _cars = new List<Car>()
            {
                new Car()
                {
                    id = Guid.NewGuid(),
                    brand = "Toyota",
                    carClass = _einfach,
                    carClassId = _einfach.id,
                    type = "PW"
                }
            };

            _mapper = new Mapper(new MapperConfiguration(conf => conf.AddProfile(typeof(CarMapper))));
            _repoMock = new Mock<IRepository<Car, Guid>>();
            _repoMock.Setup(x => x.GetAll()).Returns(_cars);
            _service = new CarService(_repoMock.Object);
        }

        [Fact]
        public void TestGetAll()
        {
            var controller = new CarController(_service, _mapper);

            var result = controller.Get();

            result.Should().NotBeEmpty().And.BeEquivalentTo(_cars, o => o.ExcludingMissingMembers());
        }
    }
}
