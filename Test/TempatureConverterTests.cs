using App;  // Add this to use the TemperatureConverter and RomanNumeralConverter from the class library.

namespace Test;

public class TempatureConverterTests
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

    [Fact]
    public void TestCelsiusToFahrenheit()
    {
        var converter = new TemperatureConverter();
        var result = converter.CelsiusToFahrenheit(-17);
        Assert.Equal(1.4,result);
    }
}
