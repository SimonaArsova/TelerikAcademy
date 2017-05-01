'use strict';
// function solve(args){
//     let text = args[0];

//     let regex =  /<orgcase>(.*?)<\/orgcase>/g;
//     text = text.replace(regex, function(){return arguments[1]});
   
//     regex = /<upcase>(.*?)<\/upcase>/g;
//     text = text.replace(regex, function(){return arguments[1].toUpperCase()});
//     regex =  /<lowcase>(.*?)<\/lowcase>/g;
//     text = text.replace(regex, function(){return arguments[1].toLowerCase()}); 
//     regex =  /<LOWCASE>(.*?)<\/LOWCASE>/g;
//     text = text.replace(regex, function(){return arguments[1].toLowerCase()});
    
//     console.log(text);


// }

function solve(args) {
    let text = args[0].toString();
    let len = text.length;
    let result = '';
    let operation = ['n'];
    for (let i = 0; i < len; i += 1) {
        if (text[i] === '<') {
            let index = text.indexOf('>', i);
            let choise = text.substring(i + 1, index);
            switch (choise) {
                case 'upcase':
                        operation.push('u');
                    i += 7;
                    break;
                case 'lowcase':
                      operation.push( 'l');
                    i += 8;
                    break;
                case 'orgcase':
                      operation.push('o');
                    i += 8;
                    break;
                case '\/upcase':
                    operation.pop();
                    i += 8;
                    break;
                case '\/lowcase':
                    operation.pop();
                    i += 9;
                    break;
                case '\/orgcase':
                    operation.pop();
                    i += 9;
                    break;
                default:
                    result += text[i];
            }
        } else {
            switch (operation[operation.length-1]) {
                case 'u':
                    result += text[i].toUpperCase();
                    break;
                case 'l':
                    result += text[i].toLocaleLowerCase();
                    break;
                default:
                    result += text[i];
            }
 
        }
    }
    console.log(result);
}


solve(["text <upcase> text1 <orgcase> TeXt2 </orgcase> text3 </upcase> text4 <lowcase> text5 <upcase> text6 </upcase> text7 </lowcase> text8" ]);