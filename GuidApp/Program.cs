using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidApp
{
    class Program
    {
        static int Main(string[] args)
        {
         for (int i = 0; i<=10; i++)
            {
            Guid obj = Guid.NewGuid();
            Console.WriteLine("New Guid is " + obj.ToString());
            }
            Console.ReadLine();
           return -1;
        }
    }
}