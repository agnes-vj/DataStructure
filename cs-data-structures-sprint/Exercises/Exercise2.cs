using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise2
    {
        //public static void PrintFirstAndLast(LinkedList<string> list)
        //{
        //    // write your code here
        //    Console.WriteLine("First Element : " + list.First.Value + " Last Element : " + list.Last.Value);

                
        //}

        
        public static void PrintFirstAndLast<T>(LinkedList<T> list)
        {
            //T firstElement =
            Console.WriteLine("First Element : " + list.First.Value + " Last Element : " + list.Last.Value);

        }
        
    }
}
