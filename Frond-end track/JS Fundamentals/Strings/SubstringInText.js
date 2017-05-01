'use strict';
function solve(args){
    const word = args[0],
    text = args[1];

console.log(text.match(new RegExp(`${word}`, 'gi')).length);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t hinve anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);