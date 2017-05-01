'use strict'
function solve(args){
    let url = args[0],
        regex = url.match(/:\/\/(?:\.)?(.[^/]+)(.*)/);


        console.log('protocol: '+ url.split('://')[0]);
        console.log('server: ' + regex[1]);
        console.log('resource: ' + regex[2]);
}

solve([ 'http://telerikacademy.com/Courses/Courses/Details/239' ]);