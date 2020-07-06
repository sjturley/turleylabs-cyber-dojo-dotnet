using NUnit.Framework;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void SomeBehavior()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        string actual = fizzBuzz.Say(10000);
        Assert.AreEqual("expected", actual);
    }
}
