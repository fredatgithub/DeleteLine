using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeleteFunc = DeleteLine.Program;

namespace UnitTestDeleteLine
{
  /// <summary>
  /// Test la méthode RemoveWindowsForbiddenCharacter utilisée dans Main program.
  /// </summary>
  [TestClass]
  public class UnitTestRemoveWindowsForbiddenCharacters
  {
    [TestMethod]
    public void TestMethod_no_character_forbidden()
    {
      const string source = "A long long time ago in a galaxy far far away";
      const string expected = "A long long time ago in a galaxy far far away";
      string result = DeleteFunc.RemoveWindowsForbiddenCharacters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_empty_string()
    {
      const string source = "";
      const string expected = "";
      string result = DeleteFunc.RemoveWindowsForbiddenCharacters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_string_with_star()
    {
      const string source = "she is a *star";
      const string expected = "she is a star";
      string result = DeleteFunc.RemoveWindowsForbiddenCharacters(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_string_with_colon()
    {
      const string source = "he said: be happy";
      const string expected = "he said: be happy";
      string result = DeleteFunc.RemoveWindowsForbiddenCharacters(source);
      Assert.AreEqual(result, expected);
    }
  }
}