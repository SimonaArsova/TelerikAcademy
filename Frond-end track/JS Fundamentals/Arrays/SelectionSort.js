'use strict';
function solve(params) {
     let length = +params.shift(),
        sequence = params.map(Number),
        min,
        temp;

        for(let i=0; i<length; i++){
            for(let j=i; j<length; j++){
                if(sequence[j]<sequence[i]){
                    temp=sequence[i];
                    sequence[i] = sequence[j];
                    sequence[j] = temp;
                }
            }
        }
        return sequence.join('\n');
}

console.log(solve(['6', '3', '4', '1', '5', '2', '6']));