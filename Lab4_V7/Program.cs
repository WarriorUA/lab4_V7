using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Vec vec1= new Vec();
            Vec vec2 = new Vec();
            string res = "y";
            while (res == "y")
            {
                Console.WriteLine("vvedite novii element vec1:");
                vec1.list.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine("Continue?(y/n)");

                res = Console.ReadLine();
            }
            res = "y";
            while (res == "y")
            {
                Console.WriteLine("vvedite novii element vec2:");
                vec2.list.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine("Continue?(y/n)");

                res = Console.ReadLine();
            }
            Console.WriteLine(vec1*vec2);
            Console.ReadKey();
        }
    }

    class Vec
    {
         public List<double> list = new List<double>();
        public static double operator *(Vec v1,Vec v2)
        {
            double rez = 1;
            foreach (var t in v1.list)
            {
                if (t < 0) rez *= t;
            }
            foreach (var t in v2.list)
            {
                if (t < 0) rez *= t;
            }
            return rez;
        }
    }
}
