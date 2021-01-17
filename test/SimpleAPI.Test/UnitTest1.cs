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
            Assert.Equal("Mugsy Biscuit Forever", returnValue.ToString());
        }

        [Fact]
        public void GetWeatherForcast()
        {
            var returnValue = controller.GetWeather();
            Assert.Equal("Today is a sunny day!!!", returnValue.ToString());
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
