using lab;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.City = "kiyv";
            address.Index = "02192";
            address.Country = "Ukrainian";
            address.Street = "Miropolskaya";
            address.House = "37";
            address.Apartment = "8";





            Console.WriteLine(address.City);
            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
         }
    }
 }


