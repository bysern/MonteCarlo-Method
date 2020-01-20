﻿using System;
using System.Collections.Generic;

namespace MonteCarlo
{
    class MonteCarloOperations
    {
        public List<InputTask> Tasks = new List<InputTask>();
        public int AverageEstimation { get; private set; }

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
            if (max < min) throw new InvalidOperationException("Worst case scenerio must be longer than best");

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

        //Monte carlo algorithm, more iterations more accurate estimation with costs of performance
        public Bucketing Simulate()
        {
            int totalCostOfRandomPlans = 0;
            int iterations = 10000;
            int[] Estimation = CalculateEstimated();
            int min = Estimation[0], max = Estimation[2];
            //int HowManyBuckets = max - min;
            Bucketing bucket = new Bucketing(10, min, max);

            var randomEstimations = GenerateRandomArray(min, max);
            for (int i = 0; i < iterations; i++)
            {
                int randomPlanCost = 0;

                randomPlanCost += randomEstimations[i];
            
                bucket.addValueToBucket(randomPlanCost);

               totalCostOfRandomPlans += randomPlanCost;
            }
            this.AverageEstimation = totalCostOfRandomPlans / (iterations);

            return bucket;
        }
    }
}
