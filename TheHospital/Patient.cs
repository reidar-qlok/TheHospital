using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHospital
{
    public class Patient : Human
    {
        public string Diagnosis { get; set; }
        public Patient(string name, int age, string id, string diagnosis) : base(name, age, id)
        {
            Diagnosis = diagnosis;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Diagnosis: {Diagnosis}");
        }
    }
}
