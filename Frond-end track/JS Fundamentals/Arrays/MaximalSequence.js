'use strict';
function solve(params) {
     let length = +params.shift(),
        sequence = params.map(Number),
        count = 1,
        maxCount = 0;

    for (let i = 0; i < sequence.length - 1; i += 1) {
        if (sequence[i] === sequence[i + 1]) {
            count += 1;
            if (count > maxCount) {
                maxCount = count;
            }
        } else {
            count = 1;
        }
    }

    return maxCount;
}

console.log(solve(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']));