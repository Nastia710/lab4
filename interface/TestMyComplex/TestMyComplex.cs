namespace TestMyComplex
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_A_Plus_B_Positive()
        {
            MyComplex a = new MyComplex(1, 2);
            MyComplex b = new MyComplex(2, 1);

            MyComplex res = a.Add(b);
            Assert.AreEqual(res.ToString(), "3+3i");
        }

        [Test]
        public void Test_A_Plus_B_Negative()
        {
            MyComplex a = new MyComplex(-1, -2);
            MyComplex b = new MyComplex(2, 1);

            MyComplex res = a.Add(b);
            Assert.AreEqual(res.ToString(), "1-1i");
        }

        [Test]
        public void Test_A_Minus_B_Positive()
        {
            MyComplex a = new MyComplex(1, 2);
            MyComplex b = new MyComplex(2, 1);

            MyComplex res = a.Subtract(b);
            Assert.AreEqual(res.ToString(), "-1+1i");
        }

        [Test]
        public void Test_A_Minus_B_Negative()
        {
            MyComplex a = new MyComplex(-2, 2);
            MyComplex b = new MyComplex(-3, -5);

            MyComplex res = a.Subtract(b);
            Assert.AreEqual(res.ToString(), "1+7i");
        }


        [Test]
        public void Test_A_Multiply_B()
        {
            MyComplex a = new MyComplex(-2, 0);
            MyComplex b = new MyComplex(-3, -0);

            MyComplex res = a.Multiply(b);
            Assert.AreEqual(res.ToString(), "6+0i");
        }

        [Test]
        public void Test_A_Divide_B()
        {
            MyComplex a = new MyComplex(-20, 0);
            MyComplex b = new MyComplex(-4, -0);

            MyComplex res = a.Divide(b);
            Assert.AreEqual(res.ToString(), "5+0i");
        }
    }
}