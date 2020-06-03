using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Glava10
    {//Делегаты
        public delegate int Binary(int x, int y);

        public static void DelegateInfo(Delegate obj_delegt)
        {
            foreach(Delegate d in obj_delegt.GetInvocationList())
            {
                Console.WriteLine("Metod name :{0}", d.Method);
                Console.WriteLine("Type name :{0}", d.Target);

            }
        }
        public class SimpleMath
        {
            public static int Add(int x, int y) => x + y;
            public static int Minys(int x, int y)
            {
                return x - y;
            }
        }
        //применения делегатов для обратных вызовов в приложениях

        public class Car
        {
            public int CurrentSpeed { get; set; }
            public int MaxSpeed { get; set; }
            public string PetName { get; set; }

            private bool carIsDead;

            public Car() { }
            public Car(int speed, int mspeed, string name) 
            {
                CurrentSpeed = speed;
                MaxSpeed = mspeed;
                PetName = name;
            }
            public delegate void CarEngineHandler(string msgForCaller);
            private CarEngineHandler listOfHandlers;
            public void RegisterWithCarEngine(CarEngineHandler methodToCall)
            {
                listOfHandlers += methodToCall;
            }
            public void Accelerate(int delta)
            {
                if(carIsDead)
                {
                    if(listOfHandlers != null)
                        listOfHandlers("Sorry, this car is dead...");
                    
                }
                else
                {
                    CurrentSpeed += delta;
                    if (10 == (MaxSpeed-CurrentSpeed)&&listOfHandlers != null)
                        listOfHandlers("Careful buddy! Gonna blow!");
                    if (CurrentSpeed >= MaxSpeed)
                        carIsDead = true;
                    else
                        Console.WriteLine("Current speed = {0}", CurrentSpeed);
                }
            }
        }

        //Использование специальных обобщенных делегатов Action i Func 

        public static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Установить цвет текста консоли.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            // Восстановить цвет.
            Console.ForegroundColor = previous;
        }
        public static int Metod_func(int x, int y)
        {
            return x + y;
        }

        //События - упрощають использования делегатов для обратного вызова, а именно заменяют регистрацию и список функций для которые используються делегатом
        public class Car2
        {
            public int CurrentSpeed2 { get; set; }
            public int MaxSpeed2 { get; set; }
            public string PetName2 { get; set; }

            private bool carIsDead2;

            public Car2() { }
            public Car2(int speed, int mspeed, string name)
            {
                CurrentSpeed2 = speed;
                MaxSpeed2 = mspeed;
                PetName2 = name;
            }

            public delegate void CarEngineYandler(string msg);
            public event CarEngineYandler Exploed;
            public event CarEngineYandler AboutToBlow;

            public void Accelerate2(int delta)
            {
                if (carIsDead2)
                {
                    // чтобы не писать проверку на null можно воспользоваться таким форматом:
                    Exploed?.Invoke("Soore the car is blow");
                }
                else
                {
                    CurrentSpeed2 += delta;
                    if (10 == (MaxSpeed2 - CurrentSpeed2) && AboutToBlow != null)
                        AboutToBlow("Careful buddy! Gonna blow!");
                    if (CurrentSpeed2 >= MaxSpeed2)
                        carIsDead2 = true;
                    else
                        Console.WriteLine("Current speed = {0}", CurrentSpeed2);
                }
            }
        }
    }
}
