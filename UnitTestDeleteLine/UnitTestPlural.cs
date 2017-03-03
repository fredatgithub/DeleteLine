using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeleteFunc = DeleteLine.Program;

namespace UnitTestDeleteLine
{
  /// <summary>
  /// Test la méthode Plural utilisée dans Main program.
  /// </summary>
  [TestClass]
  public class UnitTestPlural
  {

    [TestMethod]
    public void TestMethod_0()
    {
      const int source = 0;
      const string expected = "";
      string result = DeleteFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1()
    {
      const int source = 1;
      const string expected = "";
      string result = DeleteFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2()
    {
      const int source = 2;
      const string expected = "s";
      string result = DeleteFunc.Plural(source);
      Assert.AreEqual(result, expected);
    }
  }
}