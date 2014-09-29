using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindIndexOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Hello null World";

            int start = 0, lPosition = 0, oPosition = 0;

            Console.Write("'L' Position is : ");

            while (start < Name.Length) {

                lPosition = Name.IndexOf('l', start);
                if (lPosition == -1)
                    break;
                start = lPosition + 1;
                Console.Write(lPosition + " ");
            }

            Console.WriteLine(string.Empty);
            start = 0;
            Console.Write("'O' Position is : ");

            while (start < Name.Length)
            {

                oPosition = Name.IndexOf('o', start);
                if (oPosition == -1)
                    break;
                start = oPosition + 1;
                Console.Write(oPosition + " ");
            }

            Console.ReadKey();
        }
    }
}
