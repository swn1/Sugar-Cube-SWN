using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SugarCubeSWN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace SugarCubeSWN.Tests
{
    [TestClass()]
    public class DescriptivesTests
    {
        [TestMethod()]
        public void MassTest()
        {
            var s = new Descriptives();
            Assert.AreEqual(s.Mass(),0);
            s.AddSample(1,0);
            Assert.AreEqual(s.Mass(),0);
            s.AddSample(1);
            Assert.AreEqual(s.Mass(),1);
            s.AddSample(1,9);
            Assert.AreEqual(s.Mass(),10);
        }

        [TestMethod()]
        public void MinMaxTest()
        {
            var s = new Descriptives();
            s.AddSample(1);
            Assert.AreEqual(s.Min(), 1);
            Assert.AreEqual(s.Max(), 1);
            s.AddSample(0);
            Assert.AreEqual(s.Min(), 0);
            Assert.AreEqual(s.Max(), 1);
            s.AddSample(2);
            Assert.AreEqual(s.Min(), 0);
            Assert.AreEqual(s.Max(), 2);
        }

        [TestMethod()]
        public void MeanTest()
        {
            var s = new Descriptives();
            Assert.IsTrue(Double.IsNaN(s.Mean()));
            s.AddSample(1);
            Assert.AreEqual(s.Mean(), 1);
            s.AddSample(2);
            Assert.IsTrue(System.Math.Abs(s.Mean() - 1.5) < 1e-12);
            s.AddSample(3);
            Assert.IsTrue(System.Math.Abs(s.Mean() - 2) < 1e-12);
        }

        [TestMethod()]
        public void WeightedMeanTest()
        {
            var s = new Descriptives();
            s.AddSample(1,2);
            Assert.AreEqual(s.Mean(), 1);
            s.AddSample(2);
            Assert.IsTrue(System.Math.Abs(s.Mean() - (4.0/3)) < 1e-12);
            s.AddSample(3, 2);
            Assert.IsTrue(System.Math.Abs(s.Mean() - 2) < 1e-12);
        }
    }
}
