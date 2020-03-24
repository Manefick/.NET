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

    //работа з Перечислениями
    class DataType
    {
        // перечисления
        public enum EmpType
        {
            Manager =10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }
        public static void LearnENum()
        {
            EmpType emp = EmpType.Manager;//перемееная типа перечисления которого мы создали 
            AskEnum(emp);
            //Console.WriteLine(Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine((int) emp);
            ParseEnum(emp);
            
        }
        public static void ParseEnum(System.Enum e)
        {
            // Хотим вывести все значения перечисления
            Array EnumValue = Enum.GetValues(e.GetType());
            for(int i = 0; i < EnumValue.Length; i++)
                Console.WriteLine("Name : {0}, Value: {0:D}", EnumValue.GetValue(i));
        }

        public static void AskEnum(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("Manager");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("Contractor");
                    break;
            }
        }
    }

    class UseStructures
    {
        struct Point
        {
            // поля(аргументі структур)
            public int x;
            public int y;

            //Конструктор структуры(они одинаковые и для класов и тд)
            public Point(int Xreg, int Yreg)
            {
                x = Xreg;
                y = Yreg;
            }

            //методы структуры
            public void Plus()
            {
                x++; y++;
            }
            public void Minus()
            {
                x--; y--;
            }
            public void Display()
            {
                Console.WriteLine($"X ={x}, Y = {y}");
            }

        }
 
        // Создание перемееной типа поинт/больше похоже на создание екземпляра класса в питоне
        // Этот тип !структура! очень похож на клас в питоне
        public static void UsePoint()
        {
            Point k;
            k.x = 10;
            k.y = 88;
            k.Display();

            Point o = new Point();
            o.Display();
            o.Plus();
            o.Display();
            //вызвали конструктор
            Point RR = new Point(69, 228);
            RR.Display();
        }
    }
    // кортежи
    class FunTuple
    {
        public static void Tup()
        {
            (string, int, string) values = ("a", 5, "c");
            var v = ("a", 5, "c");
            Console.WriteLine(values.Item1);
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
            Console.WriteLine(valuesWithNames2.TheNumber);
            Console.WriteLine(v.Item1);
        }
    }

}