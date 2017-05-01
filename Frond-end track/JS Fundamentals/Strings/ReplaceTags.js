'use strict';
function solve(args){
    let text = args[0],
    regex = /<a href="(.*?)">(.*?)<\/a>/g;
    text = text.replace(regex, function(){return `[${arguments[2]}](${arguments[1]})`});
    
    console.log(text);
}

solve([ '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>' ]);