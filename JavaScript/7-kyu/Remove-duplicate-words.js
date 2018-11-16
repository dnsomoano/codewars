// Your task is to remove all duplicate words from string, leaving only single(first) words entries.

//   Example:

// Input:

// 'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

// Output:

// 'alpha beta gamma delta'

function removeDuplicateWords(s) {
  const wordList = s.split(" ");
  let bucket = [];
  wordList.map(word => {
    if (!bucket.includes(word)) {
      bucket.push(word);
    }
  });
  return bucket.toString().replace(/,/gi, " ");
}

// Refactored version
function removeDuplicateWords(s) {
  const wordList = s.split(" ");
  let bucket = [];
  wordList.map(word => (!bucket.includes(word) ? bucket.push(word) : false));
  return bucket.toString().replace(/,/gi, " ");
}

Test.describe("Example tests", _ => {
  Test.it("should handle example case", _ => {
    Test.assertEquals(
      removeDuplicateWords(
        "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"
      ),
      "alpha beta gamma delta"
    );
  });
});

// Best Practice Solutions
// Unnamed, Somethee, brianmichael, HomeCode, kontic, Imahori (plus 44 more warriors)
const removeDuplicateWords = s => [...new Set(s.split(" "))].join(" ");

// StevenJBurns, alammers83
const removeDuplicateWords = s => {
  let arr = s.split(" ");
  let sFiltered = [];

  for (let str of arr) if (!sFiltered.includes(str)) sFiltered.push(str);

  return sFiltered.join(" ");
};

// EviL_LegioN
const removeDuplicateWords = s => {
  const set = new Set(s.split(" "));
  return Array.from(set).join(" ");
};

// natela
const removeDuplicateWords = s =>
  s
    .split(" ")
    .filter((w, i, arr) => arr.indexOf(w) == i)
    .join(" ");

// xieze
function removeDuplicateWords(s) {
  return s
    .split(" ")
    .filter((n, i, s) => {
      return s.indexOf(n) === i;
    })
    .join(" ");
}

// sugar, Chrono79, Torkel, CocoVM, Maxitenia, Ginkomix (plus 25 more warriors)
function removeDuplicateWords(s) {
  return [...new Set(s.split(" "))].join(" ");
}

// e.mihaylin;
const removeDuplicateWords = s =>
  s.split` `.filter((e, i, a) => i === a.indexOf(e)).join` `;

// lodash solution
// siebenschlaefer, KenKamau;
const _ = require("lodash");
const removeDuplicateWords = s => _.uniq(s.split(" ")).join(" ");
