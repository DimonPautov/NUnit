using Microsoft.VisualStudio.TestTools.UnitTesting;
using Groups.Implementations;

namespace Tests
{
    [TestClass]
    public class PersonEntityTests
    {
        [TestMethod]
        public void PersonEntity_IdInitialized()
        {
            var person = new PersonEntity();

            Assert.IsNotNull(person.Id);
        }
    }
}
