using System;
using System.Collections.Generic;

using dot.entities.enums;

namespace dot.entities
{
    public class Worker
    {
        public string Name { get; set; }
        public  WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new
            List<HourContract>();

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel workerLevel,
            double baseSalary, Department department)
        {
            Name = name;
            Level = workerLevel;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContarct(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mount)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mount)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}