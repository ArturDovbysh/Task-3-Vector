using System;

namespace Task_3_ArturDovbysh.VectorLogic
{
    /// <summary>
    /// Represents a set of values as a vector.
    /// </summary>
    public class Vector : IComparable
    {
        private int[] _array;
        private int _length;

        /// <summary>
        /// Gets the total number of elements in vector.
        /// </summary>
        /// <returns>Total number of elemetns in vector or zero if vector is empty.</returns>
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();

                if (_length > value)
                    throw new ArgumentException("We cant set Length propertie less than current.");
                else
                {
                    int[] tmp = new int[value];
                    for(int i = 0; i < _length; i++)
                    {
                        tmp[i] = _array[i];
                    }
                    _array = tmp;
                    _length = value;
                }
            }
        }

        /// <summary>
        /// Indexer to index the vector.
        /// </summary>
        /// <param name="index">Index of an elemet in vector</param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                    throw new ArgumentOutOfRangeException();
                else
                {
                    return _array[index];
                }
            }
            set
            {
                if (index >= Length || index < 0)
                    throw new ArgumentOutOfRangeException();
                else
                {
                    _array[index] = value;
                }
            }
        }

        /// <summary>
        /// Adds specified element to the vector.
        /// </summary>
        /// <param name="element">Int element to add.</param>
        public void AddElement(int element)
        {
            Length++;
            _array[Length - 1] = element;
        }

        /// <summary>
        /// Compares this instance to a specified object and returns a value that indicates whether of their relative values.
        /// </summary>
        /// <param name="obj">An object to compare, or a null value.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and parameter value.
        /// Description of the return value:
        /// is less than zero -> than this instance is less than the value;
        /// is zero -> than this instance and value are equal;
        /// is more than zero -> than this instance is greater than value;
        /// or the value is null.
        /// </returns>
        public int CompareTo(object obj)
        {
            bool flag = true; // isGrater/isSmaller

            if (obj is Vector)
            {
                Vector vec = (Vector)obj;

                if (vec.Length != this.Length)
                    throw new ArgumentException("We cant compare vectors with diffrent lengths");

                if (vec.Equals(this))
                    return 0;

                //check if grater
                for (int i = 0; i < Length; i++)
                {
                    if (this._array[i] >= vec[i])
                        continue;
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    return 1;

                //check if smaller
                flag = true;
                for (int i = 0; i < Length; i++)
                {
                    if (this._array[i] <= vec[i])
                        continue;
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    return -1;
                else return 0;
            }
            else
                throw new ArgumentException();

        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise - false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Vector)
            {
                Vector vector = (Vector)obj;

                if (vector.Length != this.Length)
                    return false;

                for (int i = 0; i < Length; i++)
                {
                    if (this._array[i] != vector[i])
                        return false;
                }

                return true;
            }
            else return false;
        }

        #region Operators

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="v1">First vector to add.</param>
        /// <param name="v2">Second vector to add.</param>
        /// <returns>A new instance of vector.</returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1 == null || v2 == null)
                throw new NullReferenceException();
            if (v1.Length != v2.Length)
                throw new ArgumentOutOfRangeException("To add vectors count of their elements must be equal!");
            if (v1.Length == 0 || v2.Length == 0)
                throw new ArgumentOutOfRangeException("We cant add zero dimentional array");

            Vector tmp = new Vector(v1.Length);
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = v1[i] + v2[i];
            }

            return tmp;
        }

        /// <summary>
        /// Subtracts two vectors.
        /// </summary>
        /// <param name="v1">First vector to subtract.</param>
        /// <param name="v2">Second vector to subtract.</param>
        /// <returns>A new instance of vector.</returns>
        public static Vector operator -(Vector v1, Vector v2)
        {
            if (v1 == null || v2 == null)
                throw new NullReferenceException();
            if (v1.Length != v2.Length)
                throw new ArgumentOutOfRangeException("To add vectors count of their elements must be equal!");
            if (v1.Length == 0 || v2.Length == 0)
                throw new ArgumentOutOfRangeException("We cant add zero dimentional array");

            Vector tmp = new Vector(v1.Length);
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = v1[i] - v2[i];
            }

            return tmp;
        }

        /// <summary>
        /// Multiplies vector by int number.
        /// </summary>
        /// <param name="vector">Vector to multiply.</param>
        /// <param name="number">Multiplier.</param>
        /// <returns></returns>
        public static Vector operator *(Vector vector, int number)
        {
            if (vector.Length == 0)
                throw new ArgumentOutOfRangeException("We cant multiply zero dimentional array by number");

            Vector tmp = new Vector(vector.Length);
            for (int i = 0; i < vector.Length; i++)
            {
                tmp[i] = vector[i] * number;
            }
            return tmp;
        }

        /// <summary>
        /// Divides vector by int number.
        /// </summary>
        /// <param name="vector">Vector to divide.</param>
        /// <param name="number">Divisor.</param>
        /// <returns></returns>
        public static Vector operator /(Vector vector, int number)
        {
            if (vector.Length == 0)
                throw new ArgumentOutOfRangeException("We cant divide zero dimentional array by number");

            Vector tmp = new Vector(vector.Length);
            for (int i = 0; i < vector.Length; i++)
            {
                tmp[i] = vector[i] / number;
            }
            return tmp;
        }

        /// <summary>
        /// Checks if the first vector is greater than the second.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns>True if grater; otherwise - false.</returns>
        public static bool operator >(Vector v1, Vector v2)
        {
            return (v1.CompareTo(v2) > 0);
        }

        /// <summary>
        /// Checks if the first vector is less than the second.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns>True if less; otherwise - false.</returns>
        public static bool operator <(Vector v1, Vector v2)
        {
            return (v1.CompareTo(v2) < 0);
        }

        /// <summary>
        /// Checks if the first vector is grater or equal to the second.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns>True if grater or equal; otherwise - false.</returns>
        public static bool operator >=(Vector v1, Vector v2)
        {
            return (v1.CompareTo(v2) >= 0);
        }

        /// <summary>
        /// Checks if the first vector is less or equal to the second.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns>True if less or equal; otherwise - false.</returns>
        public static bool operator <=(Vector v1, Vector v2)
        {
            return (v1.CompareTo(v2) <= 0);
        }

        /// <summary>
        /// Checks if two vectors are equal.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns>True if equal; otherwise - false.</returns>
        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.Equals(v2);
        }

        /// <summary>
        /// Checks if two vectors are not equal.
        /// </summary>
        /// <param name="v1">First vector to compare.</param>
        /// <param name="v2">Second vector to compare.</param>
        /// <returns>True if not equal; otherwise - false.</returns>
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !v1.Equals(v2);
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of empty vector.
        /// </summary>
        public Vector()
        {
            _array = new int[0]; // =)
        }

        /// <summary>
        /// Initializes a new instance of vector with specified length.
        /// </summary>
        /// <param name="length">Number of elements in vector.</param>
        public Vector(int length)
        {
            if (length <= 0)
                throw new ArgumentException("Length must be > 0");

            Length = length;
        }

        /// <summary>
        /// Initializes a new instance of vector with specified array.
        /// </summary>
        /// <param name="array">Array to put in vector.</param>
        public Vector(int[] array)
        {
            if (array.Length <= 0)
                throw new ArgumentException("Length must be > 0");

            Length = array.Length;
            _array = new int[Length];
            array.CopyTo(_array, 0);
        }

    }
}
