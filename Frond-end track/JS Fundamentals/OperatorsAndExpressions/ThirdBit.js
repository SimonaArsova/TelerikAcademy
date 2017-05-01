'use strict';
function solve(args){
    const number = args[0],
          result = (number>>3)&1;
    console.log((result.toString(2)%10|0));
}

solve(['15']);