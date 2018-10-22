// You will be given a string (x) featuring a cat 'C' and a mouse 'm'. The rest of the string will be made up of '.'.

// You need to find out if the cat can catch the mouse from it's current position. The cat can jump over three characters. So:

// C.....m returns 'Escaped!' <-- more than three characters between

// C...m returns 'Caught!' <-- as there are three characters between the two, the cat can jump.

using System;

public class Kata
{
  public static string CatMouse(string x)
  {
  return x.Length < 6 ? "Caught!" : "Escaped!";
  }
}

namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void ExampleTests()
    {
      Assert.AreEqual("Escaped!", Kata.CatMouse("C....m"));
      Assert.AreEqual("Caught!", Kata.CatMouse("C..m"));
      Assert.AreEqual("Escaped!", Kata.CatMouse("C.....m"));
    }
  }
}