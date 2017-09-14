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
            return timeInMirror;
        }
    }
}
