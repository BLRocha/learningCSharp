namespace dot.interfaces
{
    public class BrasilTaxService : ITaxService
    {
        public double Tax(double amaunt)
        {
            if (amaunt <= 100.0)
            {
                return amaunt * .2;
            }
            return amaunt * .15;
        }
    }
}