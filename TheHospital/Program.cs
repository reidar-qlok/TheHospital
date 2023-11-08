namespace TheHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>()
            {
                new Doctor("Dr. Kalle",62,"1223468D", "Kardiolog"),
                new Nurse("Emely Andersson",62,"1333468N", "IVA", "Röntgen sköterska"),
                new Patient("Reidar Nilsén",62,"1995346P", "Flue")
            };
            foreach (var person in persons) 
            {
                person.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}