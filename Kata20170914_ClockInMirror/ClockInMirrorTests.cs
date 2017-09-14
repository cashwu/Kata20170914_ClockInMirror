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

        [TestMethod]
        public void input_1201_should_return_1159()
        {
            WhatIsTheTimeInMirrorShouldBe("11:59", "12:01");
        }

        [TestMethod]
        public void input_1158_should_return_1202()
        {
            WhatIsTheTimeInMirrorShouldBe("12:02", "11:58");
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
            var minNUm = (60 - int.Parse(timeInMirror.Split(':')[1])) % 60;

            var hourNum = (minNUm == 00 ? 12 : 11) - int.Parse(timeInMirror.Split(':')[0]);
            hourNum = hourNum <= 0 ? hourNum += 12 : hourNum;

            return $"{hourNum:00}:{minNUm:00}";
        }
    }
}
