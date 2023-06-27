namespace MISA.WebFresher042023.Demo.UnitTests
{
    [TestFixture]
    public class CaculatorTests
    {


        [TestCase(4, 5, 9)]
        [TestCase(1, 2, 3)]

        public void Add_ValidInput_Success(int a, int b, int expectedResult)
        {
            //Arrange

            //Act
            var actualResult = new Caculator().Add(a, b);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [TestCase(4, 5, -1)]
        [TestCase(1, 2, -1)]

        public void Sub_ValidInput_Success(int a, int b, int expectedResult)
        {
            //Arrange

            //Act
            var actualResult = new Caculator().Sub(a, b);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [TestCase(4, 5, 20)]
        [TestCase(int.MaxValue, int.MaxValue, (long)int.MaxValue * int.MaxValue)]
        public void Mul_ValidInput_Success(int a, int b, long expectedResult)
        {
            //Arrange

            //Act
            var actualResult = new Caculator().Mul(a, b);
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [TestCase(5, 4, (double)5 / 4)]
        [TestCase(2, 1, 2)]
        [TestCase(5, 3, 1.666666666667)]
        public void Div_ValidInput_Success(int a, int b, double expectedResult)
        {
            //Arrange

            //Act
            var actualResult = new Caculator().Div(a, b);

            //Assert
            Assert.That(Math.Abs(actualResult - expectedResult), Is.LessThan(expectedResult - 10e-6));
        }
    }
}