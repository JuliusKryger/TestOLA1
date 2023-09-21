namespace App
{
    public class TemperatureConverter
    {
        public double FahrenheitToCelsius(double fahrenheit)
        {
            //Fahrenheit to Celsius Formula: (°F - 32) / 1.8 = °C
            return Math.Round((fahrenheit - 32) / 1.8, 1);
        }
        public double CelsiusToFahrenheit(double celsius)
        {
            //Celsius to Fahrenheit Formula: (°C * 1.8) + 32 = °F
            return Math.Round((celsius * 1.8) + 32, 1);
        }
    }
}