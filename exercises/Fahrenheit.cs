namespace dot.exercises
{
    public class Fahrenheit : ITemperature
    {
        public double Temperature(double value)
        {
            return (value * 9 / 5) + 32;
        }
    }
}