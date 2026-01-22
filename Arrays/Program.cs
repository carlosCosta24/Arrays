using System;
//providing various arrays methods
using System.Linq;



namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Ages = { 10, 15, 20, 25 };
            //print the first element
            Console.WriteLine($"the first element in the ages array is: {Ages[0]}");
            Console.WriteLine($"the second element in the ages array is: {Ages[1]}");
            Console.WriteLine($"the third element in the ages array is: {Ages[2]}");

            //loop through the array 

            Console.WriteLine("Printing the array elements");

            for (byte i = 0; i < Ages.Length; i++) {
                Console.WriteLine($"{i + 1} element is: {Ages[i]}");
            }
            // 2D array
            int[,] D = { { 1, 2, 3 }, { 4, 3, 5 } };
            // access first element of the firs array
            Console.WriteLine(D[0,0] + " Is the First Element Of The First Array");
            Console.WriteLine(D[1, 0] + " Is the First Element Of The Second Array");

            //foreach loop
            char[] MyName = { 'C', 'a', 'r','l','o','s' };
            foreach (char c in MyName)
            {
                Console.WriteLine($"\n {Char.ToUpper(c)} ");
            };
            //foreach with condition
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int m = 0 , f = 0;
            foreach (char c in gender) {
                if (c == 'm')
                {
                    m++;
                }
                else
                {
                    f++;
                }
            };
            Console.WriteLine($"The Number Of Mens Is: {m}");
            Console.WriteLine($"The Number Of Weman Is: {f}");

            //Using system.linq
            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };
            Console.WriteLine("Smallest Element is: " + numbers.Min());
            Console.WriteLine("Maximum Element is: " + numbers.Max());
            //Another system.linq methods
            Console.WriteLine("Count of Element is: " + numbers.Count());
            Console.WriteLine("Sum of Element is: " + numbers.Sum());
            Console.WriteLine("Average Element is: " + numbers.Average());


            Console.ReadKey();

        }
    }
}
