using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Collections;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnWeatherForcast()
        {
            var returnValue = controller.Get();
            Assert.Equal("I'm fad the great!", returnValue.ToString());
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
