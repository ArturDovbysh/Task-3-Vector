using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3_ArturDovbysh;

namespace Task_3_Vector.Tests
{
    [TestClass]
    public class OperatorsTests
    {
        [TestMethod]
        public void OperatorPlus_ShouldReturn_ExpectedResult()
        {
            int [] arr1 = { 1, 2, 3 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 2, 1 };
            Vector v2 = new Vector(arr2);

            int[] result = { 4, 4, 4 };    //we expect to get these values
            Vector expectedVector = new Vector(result);

            Vector resultVector = v1 + v2; //result of adding two vectors

            Assert.AreEqual(expectedVector, resultVector);

        }

        [TestMethod]
        public void OperatorMinus_ShouldReturn_ExpectedResult()
        {
            int[] arr1 = { 1, 2, 3 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 2, 1 };
            Vector v2 = new Vector(arr2);

            int[] result = { -2, 0, 2 };       //we expect to get these values
            Vector expectedVector = new Vector(result);

            Vector resultVector = v1 - v2;    //result of subtracting two vectors

            Assert.AreEqual(expectedVector, resultVector);
        }

        [TestMethod]
        public void OperatorMultiplyByNumber_ShouldReturn_ExpectedResult()
        {
            int[] arr1 = { 1, 2, 3 };
            Vector v1 = new Vector(arr1);

            int number = 10;

            int[] result = { 10, 20, 30 };       //we expect to get these values
            Vector expectedVector = new Vector(result);

            Vector resultVector = v1 * number;    //result of multiplying vector by integer

            Assert.AreEqual(expectedVector, resultVector);
        }

        [TestMethod]
        public void OperatorDivideByNumber_ShouldReturn_ExpectedResult()
        {
            int[] arr1 = { 10, 20, 30 };
            Vector v1 = new Vector(arr1);

            int number = 10;

            int[] result = { 1, 2, 3 };       //we expect to get these values
            Vector expectedVector = new Vector(result);

            Vector resultVector = v1 / number;    //result of dividing vector by integer

            Assert.AreEqual(expectedVector, resultVector);
        }

        [TestMethod]
        public void OperatorGraterThan_ShouldReturn_True()
        {
            int[] arr1 = { 10, 20, 30 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 2, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v1 > v2);
        }

        [TestMethod]
        public void OperatorGraterThan_ShouldReturn_False()
        {
            int[] arr1 = { 1, 1, 1 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 2, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsFalse(v1 > v2);
        }

        [TestMethod]
        public void OperatorLessrThan_ShouldReturn_True()
        {
            int[] arr1 = { 10, 20, 30 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 2, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v2 < v1);
        }

        [TestMethod]
        public void OperatorLessThan_ShouldReturn_False()
        {
            int[] arr1 = { 1, 1, 1 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 2, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsFalse(v1 > v2);
        }

        [TestMethod]
        public void OperatorGraterOrEqual_ShouldReturn_True()
        {
            int[] arr1 = { 3, 3, 3 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 3, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v1 >= v2);
        }

        [TestMethod]
        public void OperatorGraterOrEqual_ShouldReturn_False()
        {
            int[] arr1 = { 3, 3, 3 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 3, 4 };
            Vector v2 = new Vector(arr2);

            Assert.IsFalse(v1 >= v2);
        }

        [TestMethod]
        public void OperatorLessOrEqual_ShouldReturn_True()
        {
            int[] arr1 = { 3, 3, 0 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 3, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v1 <= v2);
        }

        [TestMethod]
        public void OperatorLessOrEqual_ShouldReturn_False()
        {
            int[] arr1 = { 3, 2, 3 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 3, 1 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v1 <= v2);
        }

        [TestMethod]
        public void OperatorEqualTo_ShouldReturn_True()
        {
            int[] arr1 = { 3, 3, 3 };
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 3, 3 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v1 == v2);
        }

        [TestMethod]
        public void OperatorEqualTo_ShouldReturn_False()
        {
            int[] arr1 = { 3, 3};
            Vector v1 = new Vector(arr1);

            int[] arr2 = { 3, 3, 3 };
            Vector v2 = new Vector(arr2);

            Assert.IsTrue(v1 != v2);
        }
    }
}
