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
            //инизализация неявнотипизированого масива 
            var ArrInt = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(ArrayInt.ToString());
            // Что бы записать в масив любые обэкты(разные типи даных) нужно обьявить тип массива как object
            object[] MyArray = { 1, "Missi", 'H', 44, true };
            foreach(object k in MyArray)
            {
                Console.WriteLine($"Type:{k.GetType()}; Value: {k} ");
            }
            Array.Reverse(ArrayInt);
            foreach (int k in ArrayInt)
                Console.WriteLine(k);
        }
     public static double Avg(params double[] Mass)
        {
            // использование params  это как args*  в питоне 
            double sum = 0;
            if (Mass.Length == 0)
                return sum;
            foreach(double i in Mass)
            {
                sum += i;
            }
            return sum / Mass.Length;
        }


    } 
    //перегрузка операторов
    class ReloadOperators
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static string Add(string x, string y)
        {
            return x + y;
        }
    }

}