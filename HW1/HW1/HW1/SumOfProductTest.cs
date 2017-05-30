using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HW1
{
    [TestClass]
    public class SumOfProductTest
    {
        [TestMethod]
        public void 三比一組取cost總和()
        {
            //arrange
            var Product = new Items().GetList();
            var expected = new List<int> { 6, 15, 24, 21 };
            var actual = new Calculator().SumByCost(Product, 3).ToList();  //act
            CollectionAssert.AreEqual(expected, actual);  //assert

        }

        [TestMethod]
        public void 四比一組取Revenue總和()
        {
            //arrange
            var Product = new Items().GetList();
            var expected = new List<int> {50,66,60};
            var actual = new Calculator().SumByRevenue(Product, 4).ToList();  //act
            CollectionAssert.AreEqual(expected, actual);  //assert

        }

    }

    public class Items : IProduct
    {
        public int Cost { get; set; }
        public int Id { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }

        public List<IProduct> GetList()
        {
            return new List<IProduct>()
            {
                new Items() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new Items() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new Items() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new Items() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new Items() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new Items() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new Items() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new Items() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new Items() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new Items() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new Items() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 },
            };
        }
    }

    public interface IProduct
    {
        int Id { get; set; }
        int Cost { get; set; }
        int Revenue { get; set; }
        int SellPrice { get; set; }
        List<IProduct> GetList();
    }

    public class Calculator
    {
        public IEnumerable<int> SumByCost(IEnumerable<IProduct> orders, int s)
        {
            var result = new List<int>();
            var x = orders.Select(r => r.Cost);
            for (int i = 0; i <= x.Count() / s; i++)
            {
                result.Add(x.Skip(i * s).Take(s).Sum());
            }
            return result;
        }

        public IEnumerable<int> SumByRevenue(IEnumerable<IProduct> orders, int s)
        {
            var result = new List<int>();
            var x = orders.Select(r => r.Revenue);
            for (int i = 0; i <= x.Count() / s; i++)
            {
                result.Add(x.Skip(i * s).Take(s).Sum());
            }
            return result;
        }
        
    }
}
