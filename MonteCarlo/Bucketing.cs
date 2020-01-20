using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    class Bucketing
    {
        public Dictionary<int, int> buckets = new Dictionary<int, int>();
        public int bucketCount { get; set; }
        public int rangeLow { get; set; }
        public int rangeHigh { get; set; }
        public int StepSize { get; set; }

        public Bucketing(int newBucketCount, int newRangeLow, int newRangeHigh)
        {
            this.bucketCount = newBucketCount;
            this.rangeLow = newRangeLow;
            this.rangeHigh = newRangeHigh;
            this.StepSize = (Math.Abs(rangeHigh - Math.Abs(rangeLow)) / bucketCount);

            initBuckets();
        }

        public void initBuckets()
        {
            for (int i = 0; i < this.bucketCount; i++)
            {
                this.buckets.Add(this.rangeLow+(this.StepSize*i), 0);
            }
        }

        public void addValueToBucket(int val)
        {
            int idx = this.getBucketIdxForValue(val);
            this.buckets[this.buckets.ElementAt(idx).Key]++;
        }

        public int getBucketIdxForValue(int val)
        {
            int idx = 0;

            // Find bucket, put values on the outer size of the range in the last bucket
            while ((idx < this.bucketCount - 1) && val > this.rangeLow + this.StepSize * (idx + 1))
            {
                idx++;
            }
            return idx;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (KeyValuePair<int,int> keyValue in this.buckets)
            {
                result += $"{keyValue.Key} days: {keyValue.Value / 100}%\n";   // value divided by number of iteration * 100 %
            }

            return result;
        }

    }
}
