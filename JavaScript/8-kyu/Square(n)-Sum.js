// Complete the square sum method so that it squares each number passed into it and then sums the results together.

// For example: squareSum([1, 2, 2]) should return 9 because 1 ^ 2 + 2 ^ 2 + 2 ^ 2 = 9.

function squareSum(numbers) {
  const sum = 0;
  return numbers.reduce((sum, num) => {
    return (sum += num * num);
  }, 0);
}

Test.assertEquals(squareSum([1, 2]), 5);
Test.assertEquals(squareSum([0, 3, 4, 5]), 50);
