using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TestApp10122020
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, location1, location2, weather, cweight, dweight;
            int diffweight; //Easier to have difference has integer now then conver ting it later. 
            Console.Write("Hello! Please enter your name: ");
            name1 = Console.ReadLine();
            Console.WriteLine($"Hello, {name1}.");
            Console.ReadKey();
            Console.Write("Where do you live? ");
            location1 = Console.ReadLine();
            Console.Write($"Oh, you live in {location1}, how is the weather right now? ");
            weather = Console.ReadLine();
            Console.Write($"Wow! Someone told me that the weather was {weather}. Tell me, where would you like to live? ");
            location2 = Console.ReadLine();
            Console.WriteLine($"{location2}? Cool, I hope you can move there.");
            Console.ReadKey();
            Console.Write("How much do you weigh? ");
            cweight = Console.ReadLine();
            Console.Write("Nice, how much do you want to weigh in the future? ");
            dweight = Console.ReadLine();

            diffweight = Convert.ToInt32(cweight) - Convert.ToInt32(dweight); //Converts the weights from strings to integers. Make sure diffweight is an int. //
            Console.WriteLine($"That's a difference of {diffweight}. I hope you can get there. Keep working hard!");
            Console.ReadKey();
            Console.WriteLine("I have to go. Take care!");
            Console.ReadKey();
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
            
        }
    }
}
