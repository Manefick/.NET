using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {   //состояние обекта кар
        public string carName;
        public int speedValue;

        //Стандартный конструктор задающий начальные значения
        public Car()
        {
            carName = "BMW";
            speedValue = 0;
        }
        // Перегрузка конструкторов, конструктор который требует задать состояние обьекта во время инициализации
        public Car(string carName, int cSpeed = 50)
        {
            //использование указателя this
            this.carName = carName;
            if (cSpeed > 100)
            {
                Console.WriteLine("Сбавте скорость возможна авария!!!");
            }
            speedValue = cSpeed;
        }
        // функциональность кар (методы класа)
        public void PrintInfoCar()
        {
            Console.WriteLine("{0} drive with speed {1}km/h", carName, speedValue);
        }
        public void SpeedUp(int i)
        {
            speedValue += i;
        }

    }

    class Employee
    {
        // Поля данных,
        private string empName;
        private int empID;
        private float currPay;

        public Employee() { }
        //Использование свойств для установки значений в конструкторе класа
        public Employee(string name, int id, float pay)
        {
            Name = name;
            Id = id;
            Pay = pay;
        }

        // Свойства. Используем свойтва вместо названий полей даных
        // в конструкторе и методах для сохранения логики описаной в свойствах
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }
        public int Id
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        // Metodu
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public void Print()
        {
            Console.WriteLine("Name: {0}", Name); // имя сотрудника
            Console.WriteLine("ID: {0}", Id); // идентификационный номер сотрудника
            Console.WriteLine("Pay: {0}", Pay); // текущая выплата
        }
    }
    class Prop
    {
        // автоматические свойства
        public string PetName { get; set;}
        public int Speed { get; set; } = 1;
        public string Color { get; set; }
        public Employee MyCar { get; set; } = new Employee();
    }

    //Наследование 
    abstract class Avtomobil//абстракный клас не может создавать свои екземплярыб он служит как набор общих свойст и методов для
        //дочерних класов
    {
        public readonly int maxSpeed;
        private int currSpeed;
        protected int count;

        public Avtomobil(int max, int s, int c)
        {
            maxSpeed = max;
            Speed = s;
            count = c;
        }
        public Avtomobil()
        {
            maxSpeed = 55;
        }
        protected int Count// закрыт доступ из вне, свойство доступно только класу и его наследникам
        {
            get { return count; }
            set { count = value; }
        }
        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (value > maxSpeed)
                    currSpeed = maxSpeed;
            }
        }
        public abstract void Transmishion(string avtomat_or_mehanik);// абстракный метод , заставляет реализовать себя в дочерних классах
        public virtual void Display()//метод что можно преопределить в дочернем классе
        {
            Console.WriteLine("avto run with speed {0}, when max speed ={1}," +
                " число передач = {2}", Speed, maxSpeed, count);

        }


    }
    class Motor
    {
        public double obem { get; set; }
    }

    class Mersedes : Avtomobil
    {
        protected Motor moti = new Motor();// делегат наследование типа имеет
        public string model;
        public Mersedes(int mspd, int spd, int count, string m, double mm = 3.2 ) : base(mspd, spd, count)//конструктор базового класа
        {
            model = m;
            moti.obem = mm;
        }
        public override void Transmishion(string k)//реализация абстрактного метода
        {
            Console.WriteLine(k);
        }
        public override void Display()// преопределение метода базового класса
        {
            base.Display();
            Console.WriteLine($"model  = {model}, volum of motor ={moti.obem}");
        }
    }


}

