using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Library.Models;
using Library;

namespace RestaurantTest
{
    [TestClass]
    public class RestaurantControllerTest
    {
        Mock<IRepository<RootObject>> mockRepository = new Mock<IRepository<RootObject>>();
        private List<RootObject> listOfRestaurants = new List<RootObject>
        {
            new RootObject()
            {
                Restaurant = new Restaurant()
                {
                    name = "McDonalds",
                    location = "123 Main street",
                    phoneNumber = "765-334-3434",
                    ratings = new List<double>() {5.4, 4.5, 9.8, 5.6},
                    reviews = new List<Review>() {new Review() {review = "It sucked", username = "myUsername"}},
                    state = "AK",
                    zipCode = 74654
                }
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
            mockRepository.Setup(x => x.GetAllByRating()).Returns(listOfRestaurants);
            mockRepository.Object.GetAllByRating();
        }

        [TestMethod]
        public void getAllByName()
        {
            mockRepository.Setup(x => x.GetAllByName()).Returns(listOfRestaurants);
            mockRepository.Object.GetAllByName();
        }

        [TestMethod]
        public void Search()
        {
            string searchString = "McDonalds";
            mockRepository.Setup(x => x.Search(searchString)).Returns(listOfRestaurants);
            mockRepository.Object.Search(searchString);
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
