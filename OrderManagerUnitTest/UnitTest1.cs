using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManager.Models;
using OrderManager.ViewModels;

namespace OrderManagerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Новая заявка попадает в лимит. Изначально в конструкторе OrdersViewModel - 4 заявки из Саратова текущего дня
        /// </summary>
        [TestMethod]
        public void OrderUnderRestrictTestMethod1()
        {
            var ordersVM = new OrdersViewModel();
            Order testOrder = new Order { Id = 3, City = "Саратов", Address = "Moskovskaya 48", 
                FullName = "Ivan Ivanovich Egorov", MeasuringDate = DateTime.Now, Phone = "272730", IsDone = false };
            List<Restriction> testRestrictions = new List<Restriction>()
            {
                new Restriction { City="Москва", DateTimeInfo=DateTime.Now, RestrictionsCount=5},
                new Restriction{ City="Саратов", DateTimeInfo=DateTime.Now, RestrictionsCount=5},
                new Restriction{ City="Волгоград", DateTimeInfo=DateTime.Now, RestrictionsCount=5}
            };
            var result = ordersVM.OrderUnderRestrict(testOrder, testRestrictions);

            Assert.AreEqual(result, true);
        }

        /// <summary>
        /// Лимит количества заявок будет переполнен 
        /// </summary>
        [TestMethod]
        public void OrderUnderRestrictTestMethod2()
        {
            var ordersVM = new OrdersViewModel();
            Order testOrder = new Order
            {
                Id = 3,
                City = "Саратов",
                Address = "Moskovskaya 48",
                FullName = "Ivan Ivanovich Egorov",
                MeasuringDate = DateTime.Now,
                Phone = "272730",
                IsDone = false
            };
            List<Restriction> testRestrictions = new List<Restriction>()
            {
                new Restriction { City="Москва", DateTimeInfo=DateTime.Now, RestrictionsCount=5},
                new Restriction{ City="Саратов", DateTimeInfo=DateTime.Now, RestrictionsCount=4},
                new Restriction{ City="Волгоград", DateTimeInfo=DateTime.Now, RestrictionsCount=5}
            };
            var result = ordersVM.OrderUnderRestrict(testOrder, testRestrictions);

            Assert.AreEqual(result, false);
        }

        /// <summary>
        /// По Саратову нет лимита заявок
        /// </summary>
        [TestMethod]
        public void OrderUnderRestrictTestMethod3()
        {
            var ordersVM = new OrdersViewModel();
            Order testOrder = new Order
            {
                Id = 3,
                City = "Саратов",
                Address = "Moskovskaya 48",
                FullName = "Ivan Ivanovich Egorov",
                MeasuringDate = DateTime.Now,
                Phone = "272730",
                IsDone = false
            };
            List<Restriction> testRestrictions = new List<Restriction>()
            {
                new Restriction { City="Москва", DateTimeInfo=DateTime.Now, RestrictionsCount=5},
                //new Restriction{ City="Саратов", DateTimeInfo=DateTime.Now, RestrictionsCount=5},
                new Restriction{ City="Волгоград", DateTimeInfo=DateTime.Now, RestrictionsCount=5}
            };
            var result = ordersVM.OrderUnderRestrict(testOrder, testRestrictions);

            Assert.AreEqual(result, true);
        }
    }
}
