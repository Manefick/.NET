using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            //LINQ немедленое выполнение
            //string[] names = { "Sasha+Inna", "Sasha+Oksana", "Igor", "mISHA", "Sasha+Naruto", "Beer" };
            //LINQ linq = new LINQ();
            //string[] result = linq.TestLinq(names);
            //foreach(var i in result)
            //{ Console.WriteLine(i); }
            ////LINQ отложеное выполнение, вместо var  почти всегда подходит IEnumerable<T>
            //var sasha = from i in names where i.Contains("Sasha") select i;
            //foreach(var k in sasha)
            //{ Console.WriteLine(k); }

            Cinema cinema = new Cinema();
            cinema.ShowViewers();
            cinema.agregate();

            //простой делегат

            //Glava10.Binary b = new Glava10.Binary(Glava10.SimpleMath.Add);
            //Console.WriteLine(b(10, 5));
            //Glava10.DelegateInfo(b);

            //применения делегатов для обратных вызовов в приложениях,

            //Glava10.Car c1 = new Glava10.Car(10, 100, "dog");
            //c1.RegisterWithCarEngine(new Glava10.Car.CarEngineHandler(OnCarEngineEvent));
            //c1.RegisterWithCarEngine(new Glava10.Car.CarEngineHandler(OnCarEngineEvent1));


            //Console.WriteLine("***** Speeding up *****");
            //for (int i = 0; i < 6; i++)
            //    c1.Accelerate(20);

            //Что бы не писать ((c1.RegisterWithCarEngine(new Glava10.Car.CarEngineHandler(OnCarEngineEvent));))
            // можно указать просто метод, например:

            //Glava10.Car c2 = new Glava10.Car(10, 100, "Cat");
            //c2.RegisterWithCarEngine(DelegtText);
            //Console.WriteLine("***** Speeding up *****");
            //for (int i = 0; i < 6; i++)
            //    c2.Accelerate(20);

            //Использование специальных обобщенных делегатов Action i Func 

            //Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(Glava10.DisplayMessage);
            //actionTarget("sasha", ConsoleColor.Red, 5);

            //Func<int, int, int> funcTarget = new Func<int, int, int>(Glava10.Metod_func);//полная запись
            //Console.WriteLine(funcTarget(10,50));
            //Func<int, int, int> func1 = Glava10.SimpleMath.Add;//можно просто указать имя метода 
            //Console.WriteLine(func1(99, 99));

            //События

            //Glava10.Car2 car2 = new Glava10.Car2(10, 100, "bob");
            //car2.Exploed += OnCarEngineEvent;
            //car2.AboutToBlow += OnCarEngineEvent1;
            //Glava10.Car2.CarEngineYandler d = new Glava10.Car2.CarEngineYandler(DeledFunk);
            //car2.AboutToBlow += d;
            //car2.AboutToBlow += delegate (string s)//использование анонимных методов вместо фунций
            //{
            //    Console.WriteLine("Using anonim method {0}", s);
            //    car2.PetName2 = "Ssss";
            //};
            //car2.AboutToBlow += (string ss) => { Console.WriteLine("Using Lambda: {0}", ss); };// использование лямда выражений

            //for (int i = 0; i < 6; i++)
            //    car2.Accelerate2(20);
            //car2.AboutToBlow -= d;
            //Console.WriteLine(car2.PetName2);

            //использование лямбда выражений

            //List<int> list = new List<int>();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //List<int> eventNumbers = list.FindAll(delegate (int i)
            //     { return (i % 2) == 0; }) ;
            //List<int> NeChetni = list.FindAll(i => (i % 2) != 0);//использование сокращенной записи
            //foreach (int e in eventNumbers)
            //    Console.WriteLine(e);
            //foreach (int x in NeChetni)
            //    Console.WriteLine(x);

            ////ИНТЕРФЕЙСЫ
            //Shape[] s = { new Triangle("Triangle", 3), new Square("square"), new Circle("circle", 34) };
            //for(int i =0; i < s.Length; i++)
            //{
            //    if (s[i] is IPoint ip)
            //    {
            //        Console.WriteLine("The {0}  have {1} points", s[i].Name, ip.Points);
            //    }
            //    else Console.WriteLine("The {0} dont have points", s[i].Name);
            //}

            //Number num = new Number();
            //foreach(One t in num)
            //{
            //    Console.WriteLine(t.O);
            //}
            ////use yield
            //Second ss = new Second();
            //foreach (Two tt in ss)
            //    Console.WriteLine(tt.T);

            // ИСКЛЮЧЕНИЯ
            //FunWithExeption test = new FunWithExeption("Sasha", 20);
            //try
            //{
            //    test.BuyBeer();
            //}
            //catch(Exception t)
            //{
            //    Console.WriteLine(t.Message);
            //    Console.WriteLine(t.Source);
            //    Console.WriteLine(t.HelpLink);
            //}


            //Наследование, полиморфизм
            //Mersedes mers = new Mersedes(120,100,5,"AMG",12.3);
            //mers.Display();
            //mers.Transmishion("avto");

            //свойства properties
            //Prop prop = new Prop();
            //prop.PetName = "Mazda";
            //prop.MyCar.Id = 1444444;
            //Console.WriteLine("{0}----{1}", prop.Speed,prop.MyCar.Pay );
            //prop.MyCar.Print();
            //Employee e = new Employee("Sasha", 124, 10000);
            //e.GiveBonus(999);
            //e.Print();
            //e.Name = "Inna";

            //Car bibi = new Car();
            //bibi.PrintInfoCar();
            //Car bib = new Car("Toyota",99);
            //bib.PrintInfoCar();

            //Part_Two.Arrays();

            //double[] kk = {1.2, 1.4, 0.4 };
            //Console.WriteLine(Part_Two.Avg(kk));

            //Console.WriteLine(ReloadOperators.Add(3, 5));
            //Console.WriteLine(ReloadOperators.Add("Sasha","Grinchuck" ));

            //DataType.LearnENum();
            //UseStructures.UsePoint();
            //FunTuple.Tup();

            //Создание екземпляра класса и вызов его метода
            //Part_Two Test = new Part_Two();
            //Console.WriteLine(Test.Avg(kk));
            // Перший спосіб написання циклу используеться при когда нужно конкретное к-во повторений
            //for (int i = 0; i < args.Length; i++)
            //    Console.WriteLine("Arg : {0}", args[i]);

            // другрий спосіб написання циклу используется для итерации по контейнеру

            //foreach (string arg in args)
            //  Console.WriteLine("Argument: {0}", arg);



            //UsingForeach(args);
            //UseReadline();
            //LocalVar();
            //NewAndDefault();
            //UseChar();
            //UseParse();
            //ParseFromStringsWithTryParse();
            //UseBigInteger();
            //StringFunctionality();
            //UseStringBilder();
            //TypesConvertation();
            //NeYavnoType();
            //Cikle_and_IF();
            //SwitchOnStnngExample();
            Console.ReadLine();

            return -1;
        }

        //методu который вызываеться делегатом
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*********************************\n");
        }
        public static void OnCarEngineEvent1(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg.ToUpper());
            Console.WriteLine("*********************************\n");
        }
        public static void DelegtText(string i)
        {
            Console.WriteLine("Mesage: {0}", i);
        }
        public static void DeledFunk(string k)
        {
            Console.WriteLine($"Delete metod {k}");
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
            char.IsLetter("dff3ff", 2));
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
            if (bool.TryParse("True", out bool b))
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

        static void UseBigInteger()
        {
            // Используем биг интеджер с библиотеки нумеретикс
            BigInteger val = BigInteger.Parse("9");
            Console.WriteLine(val);
            BigInteger large = 9;
            BigInteger huge = val + large;
            Console.WriteLine(huge);
        }

        static void StringFunctionality()
        {
            //Методы для работы со строками
            string MyName = "Alexandr Sasha h l p";
            String MySurname = "Grinchuck";

            Console.WriteLine("Len str= {0}", MyName.Length);
            Console.WriteLine("Replace 'xa' na 'XX' = {0}", MyName.Replace("xa", "XXX"));
            //  Tак работает Split
            string[] m = MyName.Split(' ');
            foreach (string i in m)
            {
                Console.WriteLine(i);
            }
            //конкатенация строк
            string sum = MyName + MySurname;
            Console.WriteLine(sum);
            // Специальные\управляющие символы 
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            //дословные строки (специальные\управяющие символы будут игнорироваться)
            Console.WriteLine(@"С:\MyApp\bin\Debug");
            //проверка на равенство строк
            if (MyName == MySurname)
            {
                Console.WriteLine("строки равны");
            }
            else
            {
                Console.WriteLine("строки не равны");
            }
            Console.WriteLine(MyName.Equals(MySurname));
            Console.WriteLine(MySurname[0]);
            // интерполяція строк
            Console.WriteLine($"My name {MyName}, but my surname is {MySurname}");
        }

        static void UseStringBilder()
        {
            //Этот класс позволяет создавать обьект похожий на строку но который можно изменять
            StringBuilder sb = new StringBuilder("Sasha alex");
            sb.AppendLine("Inna");
            sb.Replace("Sasha", "grinchuck");
            Console.WriteLine(sb.ToString());// чтобы вывести обэкт класа StringBilder нужно преобразовать его в строку
        }

        static void TypesConvertation()
        {
            // Преобразование типов
            short num1 = 30000, num2 = 30000;
            // ключевое слово checked выполняет проверку на переполнения и вызывает исключение
            try
            {// явное приведение к типу short, но если пробразовывать
             //большой тип(int32) в маленький(int16)  с помощю (short) то получиться переполнение и потеря даных
                short ansver = checked((short)Add(num1, num2));
                Console.WriteLine(ansver);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NeYavnoType()
        {
            // для неявной типизации обьектов перед ними используеться слово var
            var num = 12;
            string s = "Urban bar";
            Console.WriteLine($"{num.GetType().Name} and {s.GetType().Name}");

        }
        static void Cikle_and_IF()
        {
            //Описание циклов и условных операторов
            int a = 1;
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.WriteLine(a);
            //do/while используеться для тоо что бы выполнить код хотябы один раз если 
            // в блоке while условие не выполняеться !!делай это пока условие не выполниться!!
            do
            {
                Console.WriteLine(a);
            } while (a < 0);

            // if else
            if (a >= 5)
            {
                Console.WriteLine("chuslo is big");
            }
            else { Console.WriteLine("Chislo is small"); }
            // условная операция (сокращенная запись if else)
            // напишем ту же проверку тлько сокращенно
            Console.WriteLine(a >= 5 ? "Chuslo is big" : "chuclo is small");
            //   & - оператор И (and)
            //  || - оператор ИЛИ (or) 
            //  ! - оператор НЕ (not)
        }
        static void SwitchOnStnngExample()
        {
            // Switch сравнивает переданый ему параметр с параметрами описаными в "случаях" case
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            switch (langChoice.ToUpper())
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
        }
    }
}
