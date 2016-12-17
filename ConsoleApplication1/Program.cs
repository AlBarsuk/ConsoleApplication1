using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        public static int?[][] mass { get; set; }
        public static Random r { get; set; }
        static void Main(string[] args)
        {
            Creator c = Creator.GetInstance();
            int?[][] mass = null;
            mass = c.Create();
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    if (j == 3 || j == 6)
                    {
                        Console.Write(" || ");
                    }
                    Console.Write(mass[i][j] + " ");
                }
                if (i == 2 || i == 5)
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }       
    }
 
}
