using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class RunningTotalTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void RunningTotalTestSimple()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            int[] output = RunningTotal.runTotal(input);
            int[] expected = { 1, 3, 6, 10, 15, 21};

            // run the following to ensure test fails when it should 
           //  int[] expected = { 5, 3, 6, 10, 15, 21 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
