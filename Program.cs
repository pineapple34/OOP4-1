using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Health health = new Health();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Температура - " + health.Temperature);
                Console.WriteLine("Новое значение - ");
                int.TryParse(Console.ReadLine(), out int newTemp);
                health.Temperature = newTemp;
            }
        }
    }

    class Health
    {
        private int temperature;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= 34 && value <= 41) temperature = value;
            }
        }
        public Health()
        {
            this.temperature = 36;
        }
    }
}
