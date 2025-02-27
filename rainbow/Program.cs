using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainbow
{
    public class reo 
    {
        public double vectores(double x1, double y2, double x2, double y1)
        {
            return x1 - y2 + x2 - y1;
                
        }
    
    }
    public class reo2
    {
        public double vectores(double x1, double x2, double x3)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2)+ Math.Pow(x3, 2));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            reo operacion1 = new reo();
            reo2 operacion2 = new reo2();
            Console.WriteLine("usar poliformismo con vectores de 2 y 3 dimensiones");
            Console.WriteLine("operacion 1");
            Console.WriteLine(operacion1.vectores(12.2, 15.2, 12.3, 12.9));
            Console.WriteLine("operacion 2");
            Console.WriteLine(operacion2.vectores(15.12, 15.6, 15.2));
            Console.ReadLine();
           
        }
    }
}
