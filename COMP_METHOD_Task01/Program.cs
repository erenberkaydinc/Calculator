using System;

namespace COMP_METHOD_Task01
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type a Number: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("DECIMAL: " + number);
            Calculate(2, number, "BINARY");
            Calculate(8, number, "OCTAL");
            Calculate(16, number, "HEX");


        }

        public static void Calculate(int numberBase, int number, string name)
        {
            string output = "";
            string[] array = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            while(number > 0)
            {
                int newNumber = number / numberBase;
                int remainder = number % numberBase;

                number = newNumber;

                output = $"{array[remainder]}{output}";

            }

            Console.WriteLine($"{name}: " + output);
        }

    }
}
