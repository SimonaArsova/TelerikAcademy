'use strict';
function solve(args){
    let numbers = args[0].split(' ').map(Number);
       
    function GetMax(numbers){
        let max = numbers[0];
        for(let i=0; i<numbers.length; i+=1){
            if(max<numbers[i]){
                max = numbers[i];
            }
        }
        return max;
    }

    console.log(GetMax(numbers));
}

solve(['8 9 6']);