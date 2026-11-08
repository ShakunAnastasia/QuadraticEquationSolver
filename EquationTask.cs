using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    internal class EquationTask
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public EquationTask(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
