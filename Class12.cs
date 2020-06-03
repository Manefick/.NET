using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class12
    {
    }
    public class Viewer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }

        public Viewer() { }
        public Viewer(string name,string surname,char sex,int age)
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
        private List<Viewer> viewers = new List<Viewer>();
        Random random = new Random();
        enum Name
        {
            Sasha,
            Inna,
            Petya,
            Vasya,
            Slavik
        }

        public Cinema()
        {
            for(int i = 0; i<30;i++)
            {
                int k = random.Next(0, 3);
                if (k == 0)
                    viewers.Add(null);
                else
                    viewers.Add(new Viewer("Sasha", "Hrynchuk", 'M', random.Next(15, 60)));
            }
        }
        public IEnumerator GetEnumerator()
        {
            return viewers.GetEnumerator();
        }

    }
}
