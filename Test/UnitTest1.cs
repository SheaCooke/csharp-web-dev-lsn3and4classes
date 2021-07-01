using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolPractice;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        Student s1;

        [TestInitialize]
        public void Initialize()
        {
            s1 = new Student();
        }

        [TestCleanup]
        public void CleanUp()
        {
            s1 = null;
        }

        [TestMethod]
        public void TestAddGrade()
        {
            s1.AddGrade(3, 4);
            s1.AddGrade(4, 3);
            Assert.AreEqual(s1.Gpa, 3.43, .1);
        }
    }
}
