using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string Shape_Name)
        {
            Name = Shape_Name;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Draw {0}",Name);
        }
    }

    class Triangle: Shape, IPoint
    {
        public int Katet { get; }

        public Triangle(string n, int k) : base(n)
        {
            Katet = k;
        }
        public int Points { get; } = 3;
    }
    class Square: Shape, IPoint
    {
        public Square(string name): base(name) { }
        public override void Draw()
        {
            Console.WriteLine("You draw Square named {0}", Name);
        }
        int IPoint.Points// явная реализация интерфейса
        {
            get { return 4; }
        }
    }
    class Circle: Shape
    {
        public int Radius { get; set; }
        public Circle(string name, int radius): base(name)
        {
            Radius = radius;
        }
    }

    public interface IPoint
    {
        int Points { get; }
    }

    //ИТЕРАТОРЫ, ИСПОЛЬЗОВАНИЕ ИНТЕРФЕЙСОВ ИТЕРАТОРОВ

    class One
    {
        public int O;
        public int N;
        public int E;

        public One() { }
        public One(int o, int n, int e)
        {
            O = o;
            N = n;
            E = e;
        }
        public void Summa()
        {
            Console.WriteLine(O + N + E);
        }
    }

    class Two
    {
        public int T;
        public int W;
        public int O;

        public Two() { }
        public Two(int t, int w, int o)
        {
            T = t;
            W = w;
            O = o;
        }
        public void Summa()
        {
            Console.WriteLine(T+W+O);
        }
    }
    //подключаем итерационный интерфейс б что бы сделать екземпляр списка класов итерабильным 
    class Number: IEnumerable
    {
        private One[] Arr_ones = new One[3];
        public Number()
        {
            Arr_ones[0] = new One(1, 2, 3);
            Arr_ones[1] = new One(4, 5, 6);
            Arr_ones[2] = new One(7, 8, 9);
        }
        public IEnumerator GetEnumerator()
        {
            return Arr_ones.GetEnumerator();
        }
    }
}
