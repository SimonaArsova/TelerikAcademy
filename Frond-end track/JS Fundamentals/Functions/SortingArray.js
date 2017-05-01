function solve(args) {
    let length = +args[0],
        numbers = args[1].split(' ').map(Number);

    console.log(Sort(numbers));

    function Sort(sequence) {
        let min,
            temp;

        for (let i = 0; i < length; i++) {
            for (let j = i; j < length; j++) {
                if (sequence[j] < sequence[i]) {
                    temp = sequence[i];
                    sequence[i] = sequence[j];
                    sequence[j] = temp;
                }
            }
        }
        return sequence.join(' ');
    }
}

solve(['6', '3 4 1 5 2 6']);