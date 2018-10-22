// Task
// Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighbouring numbers is equal (note that 0 and n - 1 are neighbouring, too).

// Given n and firstNumber/first_number, find the number which is written in the radially opposite position to firstNumber.

// Example
// For n = 10 and firstNumber = 2, the output should be

//  circleOfNumbers(n, firstNumber) === 7
//  circleOfNumbers(n, firstNumber); // --> 7
// circle_of_numbers($n, $first_number); // -> 7


// Input/Output
// [input] integer n

// A positive even integer.

// Constraints: 4 ≤ n ≤ 1000.

// [input] integer firstNumber/first_number

// Constraints: 0 ≤ firstNumber ≤ n - 1

// [output] an integer

using NUnit.Framework;
using System;

namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int CircleOfNumbers(int n, int FirstNumber){
          return (FirstNumber < (n/2) ? FirstNumber + (n/2) : FirstNumber - (n/2));
        }
    }

    [TestFixture]
    public class myjinxin
    {
        
        [Test]
        public void TestCase(){
            var kata=new Kata();
            
            Assert.AreEqual(7,  kata.CircleOfNumbers(10,2),  "");
            
            Assert.AreEqual(2,  kata.CircleOfNumbers(10,7),  "");
            
            Assert.AreEqual(3,  kata.CircleOfNumbers(4,1),  "");
            
            Assert.AreEqual(0,  kata.CircleOfNumbers(6,3),  "");
            
        }        
    }
}