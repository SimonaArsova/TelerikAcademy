'use strict';

function solve(args) {
    let number = +args[0],
        s = "";

    for(let i=1; i <= number; i+=1) {
        s += i + " ";
    }
    console.log(s);

}
solve([5]);
solve([1]);