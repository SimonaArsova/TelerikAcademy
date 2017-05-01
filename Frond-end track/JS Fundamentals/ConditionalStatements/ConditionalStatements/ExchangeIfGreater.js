function solve (args) {
  var a = +args[0],
      b = +args[1]
  var bigger
  if (a > b) {
      bigger = a
      a = b
      b = bigger
      console.log(a + ' ' + bigger)
    }
  else {
      console.log(a + ' ' + b)
    }
}
solve(['5','4']);
