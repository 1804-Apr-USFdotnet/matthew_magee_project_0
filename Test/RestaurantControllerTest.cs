using System;
using System.Collections.Generic;
using Data.Models;
using Library.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class RestaurantControllerTest
    {
        Mock<IRepository<Restaurants>> mockRepository = new Mock<IRepository<Restaurants>>();

        private List<Restaurants> listOfRestaurants = new List<Restaurants>
        {
            new Restaurants()
            {

                Id = 1,
                Name = "McDonalds",
                Address = "123 Main street",
                ZipCode = 43532,
                PhoneNumber = "453-432-2452"
            }
        };
    

        [TestMethod]
        public void getAllRestaurants()
        {
            mockRepository.Setup(x => x.GetAll()).Returns(listOfRestaurants);
            mockRepository.Object.GetAll();
        }

        [TestMethod]
        public void getAllByRating()
        {
            mockRepository.Setup(x => x.GetAllByRating()).Returns(listOfRestaurants.ToString);
            mockRepository.Object.GetAllByRating();
        }

        [TestMethod]
        public void getAllByName()
        {
            mockRepository.Setup(x => x.GetAllByName()).Returns(listOfRestaurants);
            mockRepository.Object.GetAllByName();
        }
        

        [TestMethod]
        public void Details()
        {
            string searchString = "McDonalds";
            mockRepository.Setup(x => x.Details(searchString)).Returns(listOfRestaurants.ToString());
            mockRepository.Object.Details(searchString);
        }

        [TestMethod]
        public void Reviews()
        {
            string searchString = "McDonalds";
            mockRepository.Setup(x => x.Reviews(searchString)).Returns(listOfRestaurants.ToString());
            mockRepository.Object.Reviews(searchString);
        }

        [TestMethod]
        public void TopThree()
        {
            string searchString = "McDonalds";
            mockRepository.Setup(x => x.TopThreeRestaurants()).Returns(listOfRestaurants.ToString());
            mockRepository.Object.Reviews(searchString);
        }
    }
}
