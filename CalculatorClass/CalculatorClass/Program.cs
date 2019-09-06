using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class calculations
    {
        public double Divide(double value1, double value2)
        {
            double result = value1 / value2;
            return result;
        }

        public double Multiply(double value1, double value2)
        {
            double result = value1 * value2;
            return result;
        }

        public double Add(double value1, double value2)
        {
            double result = value1 + value2;
            return result;
        }

        public double Subtract(double value1, double value2)
        {
            double result = value1 - value2;
            return result;
        }


    }
}
