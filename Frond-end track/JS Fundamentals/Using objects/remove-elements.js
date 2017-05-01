'use strict';

function solve(args){
    var searchElement = args[0],
        arr = [],
        resultArray = [];
    for (var i = 0, len = args.length - 1; i < len; i++)
    {
        arr[i] = args[i + 1];
    }
 
    Array.prototype.remove = function(searchElement) {
        for (var i = 0, len = this.length; i < len; i++)
        {
            if (this[i] == searchElement) // or ===
            {
                this.splice(i, 1);
                i--;
            }
        }
        return this;
    }
 
    resultArray = arr.remove(searchElement);
 
    for(var k = 0, leng = resultArray.length; k < leng; k++)
    {
        console.log(resultArray[k]);
    }
}

solve(['_h/_',
  '^54F#',
  'V',
  '^54F#',
  'Z285',
  'kv?tc`',
  '^54F#',
  '_h/_',
  'Z285',
  '_h/_',
  'kv?tc`',
  'Z285',
  '^54F#',
  'Z285',
  'Z285',
  '_h/_',
  '^54F#',
  'kv?tc`',
  'kv?tc`',
  'Z285']);

solve([ '1', '2', '3', '2', '1', '2', '3', '2' ]);