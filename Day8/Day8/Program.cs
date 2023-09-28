

using System.Collections.Generic;

namespace Day8
{
    public class Program
    {

        public static void Main()

        {

            List<int> myList = new List<int> { 5, 2, 7, 1, 3 };
            Console.WriteLine("1- show first number");
            Console.WriteLine("2-show last number");
            Console.WriteLine("3- number %2");
            Console.WriteLine("4-Show first number and scend number");
            Console.WriteLine("5-show number *number");
            Console.WriteLine("6-Exit");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            switch (choice)
            {
                case 1:
                    int first = myList.First();
                    Console.WriteLine(first);
                    break;
                        case 2:
                    int last = myList.Last();
                    Console.WriteLine(last);
                    break;
                        case 3:
                    IEnumerable<int> evenNumbers = myList.Where(x => x % 2 == 0);
                    Console.WriteLine(string.Join(", ", evenNumbers));
                    break;
                    case 4:
                    IEnumerable<int> firstTwo = myList.Take(2);
                    Console.WriteLine(string.Join(", ", firstTwo));
                    break;
                case 5:
                    IEnumerable<int> squaredList = myList.Select(x => x * x);
                    Console.WriteLine(string.Join(", ", squaredList));
                    break;


            }




            //    int last = myList.Last();
            //    Console.WriteLine(last);   

           

        

           
            //
        }

    }
}