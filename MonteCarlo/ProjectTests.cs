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

        [Test]
        public void TestTaskInititalization()
        {
            //string Input = "10 20 30";
            //InputTask menu = new InputTask();
            //Assert.That(menu.BestTestCase, Is.EqualTo(10));
            //Assert.That(menu.AvgTestCase, Is.EqualTo(20));
            //Assert.That(menu.WorstTestCase, Is.EqualTo(30));
        }

    }
}
