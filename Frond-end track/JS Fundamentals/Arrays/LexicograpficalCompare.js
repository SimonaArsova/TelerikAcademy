"use strict";
function solve(args){
    let firstArray = args[0],
    secondArray = args[1];
    if(firstArray>secondArray){
        console.log(">");
    }
    else if(firstArray<secondArray){
        console.log("<");
    }
    else{
        console.log("=");
    }
}

solve(['food', 'food']);