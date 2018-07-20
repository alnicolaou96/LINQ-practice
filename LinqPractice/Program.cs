using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //making an array of random numbers
            int n;
            Console.Write("input length of array: ");
            n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] array = new int[n];

            for(int i=0; i < array.Length; i++)
            {
                array[i] = (r.Next(1, n));
            }
            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(" "+array[i]);
            }
            Console.WriteLine("\n\n");


            //query to select greater than six
            var GreaterThanSix = from number in array
                                 where number > 6
                                 select number;
            //prints query
            Console.WriteLine("Greater than 6: ");
            foreach (var number in GreaterThanSix)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine("\n");


            //query only select number that start with one and doubles them
            var ContainsOne = from number/*variable*/ in array           //defines the source 
                              where number.ToString().StartsWith("1")    //filters
                              select number*2;                           //projects and/or change the output

            //prints query
            Console.WriteLine("Starts with 1 then doubled: ");
            foreach (var number in ContainsOne)
            {
                Console.Write(number+", ");
            }
            Console.WriteLine("\n");

            //fizz buzz query
            var FizzBuzz = from number in array
                           select (number % 3 == 0 && number % 5 == 0) ? "fizzBuzz" : (number % 3 == 0) ? "Fizz" : (number % 5 == 0) ? "Buzz" : number.ToString();

            //prints query
            Console.WriteLine("FizzBuzz: ");
            foreach (var number in FizzBuzz)
            {
                Console.Write(number+", ");
            }
            Console.WriteLine();
        }
    }
}
