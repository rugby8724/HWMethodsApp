using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMethods
{
    internal class WelcomeMethod
    {
        public static string Welcome()
        {
            Console.WriteLine("Welcome to the App. What is your name? ");
            string output = Console.ReadLine();
            return output;
        }

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}, Enjoy the App");
        }
    }
}
