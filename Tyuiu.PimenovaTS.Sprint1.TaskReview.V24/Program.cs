using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint1.TaskReview.V24.Lib;

namespace Tyuiu.PimenovaTS.Sprint1.TaskReview.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
