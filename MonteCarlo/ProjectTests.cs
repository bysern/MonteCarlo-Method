﻿using System;
using NUnit.Framework;

namespace MonteCarlo
{
    [TestFixture]

    class ProjectTests
    {
        [Test]
        public void Test1()
        {
            //InputTask menu = new InputTask();
            //string Input = "10,20,30";
            //Assert.That(menu.setArray(Input), Is.EqualTo("10", "20", "30"))); 
            MonteCarloOperations operations = new MonteCarloOperations();
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