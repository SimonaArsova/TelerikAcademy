'use strict';
function solve(args){
    let length = +args[0], 
        numbers = args[1].split(' ').map(Number),
        x = +args[2],
        count=0;

        for(let i = 0; i<length;  i+=1){
            if(x===numbers[i]){
                count+=1;
            }
        }

        console.log(count);
}

solve(['8','28 6 21 6 -7856 73 73 -56', '73']);