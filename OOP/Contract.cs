using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Contract
    {
        private Random _random = new Random();
        public int Id { get; set; } //unikátní identifikátor
        public float Salary { get; set; } //plat
        public bool TrialPeriod { get; set; } //zkušební doba
        public DateTime DateOfValidity { get; set; } //datum platnosti

        public Contract(int id, float salary, bool trialPeriod, DateTime dateOfValidity)
        {
            Id = _random.Next();
            Salary = salary;
            TrialPeriod = trialPeriod;
            DateOfValidity = dateOfValidity;
        }

        public Contract() 
        {
            
        }
    }
}
