using FunctionLibrary;
namespace FunctionLibraruTest
{
    [TestClass]
    public class FunctionTests
    {
        [TestMethod]
        public void CalculateFunction_IsShouldNotThrowsException_Null()
        {
            Function function = new Function(1.0, 0.1, 50);

            Assert.ThrowsException<System.ArithmeticException>(() => function.CalculateFunction());
        }

        [TestMethod]
        public void CalFun_IsShouldThrowsException_Null()
        {
            Function function = new Function(1.0, 0.1, 50);

            Assert.ThrowsException<System.ArithmeticException>(() => function.CalFun());
        }

        [TestMethod]
        public void CalculateFunction_IsShouldThrowsException_StackIsOverflow()
        {
            Function function = new Function(1.0, 5.0, 50);

            Assert.ThrowsException<System.ArithmeticException>(() => function.CalculateFunction());
        }

        [TestMethod]
        public void CalFun_IsShouldNotThrowsException_StackIsOverflow()
        {
            Function function = new Function(1.0, 5.0, 50);

            Assert.ThrowsException<System.ArithmeticException>(() => function.CalFun());
        }
    }
}