using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotName
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot();
            r1.Describe();
            r1.FactoryReset();
            r1.Describe();
            Console.ReadLine();
        }
    }
}
