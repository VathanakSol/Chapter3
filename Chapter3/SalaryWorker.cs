using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class SalaryWorker
    {
        static void Mainx(string[] args)
        {
            double time1, time2, totalTime, basicSalary = 50.00, bonusSalary, totalSalary, bonusRate1, bonusRate2;
            Console.Write("Enter Total Time = "); totalTime = double.Parse(Console.ReadLine());
            if(totalTime >= 100 && totalTime <= 120)
            {
                time1 = totalTime - 100;
                //time2 = totalTime - 120;
                Console.WriteLine($"Extra Time 1 = {time1}");
                Console.WriteLine("Extra Time 2 = 0");
                Console.WriteLine("Bonus Rate 1 =  $1.25/h");
                Console.WriteLine("Bonus Rate 2 =  $1.50/h");
                bonusSalary = (time1 * 1.25);
                Console.WriteLine("Basic Salary =  $50.00");
                Console.WriteLine($"Bonus salary = {bonusSalary}");
                Console.WriteLine("===============================");
                totalSalary = basicSalary + bonusSalary;
                Console.WriteLine($"Total Salary = {totalSalary:c2}");

            }
            else if(totalTime > 120)
            {
                //time1 = totalTime - 100;
                time2 = totalTime - 120;
                Console.WriteLine("Extra Time 1 = 0");
                Console.WriteLine($"Extra Time 2 = {time2}");
                Console.WriteLine("Bonus Rate 1 =  $1.25/h");
                Console.WriteLine("Bonus Rate 2 =  $1.50/h");
                bonusSalary = (time2 * 1.50);
                Console.WriteLine("Basic Salary =  $50.00");
                Console.WriteLine($"Bonus salary = {bonusSalary}");
                Console.WriteLine("===============================");
                totalSalary = basicSalary + bonusSalary;
                Console.WriteLine($"Total Salary = {totalSalary:c2}");

            }
            if(totalTime < 100 && totalTime > 0)
            {

                double time3 = 100 - totalTime;
                bonusSalary = (totalTime * 0.50);
                Console.WriteLine($"Your total Salary = {bonusSalary:c2}");
            }
            if(totalTime < 0)
            {
                Console.WriteLine("Invalid ");
            }

            Console.ReadKey();
        }
    }
}
