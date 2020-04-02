using System;


namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            string input = Console.ReadLine();
            uint arrLength = Convert.ToUInt32(input);   //convert input to positive integer


            Console.WriteLine("enter the multiplier");
            input = Console.ReadLine();
            double multi = Convert.ToDouble(input);     //convert input to double - can be negative 


            double[] array = new double[arrLength];     //initialize array
            Console.WriteLine($"num of elements: {arrLength} \n" +
                        $"value of multiplier: {multi}");


            Console.Write("array content: ");
            for (UInt32 i = 0; i < arrLength; i++)
            {
                array[i] = i * multi;
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
