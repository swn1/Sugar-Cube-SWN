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
    public class CubeTests
    {
        [TestMethod()]
        public void StepTest()
        {
            var j = new Job(1000, 1, 100, null);
            var c = new Cube(1000, j);
            Assert.AreEqual(c.Step(), 0);
            Assert.AreEqual(c.Step(), 0);
            Assert.IsTrue(c.Step() > 100);
        }
    }
}
