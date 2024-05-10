using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VineriS8DataBinding;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mfvm = new MainFormViewModel();
            mfvm.FirstName = "Mos";
            mfvm.LastName = "Craciun";
            mfvm.AddParticipant();
            Assert.AreEqual(mfvm.Participants.Count, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var mfvm = new MainFormViewModel();
            mfvm.FirstName = "Mos";
            mfvm.LastName = "Craciun";
            mfvm.AddParticipant();
            Assert.AreEqual(mfvm.Participants.Count, 0);
        }
    }
}
