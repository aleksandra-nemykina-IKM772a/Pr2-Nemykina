

namespace Pr2_NemykinaTEST
{
    public class UnitTest1
    {
        
            [Theory]
            [InlineData(5, 120)]
            [InlineData(6, 720)]
            public void TestFactorial(int input, int expected)
            {
                //Arrange


                //Act
                int result = Functions.Factorial(input);

                //Assert
                Assert.Equal(expected, result);

            }

            [Theory]
            [InlineData(5, false)]
            [InlineData(2, true)]
            public void TestParity(int input, bool expected)
            {
                //Arrange


                //Act
                bool result1 = Functions.Parity(input);


                //Assert
                Assert.Equal(expected, result1);

            }


            [Theory]
            [InlineData(new int[] { 5, 8, 7, 4, 1, 0 }, 8)]
            public void TestMaxNumber(int[] input, int expected)
            {
                //Arrange 


                //Act
                int result1 = Functions.MaxNumber(input);


                //Assert
                Assert.Equal(expected, result1);

            }

            [Theory]
            [InlineData(new double[] { 5, 8, 7, 4, 1, 0 }, 4.166666666666667)]
            public void TestAverage(double[] input, double expected)
            {
                //Arrange 

                //Act
                double result1 = Functions.AverageNumber(input);

                //Assert
                Assert.Equal(expected, result1);

            }
       
    }
}