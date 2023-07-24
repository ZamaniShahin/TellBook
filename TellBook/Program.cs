using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TellBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.Add");
            WriteLine("2.Update");
            WriteLine("3.Delete");
            WriteLine("4.Search By Name");
            WriteLine("5.Search By LastName");
            WriteLine("6.Exit");
            WriteLine("-------------------------");
            Write("Please Choose An Option:");
            string option = ReadLine();
            while (true)
            {
                switch (int.Parse(option))
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    default:
                        WriteLine("Please Choose A Number Between 1 to 6.");
                        break;
                }
            }
        }
    }
}
