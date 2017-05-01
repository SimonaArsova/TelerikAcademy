'use strict';
function solve(args){
    let heights = args[0].split(' ').map(Number);

    let result=0;

    function isPeak(index){
        if(index === 0 || index=== heights.length-1){
            return false;
        }
        if(heights[index]>heights[index-1]&& heights[index]>heights[index+1]){
            return true;
        }
        return false;
    }

    for(let i = 1; i<heights.length-1; i+=1){
        if(isPeak(i-1)&&isPeak(i+1)){
            result+=heights[i];
        }
    }

    console.log(result);
}

solve([
    "53 20 1 30 2 40 3 10 1"
]);