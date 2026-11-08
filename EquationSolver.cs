using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    internal class EquationSolver
    {
        private double CalculateDiscriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }

        public EquationResult Solve(EquationTask task)
        {
            double a = task.A;
            double b = task.B;
            double c = task.C;

            double d = CalculateDiscriminant(a, b, c);

            if (d < 0)
            {
                return new EquationResult();
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return new EquationResult(x);
            }
            else
            {
                double sqrtD = Math.Sqrt(d);
                double x1 = (-b - sqrtD) / (2 * a);
                double x2 = (-b + sqrtD) / (2 * a);

                return new EquationResult(x1, x2);
            }
        }
    }
}