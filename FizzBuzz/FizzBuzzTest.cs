using NUnit.Framework;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void SomeBehavior()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        string actual = fizzBuzz.fizzBuzz(10000);
        Assert.AreEqual("expected", actual);
    }
}