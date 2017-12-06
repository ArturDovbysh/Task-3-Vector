using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3_ArturDovbysh;

namespace Task_3_Vector.Tests
{
    [TestClass]
    public class ConstructorsTests
    {
        [TestMethod]
        public void ConstructorByDefault_ShouldCreate_NotNullObject()
        {
            Vector vector = new Vector();

            Assert.IsNotNull(vector);
        }

        [TestMethod]
        public void ConstructorByDefault_ShouldCreate_ZeroLengthVector()
        {
            Vector vector = new Vector();

            Assert.IsTrue(vector.Length == 0);
        }

        [TestMethod]
        public void ConstructorWithParameterLength_ShouldCreate_ExpectedLengthVector()
        {
            Vector vector = new Vector(10);

            Assert.IsTrue(vector.Length == 10);
        }

        [TestMethod]
        public void ConstructorWithParameterArray_ShouldCreate_VectorWithSameValues()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            bool isSame = true;

            Vector vector = new Vector(arr);

            for(int i =0; i < vector.Length; i++)
            {
                if(vector[i]!=arr[i])
                {
                    isSame = false;
                    break;
                }
            }

            Assert.IsTrue(isSame);
        }
    }
}
