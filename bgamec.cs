using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bgamec
{
    class Program
    {
        static void Main(string[] args)
        {

                


        }

        public static void WaitOnMove()
        {
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                if ((keyinfo.Key == ConsoleKey.UpArrow) || (keyinfo.Key == ConsoleKey.DownArrow) || (keyinfo.Key == ConsoleKey.LeftArrow) || (keyinfo.Key == ConsoleKey.RightArrow))
                {

                }

            }

            while (keyinfo.Key != ConsoleKey.X);    
        }
    }
}
