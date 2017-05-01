'use strict';
function solve(args){
    const x = args[0],
          y = args[1],
          circleRadius = 2,
          distance = Math.sqrt(x * x + y * y).toFixed(2);
          console.log(distance <= circleRadius?'yes ' + distance : 'no ' + distance);
}

solve(['-1', '2']);