using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DeleteFunc = DeleteLine.Program;

namespace UnitTestDeleteLine
{
  /// <summary>
  /// Test la méthode AddDateToFileName utilisée dans Main program.
  /// </summary>
  [TestClass]
  public class UnitTestAddDateToFileName
  {
    [TestMethod]
    public void TestMethod_filename()
    {
      const string source = "filename.txt";
      string tmpDateTime = DateTime.Now.ToShortDateString();
      tmpDateTime = tmpDateTime.Replace('/', '-');
      string expected = $"filename_{tmpDateTime}.txt";
      string result = DeleteFunc.AddDateToFileName(source);
      Assert.AreEqual(result, expected);
    }
  }
}