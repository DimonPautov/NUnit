using Microsoft.VisualStudio.TestTools.UnitTesting;
using Groups.Implementations;

namespace Tests
{
    [TestClass]
    public class StudentEntityTests
    {
        [TestMethod]
        public void StudentEntity_Promote_IncreasesGradeByOne()
        {
            var student = new StudentEntity { Grade = 5 };

            student.Promote();

            Assert.AreEqual(6, student.Grade);
        }
    }
}
