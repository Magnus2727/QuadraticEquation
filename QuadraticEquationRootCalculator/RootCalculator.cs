using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquationRootCalculator
{
    public class RootCalculator
    {
        public List<double> Roots { get; private set; }
        public double Delta { get; private set; }
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public RootCalculator(double a, double b, double c)
        {
            this.Delta = double.NaN;
            this.A = a;
            this.B = b;
            this.C = c;
            this.Roots = new List<double>();
        }

        public void RootCalculate()
        {

            if (A == 0)
            {
                throw new Exception("Function is linear, no roots");
            }
            
            CalculateDelta();
            double divider = 2 * A;

            if (Delta > 0)
            {
                Roots.Add((-B / divider) + (Math.Sqrt(Delta) / divider));
                Roots.Add((-B / divider) - (Math.Sqrt(Delta) / divider));
                return;
            }

            if (Delta == 0)
            {
                Roots.Add(-B / divider);
                return;
            }

        }
        private void CalculateDelta()
        {
            Delta = Math.Pow(B, 2) - (4 * A * C);
        }

        public override string ToString()
        {
            if (Roots.Count == 2)
                return $"Equation has two roots: {Roots[0]},{Roots[1]}";

            else if (Roots.Count == 1)
                return $"Equation has one root: {Roots[0]}";

            else if (Delta.Equals(double.NaN))
                return "Roots were not calculated yet";
            else
                return "Equation has 0 roots in real domain";
        }
        
    }
}
