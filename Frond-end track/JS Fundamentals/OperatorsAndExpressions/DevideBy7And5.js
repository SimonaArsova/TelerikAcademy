'use strict';
function solve(args){
    const number = args[0];
    console.log((number %7 === 0 && number % 5 === 0)?'true '+ number: 'false ' + number);
}

solve([35]);
solve([5]);