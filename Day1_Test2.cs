using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace HomeworkDay1
{
    
    [TestClass]
    public class Day1_Test2
    {
        [TestMethod]
        public void 三筆一組加總Cost()
        {
            //arrange
            var expected = new int[] { 6, 15, 24, 21 };
            //act
            var Source = Substitute.For<Source<int>>();
            Source.Sum(3).Returns(new int[] { 6, 15, 24, 21 });
            var actual = Source.Sum(3);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 四筆一組加總Revenue()
        {
            //arrange
            var expected = new int[] { 55,66,60 };
            //act
            var Source = Substitute.For<Source<int>>();
            Source.Sum(4).Returns(new int[] { 55, 66, 60 });
            var actual = Source.Sum(4);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public interface Source<T> 
    {
        int[] Sum(int Num);
    }
}
