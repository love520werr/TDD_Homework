using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HarryPoterBookStore
{
    [TestClass]
    public class BookStoreTest
    {
        [TestMethod()]
        public void test1_1_0_0_0_0_should_be_100()
        {
            List<Product> productCar = new List<Product>()
            {
                new Product(Name: "Harry_Potter_first", Price:100, count:1)
            };

            var expected = 100;

            var actual = CalculatePrice(productCar);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void test2_1_1_0_0_0_should_be_190()
        {            
            List<Product> productCar = new List<Product>()
            {
                new Product(Name: "Harry_Potter_first", Price:100, count:1),
                new Product(Name: "Harry_Potter_sec", Price:100, count:2)
            };

            var expected = 190;
            var actual = CalculatePrice(productCar);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void test3_1_1_1_0_0_should_be_270()
        {            
            List<Product> productCar = new List<Product>()
            {
                new Product(Name: "Harry_Potter_first", Price:100, count:1),
                new Product(Name: "Harry_Potter_sec", Price:100, count:2),
                new Product(Name: "Harry_Potter_third", Price:100, count:3)
            };

            var expected = 270;
            var actual = CalculatePrice(productCar);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void test4_1_1_1_1_0_should_be_320()
        {            
            List<Product> productCar = new List<Product>()
            {
                new Product(Name: "Harry_Potter_first", Price:100, count:1),
                new Product(Name: "Harry_Potter_sec", Price:100, count:2),
                new Product(Name: "Harry_Potter_third", Price:100, count:3),
                new Product(Name: "Harry_Potter_fourth", Price:100, count:4)
            };

            var expected = 320;
            var actual = CalculatePrice(productCar);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void test5_1_1_1_1_1_should_be_375()
        {
            List<Product> productCar = new List<Product>()
            {
                new Product(Name: "Harry_Potter_first", Price:100, count:1),
                new Product(Name: "Harry_Potter_sec", Price:100, count:2),
                new Product(Name: "Harry_Potter_third", Price:100, count:3),
                new Product(Name: "Harry_Potter_fourth", Price:100, count:4),
                new Product(Name: "Harry_Potter_fiveth", Price:100, count:5)
            };

            var expected = 375;
           
            var actual = CalculatePrice(productCar);
            Assert.AreEqual(expected, actual);
        }        

        public object CalculatePrice(List<Product> productCar)
        {
            throw new NotImplementedException();
        }
    }
    public class Product
    {     
        public string Name { get; }
        public int Price { get; }
        public int count { get; set; }
        public Product(string Name, int Price, int count)
        {
            this.Name = Name;
            this.Price = Price;
            this.count = count;
        }
    }
}
