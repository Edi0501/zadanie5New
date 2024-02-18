using System;
namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Podaj swój wiek");
          //  Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 21 && age < 30)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz zostać posłem lub senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem");
            }
            else
            {
                Console.WriteLine("Nie możesz kandydować");
            }
            
        }
    }
}
