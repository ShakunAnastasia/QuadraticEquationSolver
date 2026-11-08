using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    internal class EquationResult
    {
        public int RootsCount { get; private set; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }

        // Коли коренів немає (D < 0)
        public EquationResult()
        {
            RootsCount = 0;
        }

        // Коли є лише один корінь (D = 0)
        public EquationResult(double x)
        {
            RootsCount = 1;
            X1 = x;
        }

        // Коли є два корені (D > 0)
        public EquationResult(double x1, double x2)
        {
            RootsCount = 2;
            X1 = x1;
            X2 = x2;
        }
    }
}
