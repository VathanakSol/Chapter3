using System;
namespace Chapter3
{
    class Program
    {
        static void Main(String[] args)
        {
            double tax, salary, bonus;
            int spouse, children;
            Console.Write("Enter Salary: "); salary = double.Parse(Console.ReadLine());
            Console.Write("Enter Bonus: "); bonus = double.Parse(Console.ReadLine());
            Console.Write("Enter Spouse: "); spouse = int.Parse(Console.ReadLine());
            Console.Write("Enter Children: "); children = int.Parse(Console.ReadLine());

            if (salary >= 0)
            {
                if (spouse >= 1)
                {
                    spouse = 1;
                }
                else
                {
                    spouse = 0;
                }
                if (children >= 9)
                {
                    children = 9;
                }
                double family = 150000 * (spouse + children);
                tax = salary - family;

                if (salary <= 1200000)
                {
                    tax = 0;
                }

                else if (salary <= 2000000)
                {
                    tax = salary * 0.05 - 60000;
                }
                else if (salary <= 8500000)
                {
                    tax = salary * 0.1 - 160000;
                }
                else if (salary <= 12500000)
                {
                    tax = salary * 0.15 - 585000;
                }
                else
                    tax = salary * 0.2 - 1210000;
                double lastsalary;
                tax = tax + (bonus * 0.2);
                lastsalary = salary - tax;
                Console.WriteLine("==========================================");
                
                Console.WriteLine($"Tax: {tax:#,##0.00 R}");
                Console.WriteLine($"Total Salary: {lastsalary:#,##0.## R}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}
