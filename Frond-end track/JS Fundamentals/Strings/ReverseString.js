'use strict'
function solve(args){
    const text = args[0];
    let anotherText = '';
    for(let i=text.length-1;i>=0;i--){
        anotherText+=text[i];
    }
    console.log(anotherText);
}

solve(['sample']);