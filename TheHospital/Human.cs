using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHospital
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; } // Unique identifier for each person

        public Human(string name, int age, string id)
        {
            Name = name;
            Age = age;
            ID = id;
        }

        // Virtual method to be overridden in derived classes
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, ID: {ID}");
        }
    }
}
