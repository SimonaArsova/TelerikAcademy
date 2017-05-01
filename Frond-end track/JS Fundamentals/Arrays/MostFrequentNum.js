'use strict';
function solve(params) {
     let length = +params.shift(),
        sequence = params.map(Number),
        repeated,
        count = 1,
        maxCount = 0;

       sequence.sort();
        for (let i = 0; i < sequence.length - 1; i += 1) {
        if (sequence[i] === sequence[i + 1]) {
            count += 1;
            if (count > maxCount) {
                maxCount = count;
                repeated = sequence[i];
            }
        } else {
            count = 1;
        }
    }
       console.log(repeated + ' (' + maxCount + " times)");
}

solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);