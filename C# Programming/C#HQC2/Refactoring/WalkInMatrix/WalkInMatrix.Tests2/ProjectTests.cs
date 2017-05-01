using NUnit.Framework;
using System;
using WalkInMatrix.Models;

namespace WalkInMatrix.Tests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test]
        public void CoordinatesShouldThrowExceptionWhenNegativeValuesPassed()
        {
            Assert.Throws<ArgumentException>(() => new Cell(-1, -1));
        }

        [Test]
        [TestCase(-5)]
        [TestCase(0)]
        [TestCase(101)]
        public void MatrixShouldThrowExceptionWhenRangeIsNotCorrect(int value)
        {
            Assert.Throws<ArgumentException>(() => new SquareMatrix(value));
        }

        [Test]
        public void MatrixShouldReturnCorrectMatrixOfSize1()
        {
            var matrix = new SquareMatrix(1);
            matrix.FillRotatingWalk();
            var expected = new int[,] { { 1 } };

            Assert.IsTrue(this.MatricesAreEqual(expected, matrix.Matrix));
        }

        [Test]
        public void MatrixShouldReturnCorrectMatrixOfSize6()
        {
            var matrix = new SquareMatrix(6);
            matrix.FillRotatingWalk();
            var expected = new int[,]
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 30, 3, 26, 30, 22 },
                { 13, 35, 31, 4, 25, 23 },
                { 12, 34, 33, 32, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            Assert.IsTrue(this.MatricesAreEqual(expected, matrix.Matrix));
        }

        private bool MatricesAreEqual(int[,] expected, int[,] actual)
        {
            if (expected.GetLength(0) != actual.GetLength(0) || expected.GetLength(1) != actual.GetLength(1))
            {
                return false;
            }

            for (int row = 0; row < expected.GetLength(0); row++)
            {
                for (int col = 0; col < expected.GetLength(1); col++)
                {
                    if (expected[row, col] != actual[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}