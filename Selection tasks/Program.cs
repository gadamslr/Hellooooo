using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_tasks
{
    internal class Program
    {
        // Main program 
        static void Main(string[] args)
        {
            string user_name;

            Console.WriteLine("Hello world!");

            Console.WriteLine("Please enter your name: ");
            user_name = Console.ReadLine();  // Reads in the value entere in the console

            Console.WriteLine("Hello " + user_name);

            Console.ReadLine();
        }
    }
}
