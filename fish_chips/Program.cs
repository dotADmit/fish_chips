using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_chips
{
    class Program
    {
        static void Main(string[] args)
        {
            Display test = new Display(10, 49);

            DisplaySettings t = new DisplaySettings();
            t.GetMainSettings();


            Console.ReadKey();
            
        }
    }
}
