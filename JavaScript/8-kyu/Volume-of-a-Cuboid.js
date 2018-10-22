// Bob needs a fast way to calculate the volume of a cuboid with three values: length, width and the height of the cuboid.Write a function to help Bob with this calculation.

//     Ruby: def get_volume_of_cuboid(length, width, height) Bash: bash run_shell length width height

var Kata;

Kata = (function() {
  function Kata() {}

  Kata.getVolumeOfCuboid = function(length, width, height) {
    return length * width * height;
  };

  return Kata;
})();

Test.assertEquals(Kata.getVolumeOfCuboid(1, 2, 2), 4);
Test.assertEquals(Kata.getVolumeOfCuboid(6.3, 2, 5), 63);
