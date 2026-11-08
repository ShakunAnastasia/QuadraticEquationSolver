using System;

namespace QuadraticEquationSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Програма: Розв'язання квадратного рівняння");
            Console.WriteLine("Формула: a*x^2 + b*x + c = 0\n");

            Console.Write("Введіть коефіцієнт a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("\nПомилка: коефіцієнт 'a' не може бути рівним 0, оскільки рівняння перестає бути квадратним!");
                return;
            }

            Console.Write("Введіть коефіцієнт b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть коефіцієнт c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            EquationTask task = new EquationTask(a, b, c);

            EquationSolver solver = new EquationSolver();
            EquationResult result = solver.Solve(task);

            Console.WriteLine("\nРезультат обчислення");
            if (result.RootsCount == 0)
            {
                Console.WriteLine("Дискримінант D < 0. Рівняння не має дійсних коренів.");
            }
            else if (result.RootsCount == 1)
            {
                Console.WriteLine($"Дискримінант D = 0. Рівняння має один корінь: x = {result.X1}");
            }
            else
            {
                Console.WriteLine("Дискримінант D > 0. Рівняння має два корені:");
                Console.WriteLine($"x1 = {result.X1}");
                Console.WriteLine($"x2 = {result.X2}");
            }
        }
    }
}