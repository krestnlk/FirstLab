using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tolilaba;

namespace UnitTestProject1
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void Check_Creating_Cell_Of_List()
        {
            //Arrange
            double n = -4;
            Matrix.cell c = new Matrix.cell(-4,-4);

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => c.i == n || c.j == n);

        }
        [TestMethod]
        public void Check_Zero_Size_Matrix()
        {
            //Arrange
            double z = 0;
            Matrix m = new Matrix(0, 0);

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => m.Row == z || m.Col == z);
        }
        [TestMethod]
        public void Check_Fitting_Correct_Sizes_Of_Matrix_In_Multiplication()
        {
            //Arrange
            Matrix x = new Matrix(3, 2);
            Matrix y = new Matrix(3, 4);

            //Act
            x.multiplierMatrix(y);

            //Assert
            Assert.

        }
        [TestMethod]
        public void Check_Negative_Size_Of_Matrix()
        {
            //Arrange
            double z = -4;
            Matrix m = new Matrix(-4, -4);

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => m.Row == z || m.Col == z);


        }
        [TestMethod]
        public void Check_If_Matrix_Is_Quadrant()
        {
            //Arrange


            //Act


            //Assert


        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange


            //Act


            //Assert


        }
        [TestMethod]
        public void Check_Pushed_Meaning_For_Zero()
        {
            //arrangement
            Matrix.cell c = new Matrix.cell(1,1,0);
            Matrix m = new Matrix(1, 1);    
            Matrix.cell expected = null;
            //act
            m.Push(c);
            //assert
            Assert.AreNotEqual(expected, m.First);
        }




    }
}
