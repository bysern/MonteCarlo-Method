using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Bucketing
    {
        public int bucketCount { get; set; }
        public int rangeLow { get; set; }
        public int rangeHigh { get; set; }
        public double StepSize { get; set; }
        public double[] buckets { get; set; }

        public Bucketing(int newBucketCount, int newRangeLow, int newRangeHigh)
        {
            this.bucketCount = newBucketCount;
            this.rangeLow = newRangeLow;
            this.rangeHigh = newRangeHigh;
            this.StepSize = (Math.Abs(rangeLow + Math.Abs(rangeHigh)) / bucketCount);
        }

        public void initBuckets()
        {
            for (int i = 0; i < this.bucketCount; i++)
            {
                //this.buckets[i] = [];
            }
        }

        public void addValueToBucket(int value)
        {

        }


    }
}
