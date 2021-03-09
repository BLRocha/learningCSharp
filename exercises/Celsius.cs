namespace dot.exercises
{
    public class Celsius : ITemperature
    {
        public double Temperature(double value)
        {
            return (value - 32) * 5/9;
        }
    }
}