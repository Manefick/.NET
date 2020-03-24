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
        public Car(string carName, int cSpeed=50)
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
            Console.WriteLine("{0} drive with speed {1}km/h",carName, speedValue);
        }
        public void SpeedUp(int i)
        {
            speedValue += i;
        }
         
    }
}
