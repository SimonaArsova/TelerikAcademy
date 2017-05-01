'use strict';

function solve(args){
    const number = args[0];
    let isPrime = true;
    if(number<2){
        isPrime = false;
    }
    else{
        for(let i = 2; i<=Math.sqrt(number); i+=1){
        if(number%i===0){
            isPrime = false;
            break;
            }
        }
    }
    console.log(isPrime);
}

isPrime(['-3']);