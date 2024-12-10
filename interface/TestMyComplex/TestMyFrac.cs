namespace TestMyFrac
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Constructor_With_Zero_Denominator()
        {
            Assert.Throws<DivideByZeroException> (() => new MyFrac(-5, 0));
        }

        [Test]
        public void Test_A_Plus_B_Positive()
        {
            MyFrac a = new MyFrac(1, 2);
            MyFrac b = new MyFrac(2, 1);

            MyFrac res = a.Add(b);
            Assert.AreEqual(res.ToString(), "5/2");
        }

        [Test]
        public void Test_A_Plus_B_Negative()
        {
            MyFrac a = new MyFrac(-3, 2);
            MyFrac b = new MyFrac(2, -20);

            MyFrac res = a.Add(b);
            Assert.AreEqual(res.ToString(), "-8/5");
        }

        [Test]
        public void Test_Copy_Constructor()
        {
            MyFrac a = new MyFrac(-3, 2);
            MyFrac b = new MyFrac(a);

            Assert.AreEqual(a.ToString(), b.ToString());
        }

        /*[Test]
        public void Test_Copy_Constructor_With_Zero_Denominator()
        {
            MyFrac a = new MyFrac(-5, 0);

            Assert.Throws<DivideByZeroException>(() => new MyFrac(a));
        }*/

        [Test]
        public void Test_A_Minus_B_Positive()
        {
            MyFrac a = new MyFrac(3, 2);
            MyFrac b = new MyFrac(2, 20);

            MyFrac res = a.Subtract(b);
            Assert.AreEqual(res.ToString(), "7/5");
        }

        [Test]
        public void Test_A_Minus_B_Negative()
        {
            MyFrac a = new MyFrac(-3, 2);
            MyFrac b = new MyFrac(2, -20);

            MyFrac res = a.Subtract(b);
            Assert.AreEqual(res.ToString(), "-7/5");
        }

        [Test]
        public void Test_A_Multiply_B()
        {
            MyFrac a = new MyFrac(-5, 2);
            MyFrac b = new MyFrac(2, -5);

            MyFrac res = a.Multiply(b);
            Assert.AreEqual(res.ToString(), "1");
        }

        [Test]
        public void Test_A_Divide_B()
        {
            MyFrac a = new MyFrac(-5, 2);
            MyFrac b = new MyFrac(5, 20);

            MyFrac res = a.Divide(b);
            Assert.AreEqual(res.ToString(), "-10");
        }
    }
}
