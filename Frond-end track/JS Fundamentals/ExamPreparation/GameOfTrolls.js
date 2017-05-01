'use strict';
function solve(args) {
    const dimensions = args[0].split(' ').map(Number),
        rows = dimensions[0],
        cols = dimensions[1],
        coordinates = args[1].split(';'),
        wboTrollCoordinates = coordinates[0].split(' ').map(Number),
        nbsTrollCoordinates = coordinates[1].split(' ').map(Number),
        princessCoordinates = coordinates[2].split(' ').map(Number);
    args.shift();
    args.shift();
    const commands = args;

    let isTrap = false,
        isWTrollInTrap = false,
        isNTrollInTrap = false,
        trapCoordinates,
        direction,
        wboTrollCurrentCoordinates = wboTrollCoordinates,
        nbsTrollCurrentCoordinates = nbsTrollCoordinates,
        princessCurrentCoordinates = princessCoordinates;


    for (let command of commands) {
        if (command.split(' ')[0] == "mv") {
            direction = command.split(' ')[2];

            if (command.split(' ')[1] === "Wboup") {
                if (!isWTrollInTrap) {
                    wboTrollCurrentCoordinates = move(direction, wboTrollCurrentCoordinates);
                    if (wboTrollCurrentCoordinates === trapCoordinates) {
                        isWTrollInTrap = true;
                    }
                } else {
                    if (wboTrollCurrentCoordinates === nbsTrollCurrentCoordinates) {
                        isWTrollInTrap = false;
                        isTrap = false;
                    }
                }
            }
            else if (command.split(' ')[1] === "Nbslbub") {
                if (!isNTrollInTrap) {
                    nbsTrollCurrentCoordinates = move(direction, nbsTrollCurrentCoordinates);
                    if (nbsTrollCoordinates === trapCoordinates) {
                        isNTrollInTrap = true;
                    }
                } else {
                    if (nbsTrollCurrentCoordinates === wboTrollCurrentCoordinates) {
                        isNTrollInTrap = false;
                        isTrap = false;
                    }
                }
            }

            else {
                princessCurrentCoordinates = move(direction, princessCurrentCoordinates);

            }

        }
        else if (command.split(' ')[0] == "lay") {
            trapCoordinates = princessCurrentCoordinates;
            isTrap = true;
        }
    }

    if (princessCurrentCoordinates[0] === rows - 1 && princessCurrentCoordinates[1] === cols - 1) {
        console.log(`Lsjtujzbo is saved! ${wboTrollCurrentCoordinates.join(' ')} ${nbsTrollCurrentCoordinates.join(' ')}`);
    }

    else if (((princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0] + 1) && (princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1])) ||
        ((princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0] - 1) && (princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1])) ||
        ((princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1] + 1) && (princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0])) ||
        ((princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1] - 1) && (princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0])) ||
        ((princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0] - 1) && (princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1] - 1)) ||
        ((princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0] - 1) && (princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1] + 1)) ||
        ((princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0] + 1) && (princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1] + 1)) ||
        ((princessCurrentCoordinates[0] === nbsTrollCurrentCoordinates[0] + 1) && (princessCurrentCoordinates[1] === nbsTrollCurrentCoordinates[1] - 1)) ||
        ((princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0] + 1) && (princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1])) ||
        ((princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0] - 1) && (princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1])) ||
        ((princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1] + 1) && (princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0])) ||
        ((princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1] - 1) && (princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0])) ||
        ((princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0] - 1) && (princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1] - 1)) ||
        ((princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0] - 1) && (princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1] + 1)) ||
        ((princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0] + 1) && (princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1] + 1)) ||
        ((princessCurrentCoordinates[0] === wboTrollCurrentCoordinates[0] + 1) && (princessCurrentCoordinates[1] === wboTrollCurrentCoordinates[1] - 1))) {
        console.log(`The trolls caught Lsjtujzbo at ${princessCurrentCoordinates.join(' ')}`);
    }
    else {
        console.log(`Lsjtujzbo is saved! ${wboTrollCurrentCoordinates.join(' ')} ${nbsTrollCurrentCoordinates.join(' ')}`);
    }

    function move(direction, currentPosition) {
        if (direction === 'u') {
            currentPosition[0] -= 1;
            if (currentPosition[0] < 0) {
                currentPosition[0] += 1;
            }
        }
        else if (direction === 'd') {
            currentPosition[0] += 1;
            if (currentPosition[0] > rows - 1) {
                currentPosition[0] -= 1;
            }
        }
        else if (direction === 'l') {
            currentPosition[1] -= 1;
            if (currentPosition[1] < 0) {
                currentPosition[1] += 1;
            }
        }
        else {
            currentPosition[1] += 1;
            if (currentPosition[1] > cols - 1) {
                currentPosition[1] -= 1;
            }
        }
        return currentPosition;
    }
}

solve([
    '7 7',
    '0 1;0 2;3 3',
    'mv Lsjtujzbo l',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo r',
    'lay trap',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup l',
    'mv Wboup l',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub r',
    'mv Nbslbub d',
    'mv Lsjtujzbo d',
    'mv Lsjtujzbo l',
    'mv Lsjtujzbo l',
    'mv Nbslbub l',
    'mv Nbslbub d',
    'mv Nbslbub d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo d',
    'mv Wboup d',
    'mv Wboup d',
    'mv Wboup r',
    'mv Lsjtujzbo r',
    'mv Lsjtujzbo r'
]);