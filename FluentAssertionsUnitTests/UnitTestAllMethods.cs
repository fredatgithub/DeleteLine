using NUnit.Framework;
using FluentAssertions;

namespace FluentAssertionsUnitTests
{
  [TestFixture]
  public class UnitTestAllMethods
  {
    [Test]
    public void Should_Start_With_Example()
    {
      const string actual = "ABCDEFGHI";
      actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
    }
  }
}