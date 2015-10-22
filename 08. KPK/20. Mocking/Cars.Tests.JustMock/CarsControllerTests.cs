namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    using Moq;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
            : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void EmptyConstructorShouldNotThrow()
        {
            this.controller = new CarsController();
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsShouldThrowExceptionWhenNoIdIsFound()
        {
            var mockedCars = new Mock<ICarsRepository>();
            mockedCars.Setup(x => x.GetById(It.IsAny<int>()))
                .Returns((Car)null);
            var repository = new CarsController(mockedCars.Object);
            repository.Details(int.MinValue);
        }

        [TestMethod]
        public void SearchShouldReturnCorrectCollection()
        {
            var mockedCars = new Mock<ICarsRepository>();
            mockedCars.Setup(x => x.GetById(It.IsAny<int>())).Returns((Car)null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortShouldThrowWhenGivenInvalidString()
        {
            var models = (ICollection<Car>)this.GetModel(() => this.controller.Sort(""));
        }

        [TestMethod]
        public void SortShouldReturnSortedByMake()
        {
            //I don't know why these dont work ;(
            var models = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));
            Assert.AreEqual(4, models.Count);
            var modelsArray = new Car[models.Count];
            models.CopyTo(modelsArray, 0);
            var firstCar = modelsArray[0];
            var lastCar = modelsArray[modelsArray.Length-1];
            Assert.AreEqual("Audi", firstCar.Make);
            Assert.AreEqual("Opel", lastCar.Make);
        }

        [TestMethod]
        public void SortShouldReturnSortedByYear()
        {
            //I don't know why these dont work ;(
            //var models = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));
            //Assert.AreEqual(4, models.Count);
            //var modelsArray = new Car[models.Count];
            //models.CopyTo(modelsArray, 0);
            //var firstCar = modelsArray[0];
            //var lastCar = modelsArray[modelsArray.Length - 1];
            //Assert.AreEqual("Audi", firstCar.Make);
            //Assert.AreEqual("Opel", lastCar.Make);
            var validSortingParameter = "year";
            var sortedCars = (IList<Car>)this.GetModel(() => this.controller.Sort(validSortingParameter));

            Assert.AreEqual(4, sortedCars.Count);
            Assert.AreEqual(2005, sortedCars[0].Year);
            Assert.AreEqual(2007, sortedCars[1].Year);
            Assert.AreEqual(2008, sortedCars[2].Year);
            Assert.AreEqual(2010, sortedCars[3].Year);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
