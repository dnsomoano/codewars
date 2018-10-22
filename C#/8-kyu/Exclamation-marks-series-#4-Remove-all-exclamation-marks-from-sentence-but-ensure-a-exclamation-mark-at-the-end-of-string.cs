// Description:
// Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string. For a beginner kata, you can assume that the input data is always a non empty string, no need to verify it.

// Examples
// remove("Hi!") === "Hi!"
// remove("Hi!!!") === "Hi!"
// remove("!Hi") === "Hi!"
// remove("!Hi!") === "Hi!"
// remove("Hi! Hi!") === "Hi Hi!"
// remove("Hi") === "Hi!"

public class Kata
{
  public static string Remove(string s)
  {
    return s.Replace("!", "") + '!';
  }
}

namespace Solution {
  using NUnit.Framework;
  using System;

  // TODO: Replace examples and use TDD development by writing your own tests

  [TestFixture]
  public class Test
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("Hi!", Kata.Remove("Hi!"));
      Assert.AreEqual("Hi!", Kata.Remove("Hi!!!"));
      Assert.AreEqual("Hi!", Kata.Remove("!Hi"));
      Assert.AreEqual("Hi!", Kata.Remove("!Hi!"));
      Assert.AreEqual("Hi Hi!", Kata.Remove("Hi! Hi!"));
      Assert.AreEqual("Hi!", Kata.Remove("Hi"));
    }
  }
}