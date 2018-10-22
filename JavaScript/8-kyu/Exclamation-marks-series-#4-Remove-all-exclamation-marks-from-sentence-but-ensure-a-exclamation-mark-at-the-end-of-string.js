// Description:
// Remove all exclamation marks from sentence but ensure a exclamation mark at the end of string.For a beginner kata, you can assume that the input data is always a non empty string, no need to verify it.

//     Examples
// remove("Hi!") === "Hi!"
// remove("Hi!!!") === "Hi!"
// remove("!Hi") === "Hi!"
// remove("!Hi!") === "Hi!"
// remove("Hi! Hi!") === "Hi Hi!"
// remove("Hi") === "Hi!"

function remove(s) {
  let removeBangs = s.replace(/!/g, "");
  return removeBangs.concat("", "!");
}

describe("Basic Tests", function() {
  it("It should works for basic tests", function() {
    Test.assertSimilar(remove("Hi!"), "Hi!");
    Test.assertSimilar(remove("Hi!!!"), "Hi!");
    Test.assertSimilar(remove("!Hi"), "Hi!");
    Test.assertSimilar(remove("!Hi!"), "Hi!");
    Test.assertSimilar(remove("Hi! Hi!"), "Hi Hi!");
    Test.assertSimilar(remove("Hi"), "Hi!");
  });
});
