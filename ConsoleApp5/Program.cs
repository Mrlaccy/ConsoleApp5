using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader strr = new StreamReader("auto.csv"))
            {
                String line = strr.ReadToEnd();
                Console.WriteLine(line);
            }
           
            
            Console.ReadKey();
        }
    }
}
