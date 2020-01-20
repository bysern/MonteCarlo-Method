using System;
using System.Linq;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter tasks in the following order: best,average,worst case scenerios " +
                              "\nType END to finish entering tasks.");
            try
            {
                MonteCarloOperations operations = new MonteCarloOperations();
                int NumberOfTasks = 1;
                while (true)
                {
                    Console.Write($"Task #{NumberOfTasks}: ");
                    string InputTask = Console.ReadLine();

                    if (InputTask.ToLower() == "end") break;
                    else NumberOfTasks++;

                    operations.AddTask(new InputTask(InputTask));
                }
                int[] EstimatedNumbers = operations.CalculateEstimated();
                int minimum = EstimatedNumbers[0], maximum = EstimatedNumbers[2];

                Bucketing bucket = operations.Simulate();

                Console.WriteLine("After probing 10000 randoms plans, the results are: ");
                Console.WriteLine($"Minimum = {minimum} days");
                Console.WriteLine($"Average = {operations.AverageEstimation} days");
                Console.WriteLine($"Maximum = {maximum} days");

                Console.WriteLine("Probability in finishing the plan in: \n" + bucket);

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "Try again");
            }
        }
    }
}
