'use stict';
function solve(args){
     let length = +args[0], 
        numbers = args[1].split(' ').map(Number),
        firstLarger = -1;

        for(let i=1;i<length-1;i+=1){
            if(numbers[i]>numbers[i+1]&&numbers[i]>numbers[i-1]){
                firstLarger = i;
                break;
            }
        }
        console.log(firstLarger);
}

solve(['6', '-26 -25 -28 31 2 27']);