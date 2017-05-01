'use strict';

function solve(args){
    const first = +args[0],
    second = +args[1],
    third = +args[2];

    if(first > second && first > third){
        if(second > third){
            console.log(first + ' ' + second + ' ' + third);
        }
        else{
            console.log(first + ' ' + third + ' '+ second);
        }
    }
    else if(second > first && second > third){
        if(first > third){
            console.log(second + ' ' + first + ' ' + third)
        }
        else{
            console.log(second + ' ' + third + ' ' + first);
        }
    }
    else{
        if(first > second){
            console.log(third + ' ' + first + ' ' + second);
        }
        else{
            console.log(third + ' ' + second + ' ' + first);
        }
    }

}
solve(['4','4','5']);
solve(['-2', '4', '3']);
solve(['0', '-2.5', '5']);