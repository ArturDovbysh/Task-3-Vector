using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3_ArturDovbysh;

namespace Task_3_Vector.Tests
{
    [TestClass]
    public class AddElementTests
    {
        [TestMethod]
        public void AddElemet_ShouldAdd_IntegerValue()
        {
            Vector vector = new Vector();
            vector.AddElement(123);

            Assert.IsTrue(vector[0] == 123);
        }

    }
}
