using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotName
{
    class Robot
    {
        private string _name;
        Random random = new Random();

        public Robot()
        {
            NameGenerator();
        }

        private void NameGenerator()
        {
            
            string something = "QWERTYUIOPASDFGHJKLZXCVBNM";

            _name = $"{something[random.Next(0, something.Length)].ToString()}{something[random.Next(0, something.Length)].ToString()}" +
                $"{random.Next(0,9).ToString()}{random.Next(0, 9).ToString()}{random.Next(0, 9).ToString()}";

        }

        public void FactoryReset()
        {
            NameGenerator();
        }


        public void Describe()
        {
            Console.WriteLine($"Hi my name is {_name}");
        }
    }
}
