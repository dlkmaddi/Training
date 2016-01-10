using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
                numbers[2]=103;

            SimpleMethod(numbers);
           
            
        }

        public static void SimpleMethod(params int[] numbers)
        {

            Console.WriteLine("The elements are = " + numbers.Length);
            
            for(int i=0;i<numbers.Length;i++)
               
            {
                Console.WriteLine(numbers[i);
            }

            Console.Read();
        }



    }

}
