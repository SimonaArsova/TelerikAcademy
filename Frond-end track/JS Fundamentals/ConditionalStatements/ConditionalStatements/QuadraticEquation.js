'use strict';

function solve(args){
    const a = +args[0],
    b = +args[1],
    c= +args[2];

     if((Math.pow(b,2) - (4*a*c)) < 0){
        console.log('no real roots');
        return;
    }

    let x1 = (-1 * b - Math.sqrt(Math.pow(b, 2) - (4 * a * c))) / (2 * a);
    let x2 = (-1 * b + Math.sqrt(Math.pow(b, 2) - (4 * a * c))) / (2 * a);

    if(x1 < x2){
        console.log('x1=' + x1.toFixed(2) + ';'+ ' ' + 'x2=' + x2.toFixed(2));
    }
    else if(x2 < x1){
        console.log('x1=' + x2.toFixed(2) + ';' + ' ' + 'x2=' + x1.toFixed(2));
    }
    else{
        console.log('x1=x2=' + x1.toFixed(2));
    } 
}
solve(['2', '5', '-3']);
solve(['-1', '3', '0']);
solve(['-0.5', '4', '-8']);
solve(['5', '2', '8']); //no real roots