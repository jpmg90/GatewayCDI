using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello FizzBuzz" + Environment.NewLine);
            
            // Loop from 1 to 100
            for(int index = 1; index <= 100; index++)
            {
                string writeString = index.ToString() + " - ";
                // Check if multiple of 3 if so Print Fizz
                if(index%3 == 0)
                {
                    writeString += "Fizz";
                }
                // Check if multiple of 5 if so Print Buzz 
                if (index % 5 == 0)
                {
                    writeString += "Buzz";
                }
                //(notice it's not an else if so if it's both casses it will print "FizzBuzz")
                Console.WriteLine(writeString);
            }
        }
    }
}
