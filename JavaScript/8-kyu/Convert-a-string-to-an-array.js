// Write a function to split a string and convert it into an array of words.For example:

// "Robin Singh" ==> ["Robin", "Singh"]

// "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]

function stringToArray(string) {
  return string.split();
}

Test.expect(stringToArray("Robin Singh"), ["Robin", "Singh"]);
Test.expect(stringToArray("I love arrays they are my favorite"), [
  "I",
  "love",
  "arrays",
  "they",
  "are",
  "my",
  "favorite"
]);
