'use strict';
function solve(args){
    const width = args[0];
    const height = args[1];
    const perimeter = 2*width + 2*height;
    const area = width*height;
    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

solve([ '2.5', '3' ]);