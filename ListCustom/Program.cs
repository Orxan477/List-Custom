using ListCustom.Models;
using System;

namespace ListCustom
{
    class Program
    {
        // private static object result;
        delegate bool Mach(int number);
        static void Main(string[] args)
        {

            MyList<int> number = new MyList<int>();
         //   MyList<int> result = number.FindAll(n => n < 5);
            number.Add(5);
            number.Add(20);
            number.Add(30);
            number.Add(-300);
           // Console.WriteLine(number.IndexOf(20)); 
            //Console.WriteLine(number);
            //for (int i = 0; i < number.Length(); i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            // number.Find(25);
            MyList<int> result = number.FindAll(n => n > 5);
            for (int i = 0; i < result.Length(); i++)
            {
                Console.WriteLine(result[i]);
            }
            //// number.Find(n => n < 4);
        }
        
    }
}
