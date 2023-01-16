namespace MyFirstMethodTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = MyFirstMethod.MyFirstMethod.Something();
            Assert.AreEqual("Algo", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MyFirstMethod.MyFirstMethod MyProgram = new MyFirstMethod.MyFirstMethod();
            int result = MyProgram.IntegerMultiplication(3, 6);
            Assert.AreEqual(18, result);

        }
    }
}