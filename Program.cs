using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello");

            // Перший спосіб написання циклу 
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine("Arg : {0}", args[i]);

            // другрий спосіб написання циклу

            foreach (string arg in args)
                Console.WriteLine("Argument: {0}", arg);
            //UsingForeach(args);
            //UseReadline();
            //LocalVar();
            //NewAndDefault();
            UseChar();
            UseParse();
            ParseFromStringsWithTryParse();

            Console.ReadLine();

            return -1;
        }

        static void UsingForeach(string[] args)
        {
            foreach (string a in args)
                Console.WriteLine("pi:{0}", a);

            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("drive: {0}", drive);
            Console.WriteLine(Environment.SystemDirectory);
            Console.Beep();

        }

        static void UseReadline()
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();
            Console.WriteLine("Name: {0}", name);
        }

        static void LocalVar()
        {
            Console.WriteLine("Data declaration");
            //Види обьявления переменных
            int myInt = 12;
            
            string myString;
            myString = "This is string";

            bool a = true, b = false;

            Console.WriteLine("{0}{1}{2}{3}", myInt, myString, a, b);

        }

        static void NewAndDefault()
        {
            //методы которые устанавливают базовое значение при создании переменной
            Console.WriteLine("Metod NEW and metod DEFAULT");
            int test_int = default;
            int k = new int();
            Console.WriteLine("{0}  {1} ", test_int, k);
            Console.WriteLine("{0}", int.MaxValue);
            Console.WriteLine("{0}", double.MaxValue);
            Console.WriteLine("{0}", double.Epsilon);
            Console.WriteLine("{0}", bool.TrueString);
        }

        static void UseChar()
        {
            Console.WriteLine("Функцыи для типа char");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ( 'a') : {0}", char.IsDigit('1'));
            Console.WriteLine("char.IsLetter ( 'a ’ ) : {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsLetter: {0}",
            char.IsLetter("dff3ff",2));
            Console.WriteLine("char.IsPunctuation(’?'): {0}",
            char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void UseParse()
        {
            Console.WriteLine("Разпарсиваем строковое значение в формат который нам нужен");
            Console.WriteLine("но єтот метод не работает если в значение строки поместить не тот тип которuй хотим распарсить");
            bool b = bool.Parse("True");
            Console.WriteLine("{0}", b);
            int i = int.Parse("8");
            Console.WriteLine(i);
        }

        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("Распарсим строку с помощю метода TryParse");
            if (bool.TryParse("True", out bool b)) ;
            {
                Console.WriteLine("Value of b: {0}", b); // Вывод значения b
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d); // Вывод значения d
            }
            else
            {
                // Преобразование потерпело неудачу
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
      
        }
    }

}
