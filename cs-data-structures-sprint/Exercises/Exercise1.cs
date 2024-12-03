using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Exercises
{
    internal class Exercise1
    {       
        public static void PrintExesAndOhs()
        {
            // write your code here
            //some value that counts up
            //
            int exOrOh = 0;
            char[] content = ['X', 'O'];
            //char[][] exesAndOhsArray = new char[5][];
            char[,] exesAndOhsArray = new char[5, 5];
            for (int i = 0; i< exesAndOhsArray.GetLength(0); i++)
            {

                // exesAndOhsArray[i] = new char[5];
                for (int j = 0; j < exesAndOhsArray.GetLength(1); j++)
                {
                    exOrOh++;
                    if (exOrOh % 2 == 0)
                    {
                        //exesAndOhsArray[i][j] = content[1];
                        exesAndOhsArray[i,j] = content[1];
                    }
                    else
                    {
                        //exesAndOhsArray[i][j] = content[0];
                        exesAndOhsArray[i,j] = content[0];
                    }
                        
                }
                
                //if even logic plus for loop logic to make x, o, x, o 


            }
            //foreach (char chr in exesAndOhsArray)
            //{
            //    Console.Write(chr + " ");
            //}



            for (int i = 0; i < exesAndOhsArray.GetLength(0); i++)
            {

                //foreach (char xOrO in exesAndOhsArray[i])
                for (int j = 0; j < exesAndOhsArray.GetLength(1); j++)
                {

                    //Console.Write(xOrO + " ");
                    Console.Write(exesAndOhsArray[i,j] + " ");
                }
                Console.Write("\n");
            }
            //int[,] twoDimensionalArray = new int[5, 5];


            //x o x o x
            //o x o x o
            //x o x o x
            //o x o x o
            //x o x o x
        }
    }
}
