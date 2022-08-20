using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m1 = 800;
            Console.WriteLine("Meter   ::    Kilometer");
            double k1 = ConvertDistance.cMtK(m1);
            Console.WriteLine("{0}     ::    {1}", m1, k1);
            double m4 = 5237;
            double k4 = ConvertDistance.cMtK(m4);
            Console.WriteLine("{0}   ::     {1}", m4, k4);
            double k3 = 7.2;
            Console.WriteLine();
            Console.WriteLine("Kilometer     ::     Meter");
            double m3 = ConvertDistance.cKtM(k3);
            Console.WriteLine("{0}           ::     {1}", k3, m3);
            double k2 = 2.471;
            double m2 = ConvertDistance.cKtM(k2);
            Console.WriteLine("{0}         ::    {1}", k2, m2);
            Console.Read();
        }
    }

    public static class ConvertDistance
    {
        public static double cMtK(double meters)
        {
            return meters / 1000;
        }

        public static double cKtM(double kilometers)
        {
            return kilometers * 1000;
            Console.ReadLine();
        }
    }
}
