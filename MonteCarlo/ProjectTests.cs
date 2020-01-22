using System;
using NUnit.Framework;

namespace MonteCarlo
{
    [TestFixture]

    class ProjectTests
    {
        [Test]
        public void TestBucket()
        {
            MonteCarloOperations operations = new MonteCarloOperations();
            int[] Estimation = operations.CalculateEstimated();
            int min = Estimation[0], max = Estimation[2];
            var bucket = new Bucketing(10, 40, 160);
            //Assert.That(operations.Simulate)

        }

    }
}
