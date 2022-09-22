using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3_Prog_tech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Prog_tech.Tests
{
    [TestClass()]
    public class CapacityTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var capacity = new Capacity(10, MeasureType.ml);
            Assert.AreEqual("10 мл.", capacity.Verbose());

            capacity = new Capacity(10, MeasureType.m3);
            Assert.AreEqual("10 м.куб.", capacity.Verbose());

            capacity = new Capacity(10, MeasureType.l);
            Assert.AreEqual("10 л.", capacity.Verbose());

            capacity = new Capacity(10, MeasureType.brrl);
            Assert.AreEqual("10 баррель", capacity.Verbose());
        }
        [TestMethod()]
        public void AddNumberTest()
        {
            var capacity = new Capacity(1, MeasureType.ml);
            capacity = capacity + 4.25;
            Assert.AreEqual("5,25 мл.", capacity.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var capacity = new Capacity(3, MeasureType.m3);
            capacity = capacity - 1.75;
            Assert.AreEqual("1,25 м.куб.", capacity.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var length = new Capacity(3, MeasureType.l);
            length = length * 3;
            Assert.AreEqual("9 л.", length.Verbose());
        }
        [TestMethod()]
        public void MeterToAnyTest()
        {
            Capacity capcity;

            capcity = new Capacity(1000, MeasureType.ml);
            Assert.AreEqual("0,001 м.куб.", capcity.To(MeasureType.m3).Verbose());

            capcity = new Capacity(10000 * 2, MeasureType.ml);
            Assert.AreEqual("20 л.", capcity.To(MeasureType.l).Verbose());

            capcity = new Capacity(3 * 3 * Math.Pow(10, 6), MeasureType.ml);
            Assert.AreEqual("1,43088582961965 баррель", capcity.To(MeasureType.brrl).Verbose());
        }
        [TestMethod()]
        public void AnyToMeterTest()
        {
            Capacity length;

            length = new Capacity(1, MeasureType.m3);
            Assert.AreEqual("1000000 мл.", length.To(MeasureType.ml).Verbose());

            length = new Capacity(1, MeasureType.l);
            Assert.AreEqual("1000 мл.", length.To(MeasureType.ml).Verbose());

            length = new Capacity(1, MeasureType.brrl);
            Assert.AreEqual("6289810 мл.", length.To(MeasureType.ml).Verbose());
        }
        [TestClass()]
        public class LengthTests
        {
            [TestMethod()]
            public void AddSubKmMetersTest()
            {
                var ml = new Capacity(100, MeasureType.ml);
                var l = new Capacity(1, MeasureType.l);

                Assert.AreEqual("1100 мл.", (ml + l).Verbose());
                Assert.AreEqual("1,1 л.", (l + ml).Verbose());

                Assert.AreEqual("0,9 л.", (l - ml).Verbose());
                Assert.AreEqual("-900 мл.", (ml - l).Verbose());
            }
        }

    }
}