using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Class12
    {
    }
    public class LINQ
    {
        public string[] Name { get; set; }
        public LINQ() { }
        public LINQ(string[] name)
        { Name = name; }

        public  string[] TestLinq(string[] str)
        {
            var SortString = from c in str where c.Contains("Sasha") select c;
            return SortString.ToArray<string>();
        }
    }

    public class Viewer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Viewer() { }
        public Viewer(string name,string surname,string sex,int age)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1} {2} {3}", Name, Surname, Sex, Age);
        }
    }
    public class Cinema:IEnumerable
    {
        private List<Viewer> viewers = new List<Viewer>();//обобщенная колекция
        Random random = new Random();
        enum Name
        {
            Sasha,
            Inna,
            Petya,
            Vasya,
            Slavik
        }
        enum Surname
        {
            Grinchuck,
            Potter,
            Prokopiv,
            Besedovski,
            Urban
        }
        enum Sex
        {
            Man,
            Woman
        }
        public Cinema()
        {
            for(int i = 0; i<30;i++)
            {
                int k = random.Next(0, 3);
                if (k == 0)
                    viewers.Add(null);
                else
                    viewers.Add(new Viewer(((Name)random.Next(0,5)).ToString(), ((Surname)random.Next(0, 5)).ToString(), ((Sex)random.Next(0,2)).ToString(), random.Next(15, 60)));
            }
        }
        public void sortVievers()// использование LINQ на обобщенной колекции
        {
            var man = from p in viewers where p!=null && p.Age > 45 select p;
            foreach(var m in man)
            { Console.WriteLine($"{m.Name} {m.Surname} {m.Age}"); }
        }
        public void agregate()
        {
            int avg = (int)(from a in viewers where a != null select a.Age).Average();
            int count  = (from a in viewers where a != null select a.Age).Count();
            int countMan = (from a in viewers where a != null&& a.Sex.Contains("Man") select a.Age).Count();
            int countWoman = (from a in viewers where a != null&& a.Sex=="Woman" select a.Age).Count();
            int avgMan = (int)(from a in viewers where a != null && a.Sex == "Man" select a.Age).Average();
            int avgWoman = (int)(from a in viewers where a != null && a.Sex == "Woman" select a.Age).Average();
            Console.WriteLine($"Средний возраст зрителя = {avg}\nКоличество зрителей  = {count}\n" +
                $"Количество мущин  = {countMan}\nКоличество женщин = {countWoman}\n" +
                $"Средний возразс мущин ={avgMan}\nСредний возраст женщин ={avgWoman}");

        }
        //этот интерфейс реализовывает итерацию по классу(по екземпляру класса)
        public IEnumerator GetEnumerator()
        {
            return viewers.GetEnumerator();
        }

        public void ShowViewers()
        {
            foreach(var v in viewers)
            {
                if (v == null)
                    Console.WriteLine("Null");
                else
                    v.Display();
            }
        }
    }
}
