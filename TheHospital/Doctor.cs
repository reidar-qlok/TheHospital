using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHospital
{
    public class Doctor : Human
    {
        public string Specialty { get; set; }
        public Doctor(string name, int age, string id, string specialty) : base(name, age, id)
        {
            Specialty = specialty;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Specialty: {Specialty}");
        }
    }
}
