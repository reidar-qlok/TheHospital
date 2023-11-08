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
        public string Profession { get; set; }

        public Nurse(string name, int age, string id, string department, string profession) : base(name, age, id)
        {
            Department = department;
            Profession = profession;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Department: {Department}, Profession: {Profession}");
        }
    }
}