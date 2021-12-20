using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_20_2
{
    class Program
    {
        delegate double MyDelegate(double r);


        static void Main(string[] args)
        {
            MyDelegate myDelegate = Cirqumference;
            myDelegate(3);
            Console.ReadKey();


        }
        static double Cirqumference(double r)
        {
            double d = 2 * Math.PI * r;
            Console.WriteLine(d);
            return d;
        }
        static double CircleArea(double r)
        {
            double s = Math.PI * Math.Pow(r, 2);
            return s;
        }
        static double VolumSphere(double r)
        {
            double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            return v;
        }
    }
}
