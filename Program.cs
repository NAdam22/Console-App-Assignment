using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is a do while loop

            int Count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                Count++; // add one to count each time.
            }

            while (Count < 5); // Continue to loop until counting reaches 5

            // This is a while loop

            int Counting = 0;
            while (Counting < 3) ; // continue to loop until countimg reaches 3

            {
                Console.WriteLine("Counting numbers");
                Counting++; // add one to counting each time
            }

            Console.ReadLine();
        }
    }
}
