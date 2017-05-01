'use strict';
function solve(args){
    const x = args[0],
          y = args[1],
          circleRadius = 1.5,
          distance = Math.sqrt((x-1) * (x-1) + (y-1) * (y-1).toFixed(2));
          if(distance <= circleRadius){
              console.log((x>=-1 && x<=5 && y<=1 && y>=-1)?'inside circle inside rectangle':'inside circle outside rectangle');
          }
          else{
               console.log((x>=-1 && x<=5 && y<=1 && y>=-1)?'outside circle inside rectangle':'outside circle outside rectangle');
          }
}

solve(['1', '2']);