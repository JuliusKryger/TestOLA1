namespace App
{
    public class TemperatureConverter
    {
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}