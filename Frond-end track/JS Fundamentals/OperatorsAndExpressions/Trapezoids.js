'use strict';
function solve(args){
    const a = +args[0],  
          b = +args[1],
          h = +args[2],
          area = ((a+b)/2)*h;
          
    console.log(area.toFixed(7));
}

solve(['5', '7', '12']);