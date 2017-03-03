using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeleteFunc = DeleteLine.Program;

namespace UnitTestDeleteLine
{
  /// <summary>
  /// Test la méthode ConvertToTimeString utilisée dans Main program.
  /// </summary>
  [TestClass]
  public class UnitTestDeleteLine
  {
    [TestMethod]
    public void TestMethod_1_day()
    {
      TimeSpan source = new TimeSpan(1, 0, 0, 0);
      const string expected = "1 jour";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_days()
    {
      TimeSpan source = new TimeSpan(2, 0, 0, 0);
      const string expected = "2 jours";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1_hour()
    {
      TimeSpan source = new TimeSpan(0, 1, 0, 0);
      const string expected = "1 heure";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_hours()
    {
      TimeSpan source = new TimeSpan(0, 2, 0, 0);
      const string expected = "2 heures";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1_minute()
    {
      TimeSpan source = new TimeSpan(0, 0, 1, 0);
      const string expected = "1 minute";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_minutes()
    {
      TimeSpan source = new TimeSpan(0, 0, 2, 0);
      const string expected = "2 minutes";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1_second()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 1, 0);
      const string expected = "1 seconde";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1_second_no_millisecond()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 1, 0);
      const string expected = "1 seconde";
      const bool removeZeroArgument = true;
      string result = DeleteFunc.ConvertToTimeString(source, removeZeroArgument);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_seconds_no_millisecond()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 2, 0);
      const string expected = "2 secondes";
      const bool removeZeroArgument = true;
      string result = DeleteFunc.ConvertToTimeString(source, removeZeroArgument);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_0_second()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 0, 0);
      const string expected = "";
      string result = DeleteFunc.ConvertToTimeString(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_0_day_with_zero_argument()
    {
      TimeSpan source = new TimeSpan(0, 0, 0, 0, 0);
      const string expected = "0 jour 0 heure 0 minute 0 seconde 0 milliseconde";
      const bool removeZeroArgument = false;
      string result = DeleteFunc.ConvertToTimeString(source, removeZeroArgument);
      Assert.AreEqual(result, expected);
    }
  }
}