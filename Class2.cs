using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        public static void Public()
        {
            Console.WriteLine("public");

        }
        protected static void Protected()
        {
            Console.WriteLine("protected");

        }
        internal static void Internal()
        {
            Console.WriteLine("internal");
 
        }
        private static void Private()
        {
            Console.WriteLine("private");
        }
    }

}