using DeleteLine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeleteFunc = DeleteLine.Program;

namespace UnitTestDeleteLine
{
  /// <summary>
  /// Test la méthode Negative utilisée dans Main program.
  /// </summary>
  [TestClass]
  public class UnitTestNegative
  {
    [TestMethod]
    public void TestMethod_true()
    {
      const bool source = true;
      const string expected = "";
      string result = DeleteFunc.Negative(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_false()
    {
      const bool source = false;
      const string expected = "not ";
      string result = DeleteFunc.Negative(source);
      Assert.AreEqual(result, expected);
    }
  }
}