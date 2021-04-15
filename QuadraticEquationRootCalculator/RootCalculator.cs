using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquationRootCalculator
{
    public class RootCalculator
    {
        public double Root1 { get; private set; }
        public double Root2 { get; private set; }
        public double Delta { get; private set; }
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public RootCalculator(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void RootCalculate()
        {

            if (A == 0)
            {
                Console.WriteLine("function is linear, no roots");
                return;
            }

            CalculateDelta();
            double divider = 2 * A;

            if (Delta > 0)
            {
                Root1 = (-B / divider) + (Math.Sqrt(Delta) / divider);
                Root2 = (-B / divider) - (Math.Sqrt(Delta) / divider);
                Console.WriteLine($"function with two roots: {Root1}, {Root2}");
                return;
            }

            if (Delta == 0)
            {
                Root1 = -B / divider;
                Root2 = Root1;
                Console.WriteLine($"function with one root: {Root1}");
                return;
            }

            if (Delta < 0)
            {
                Console.WriteLine("Equation without real roots");
            }

        }
        private void CalculateDelta()
        {
            Delta = Math.Pow(B, 2) - (4 * A * C);
        }
    }
}
