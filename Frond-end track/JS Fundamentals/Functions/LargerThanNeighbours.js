'use stict';
function solve(args){
     let length = +args[0], 
        numbers = args[1].split(' ').map(Number),
        largerNumbers = 0;


        for(let i=1;i<length-1;i+=1){
            if(numbers[i]>numbers[i+1]&&numbers[i]>numbers[i-1]){
                largerNumbers+=1;
            }
        }
        console.log(largerNumbers);
}

solve(['6', '-26 -25 -28 31 2 27']);