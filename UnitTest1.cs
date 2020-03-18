using NUnit.Framework;
using Lab;

namespace VS_Code_Projects
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                NaturalNumber n = new NaturalNumber(-2);
                n.Write();

                var result = sw.ToString();

                Assert.AreEqual("-2 converted into 2\n" +
                    "2", result);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                NaturalNumber n = new NaturalNumber(-2);
                IntegerNumber i = new IntegerNumber(-2);
                n.Write();
                Console.WriteLine();
                i.Write();


                var result = sw.ToString();

                Assert.AreEqual("-2 converted into 2\n" +
                    "2\n" +
                    "-2", result);
            }
        }
    }
}