using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Part_Two
    {
     public static void Arrays()
        {
            int[] ArrayInt = {1,2,3,4,5 };//масив с 5 елементов int
            string[] ArrayString = new string[3]; //масив с 3 елементов типа стринг
            ArrayString[0] = "a";
            ArrayString[1] = "b";
            ArrayString[2] = "c";
            for (int i = 0; i < ArrayString.Length; i++)
                Console.WriteLine(ArrayString[i]);
            foreach (int i in ArrayInt)
                Console.WriteLine(i);
        }   

    } 

}