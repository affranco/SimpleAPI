using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

        }

        ValuesController controller = new ValuesController();[Fact]
        public void GetReturnsCorrectNumber()
        {

            var returnValue = controller.Get(1);
            Assert.Equal("Andres Franco", returnValue.Value);
            
        }
    }
}
