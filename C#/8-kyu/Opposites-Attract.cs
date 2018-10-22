// Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each.If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
// Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.

using System;
using NUnit.Framework;

public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        { 
          //Moment of truth...
          if (flower1 % 2 == 0 && flower2 % 2 != 0) {
              return true;
          } else if (flower2 % 2 == 0 && flower1 % 2 != 0) {
              return true;
          } else {
              return false;
              
          }
          
        }
    }

  [TestFixture]
  public class LoveTests
  { 
    [Test]
    public void Test1()
    {
      Assert.AreEqual(true, LoveDetector.lovefunc(1,4));
    }

    [Test]
    public void Test2()
    {
      Assert.AreEqual(false, LoveDetector.lovefunc(2,2));
    }

    [Test]
    public void Test3()
    {
     Assert.AreEqual(true, LoveDetector.lovefunc(0,1));
    }

    [Test]
    public void Test4()
    {
      Assert.AreEqual(false, LoveDetector.lovefunc(0,0));
    }
}