'use strict';
function solve(args){
    let text = args[0];
    console.log(text.replace(/\s/g,'&nbsp;'));
}

function withoutRegex(args) {
  let result = '',
      text = args[0];

  for (let i = 0, len = text.length; i < len; i += 1) {
    result += text[i] === ' ' ? '&nbsp;' : text[i];
  }

  console.log(result);
}

solve([ 'This text contains 4 spaces!!' ]);