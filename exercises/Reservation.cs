using System;
using System.Text;
using dot.domainExeception;

namespace dot.exercises
{
    public class Reservation
    {
        public int RooNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {
        }

        public Reservation(int rooNumber, DateTime checkin, DateTime checkout)
        {
            RooNumber = rooNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            int duration = (int) Checkout.Subtract(Checkin).TotalDays;
            int currentDay = (int) Checkin.Subtract(DateTime.Now).TotalDays;
            if (duration <= 0)
            {
                throw new DomainExecption("The check-in date cannot be equal to or before the check-out date");
            } else if (currentDay < 0)
            {
                throw new DomainExecption("The checkout date must be equal to or later than the current date");
            }
            return duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reservation: Room {RooNumber}, check-in: {Checkin}, check-out: {Checkout.Date}," + 
                          $" {Duration()} nights");
            return sb.ToString();
        }
    }
}