using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170914_ClockInMirror
{
    [TestClass]
    public class ClockInMirrorTests
    {
        [TestMethod]
        public void input_1200_should_return_1200()
        {
            WhatIsTheTimeInMirrorShouldBe("12:00", "12:00");
        }

        [TestMethod]
        public void input_0100_should_return_1100()
        {
            WhatIsTheTimeInMirrorShouldBe("11:00", "01:00");
        }

        [TestMethod]
        public void input_0300_should_return_0900()
        {
            WhatIsTheTimeInMirrorShouldBe("09:00", "03:00");
        }

        [TestMethod]
        public void input_0900_should_return_0300()
        {
            WhatIsTheTimeInMirrorShouldBe("03:00", "09:00");
        }

        [TestMethod]
        public void input_0105_should_return_1055()
        {
            WhatIsTheTimeInMirrorShouldBe("10:55", "01:05");
        }

        [TestMethod]
        public void input_0525_should_return_0635()
        {
            WhatIsTheTimeInMirrorShouldBe("06:35", "05:25");
        }

        private static void WhatIsTheTimeInMirrorShouldBe(string expected, string timeInMirror)
        {
            var kata = new Kata();
            var actual = kata.WhatIsTheTime(timeInMirror);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string WhatIsTheTime(string timeInMirror)
        {
            var hour = timeInMirror.Split(':')[0];
            var min = timeInMirror.Split(':')[1];

            min = min == "00" ? "00" : (60 - int.Parse(min)).ToString("0#");
            hour = hour == "12" ? "12": ((min == "00" ? 12 : 11) - int.Parse(hour)).ToString("0#");

            return $"{hour}:{min}";
        }
    }
}
