'use strict';
function solve(args){
    const thirdDigit = (args[0]/100%10)|0;
    console.log(thirdDigit === 7 ? 'true': 'false ' + thirdDigit);
}

solve(['5']);