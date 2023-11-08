using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHospital
{
    public class Nurse : Human
    {
        public string Department { get; set; }

        public Nurse(string name, int age, string id, string department) : base(name, age, id)
        {
            Department = department;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Department: {Department}");
        }
    }
}