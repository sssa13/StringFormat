using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrinfFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();
            numbers.Add("23.8976,12.3218");
            numbers.Add("25.7639,11.9463");
            numbers.Add("24.8293,12.2134");

           

             //    foreach (string str1 in numbers)
             //    {
             //        Console.Write("X:" + "{0:00,0000}", str1.Remove(7));
             //        Console.WriteLine(" Y:" + "{0:00.0000}", str1.Substring(8));
             //    }



            int i = 0;                                              
            while (i < numbers.Count)
            {
                string str1 = numbers[i];
                Console.Write("X:" + "{0:00,0000}", str1.Remove(7));  // удаляем после 7-го символа
                Console.WriteLine(" Y:" + "{0:00.0000}", str1.Substring(8));   // // удаляем до 8-го символа
                i++;
            }



          
            Console.ReadKey();



        }
    }
}
