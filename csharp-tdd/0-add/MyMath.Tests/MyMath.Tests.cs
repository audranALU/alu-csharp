using NUnit.Framework;

namespace MyMath.Tests;

[TestFixture]
public class OperationsTests
{
    [TestCase(1, 2, 3)]
    [TestCase(-1, 1, 0)]
    [TestCase(0, 0, 0)]
    [TestCase(-5, -5, -10)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        Assert.That(Operations.Add(a, b), Is.EqualTo(expected));
    }
}
