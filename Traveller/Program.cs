using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the age of your best friend?");
            int age = int.Parse(Console.ReadLine());
            Cruiseline Jim = new Cruiseline(age);
        }
    }
}
