using System;

namespace dot.interfaces
{
    public class RentalService
    {
        public double PrinceHour { get; private set; }
        public double PrinceDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double princeHour, double prenceDay,ITaxService taxService)
        {
            PrinceHour = princeHour;
            PrinceDay = prenceDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.00)
            {
                basicPayment = PrinceHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PrinceDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);
            
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}