using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime teraz = DateTime.Now;

            Console.WriteLine(teraz.Day.ToString().PadLeft(2, '0') + teraz.Month.ToString().PadLeft(2, '0') + teraz.Year.ToString().PadLeft(4, '0') + teraz.Hour.ToString().PadLeft(2, '0') + teraz.Minute.ToString().PadLeft(2, '0') + teraz.Second.ToString().PadLeft(2, '0'));

            Console.ReadKey();
        }
    }
}
