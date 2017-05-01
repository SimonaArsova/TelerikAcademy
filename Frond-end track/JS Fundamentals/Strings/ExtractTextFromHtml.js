'use strict';

function solve(args){
     let str = '',
     regex = /<.*?>/g;
    for (let i = 0; i < args.length; i+=1) {
      str += args[i].replace(regex, '').trim();
    }
    console.log(str);
}

solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
]);