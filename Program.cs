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
            Show(args);
            newMetod();

            Console.ReadLine();

            return -1;
        }

        static void Show(string[] args)
        {
            foreach (string a in args)
                Console.WriteLine("pi:{0}", a);

            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("drive: {0}", drive);
            Console.WriteLine(Environment.SystemDirectory);
            Console.Beep();
     
        }

        static void newMetod()
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();
            Console.WriteLine("Name: {0}", name);
        }
    }

    class New
    {
        static void Main1()
        {
            Console.WriteLine("hfgdkg");
        }
    }
   
}
