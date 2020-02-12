using System;

namespace C_Sharo_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Input: ");
            string input = Console.ReadLine(); // Store user input 
            Console.WriteLine(":( " + input + ":)");

            string output = GetOutput();
            output = Smileatthebeginning(output);
            output = Smileatend(output);
            Console.WriteLine(output);
        }
            static string GetOutput()
            {
                Console.WriteLine("Enter Input: ");
                return Console.ReadLine();
            }

            static string Smileatthebeginning( string output)
            {
               output = output + " :) ";
               return output; 
            }

            static string Smileatend( string output)
            {    output = " :( " + output;
                return output; 
            }

        
    }
}
