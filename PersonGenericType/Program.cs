using Person;

namespace PersonGenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<string> Anvar = new Person<string>("Anvar");
            Person<string> Guli = new Person<string>("Guli");

            Person<string>.GetMarried(Anvar, Guli);
            Console.WriteLine($"Anvarning turmush o`rtog`i {Anvar.Spouse.Name}");
            Console.WriteLine($"Gulining turmush o`rtog`i {Guli.Spouse.Name}");
            Person<string> Lola = new Person<string>("Lola");
            Anvar.GetMarried(Lola);
        }
    }
}