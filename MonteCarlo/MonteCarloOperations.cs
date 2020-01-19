﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class MonteCarloOperations
    {
        public List<InputTask> Tasks = new List<InputTask>();


        public void AddTask(InputTask task)
        {
            Tasks.Add(task);
        }

        public int[] CalculateEstimated()
        {
            int min = 0, avg = 0, max = 0;

            foreach (InputTask task in Tasks)
            {
                min += task.BestTestCase;
                avg += task.AvgTestCase;
                max += task.WorstTestCase;
            }
            int[] TimeCases = new int[] { min, avg, max };
            return TimeCases;
        }



        public static int[] GenerateRandomArray(int min, int max)
        {
            int[] randomArray = new int[10000];

            Random randNum = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randNum.Next(min, max);
            }
            return randomArray;
        }

        public int Simulate()
        {
            int totalCostOfRandomPlans = 0;
            int iterations = 10000;
            int[] Estimation = CalculateEstimated();
            int min = Estimation[0], max = Estimation[2];
            var randomEstimations = GenerateRandomArray(min, max);
            for (int i = 0; i < iterations; i++)
            {
                int randomPlanCost = 0;
                //foreach (var item in Tasks)
                //{
                    randomPlanCost += randomEstimations[i];
                //}
                totalCostOfRandomPlans += randomPlanCost;
            }
            return totalCostOfRandomPlans / (iterations);
        }
    }
}
