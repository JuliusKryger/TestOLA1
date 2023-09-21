using App;  // Add this to use the TemperatureConverter from the class library.

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestFahrenheitToCelsius()
        {
            var converter = new TemperatureConverter();
            var result = converter.FahrenheitToCelsius(32);
            Assert.Equal(0, result);
            
            result = converter.FahrenheitToCelsius(212);
            Assert.Equal(100, result);
        }
    }
}