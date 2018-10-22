// Clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.

// Your task is to make 'Past' function which returns time converted to miliseconds.

// #####Example:

// Past(0, 1, 1) == 61000
// Note! h, m and s will be only Natural numbers! Waiting for translations and Feedback! Thanks!

function past(h, m, s) {
  hrConv = h * (60 * 60 * 1000);
  minConv = m * (60 * 1000);
  secConv = s * 1000;
  return hrConv + minConv + secConv;
}

Test.describe("Fixed Tests", _ => {
  Test.it("Tests", __ => {
    Test.assertEquals(past(0, 1, 1), 61000);
    Test.assertEquals(past(1, 1, 1), 3661000);
    Test.assertEquals(past(0, 0, 0), 0);
    Test.assertEquals(past(1, 0, 1), 3601000);
    Test.assertEquals(past(1, 0, 0), 3600000);
  });
});
