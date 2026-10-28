using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2student
{
    internal class Student
    {
        public string? Name;
        public double MathScore;
        public double physicsScore;
        public double prg_lang;

        public void Math()
        {
            Console.Write($"score of mathematics {Name} : ");
            string? user = Console.ReadLine();
            double result;
            if (double.TryParse(user,out result) && result >0 && result<=20)
            {
                MathScore = result;
            }
            else
            {
                Console.WriteLine("==wrong==");
                Math();
            }
        }
        public void phyisc()
        {
            Console.Write($"score of physic {Name} : ");
            string? user = Console.ReadLine();
            double result;
            if (double.TryParse(user, out result) && result > 0 && result <= 20)
            {
               physicsScore = result;
            }
            else
            {
                Console.WriteLine("==wrong==");
                phyisc();
            }
        }
        public void prg()
        {
            Console.Write($"score of prg_lang {Name} : ");
            string? user = Console.ReadLine();
            double result;
            if (double.TryParse(user, out result) && result > 0 && result <= 20)
            {
                prg_lang = result;
            }
            else
            {
                Console.WriteLine("==wrong==");
                prg();
            }
        }
        public double average()
        {
            return (MathScore + physicsScore + prg_lang) / 3;
        }
    }
}
