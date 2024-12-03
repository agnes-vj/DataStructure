using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise3
    {
        public static void SwapElementPosition(LinkedList<string> list, int index1, int index2)
        {

            int iterator = 0;

            var current = list.First;

            var index1String = list.ElementAt(index1);
            var index2String = list.ElementAt(index2);

            //LinkedListNode<string> node1Index;
            //LinkedListNode<string> node2Index;

            while (current.Next != null)
            {
                if (iterator == index1)
                {
                   current.Value = index2String;
                   
                }
                if (iterator == index2)
                {
                    current.Value = index1String;
                }
                iterator++;
                current = current.Next;
            }


        }
    }
}
//int node = 0;
//foreach (string item in list)
//{
//    if (node == index1)
//    {

//    }
//    node++;

//}




// Find Index of 
// AddBefore()
// a, b , c, d, e, f, g, 
// 0, 1 , 2, 3, 4, 5, 6,
// swap c with f
// index 2 with index 5
// index 5 add before index 2 and remove from index index 6
// a, b, f, c, d, e,  g, 
// 0 , 1, 2, 3, 4, 5, 6,
// index 3 add before index 5 and remove index 3
//
