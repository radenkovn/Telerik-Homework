namespace RefactoringMatrix.Tests
{
    using System;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RefactoringMatrix;
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void TestIfTheMatrixIsFilledWithCorrectNumbers()
        {
            var matrixSize = 3;
            int[,] matrix = new int[matrixSize, matrixSize];
            Matrix.FillMatrix(matrix, matrixSize);
            string expectedResult = "178629543";
            StringBuilder matrixToText = new StringBuilder();
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrixToText.Append(matrix[i, j]);
                }
            }

            Assert.AreEqual(expectedResult, matrixToText.ToString(), "Expected a the matrix to be filled with the correct numbers");
        }

        [TestMethod]
        public void TestIfValidateDirectionReturnsTrueWhenThereIsAPosibleDirection()
        {
            int[,] matrix = { { 1, 1, 1 }, { 1, 1, 1 }, { 0, 1, 1 } };
            var currentRow = 1;
            var currentCol = 1;
            var validatedDestination = Matrix.ValidateDirection(matrix, currentRow, currentCol);
            var expectedResult = true;
            Assert.AreEqual(expectedResult, validatedDestination, "Expected the method ValidateDirection to return false when there is no possible direction");
        }
        [TestMethod]
        public void TestIfValidateDirectionReturnsFalseWhenNoPosibleDirection()
        {
            int[,] matrix = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            var currentRow = 1;
            var currentCol = 1;
            var validatedDestination = Matrix.ValidateDirection(matrix, currentRow, currentCol);
            var expectedResult = false;
            Assert.AreEqual(expectedResult, validatedDestination, "Expected the method ValidateDirection to return false when there is no possible direction");
        }

        [TestMethod]
        public void TestIfGetNextCellReturnsTheCorrectDestinations()
        {
            int[,] matrix = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 0, 0 } };
            var expectedRow = 2;
            var expectedCol = 1;
            var nextPossibleCell = Matrix.GetNextCell(matrix);
            var resultRow = nextPossibleCell.Row;
            var resultCol = nextPossibleCell.Col;
            Assert.AreEqual(expectedRow, resultRow, "Expected the method GetNextCell's row to be equal to the actual row");
            Assert.AreEqual(expectedCol, resultCol, "Expected the method GetNextCell's col to be equal to the actual col");
        }

        [TestMethod]
        public void TestIfGetNewDirectionReturnsTheCorrectDirection()
        {
            int[,] matrix = { { 0, 0, 0 }, { 0, 0, 1 }, { 1, 1, 1 } };
            var destinationRow = 1;
            var destinationCol = 1;
            var expectedRow = 1;
            var expectedCol = 0;
            var nextPossibleCell = Matrix.GetNewDirection(destinationRow, destinationCol);
            var resultRow = nextPossibleCell.Row;
            var resultCol = nextPossibleCell.Col;
            Assert.AreEqual(expectedRow, resultRow, "Expected the method GetNewDirection's row to be equal to the actual row");
            Assert.AreEqual(expectedCol, resultCol, "Expected the method GetNewDirection's col to be equal to the actual col");
        }
    }
}
