'use strict';
function solve(args){
    const text = args[0];
    let openBrackets = 0,
        closeBrackets = 0;
   for(let i=0; i<text.length; i+=1){
       if(text[i]==='('){
           openBrackets+=1;
       }
       if(text[i]===')'){
           closeBrackets+=1;
       }
   }

   console.log(openBrackets===closeBrackets?'Correct':'Incorrect')
}

solve([ '((a+b)/5-d)' ]);