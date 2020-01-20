using System;
using System.Collections.Generic;
using System.Linq;

namespace MonteCarlo
{
    class InputTask
    {
        public int BestTestCase { get; set; }
        public int AvgTestCase { get; set; }
        public int WorstTestCase { get; set; }
        public int[] Tasks { get; set; }
        
        public InputTask(string Input)
        {
            setArray(Input);
        }


        public void setArray(string Input)
        {
            Input = Input.Trim();
            string[] Estimations = Input.Split(',');

            if (Estimations.Length < 2) throw new InvalidOperationException("You must declare worst,average,best case scenerios. Separated with ,");

            this.Tasks = new int[Estimations.Length];

            for (int i = 0; i < Estimations.Length; i++)
            {
               if (!int.TryParse(Estimations[i], out Tasks[i])) Console.WriteLine("Wrong input");

            }
            this.BestTestCase = Tasks.Min();
            this.AvgTestCase = (int)Tasks.Average();
            this.WorstTestCase = Tasks.Max();
        }
    }
}
