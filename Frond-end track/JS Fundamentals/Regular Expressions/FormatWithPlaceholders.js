'use strict';
function solve(args) {
  var person = JSON.parse(args[0]);
  String.prototype.format = function(options) {
    var option,
      regex,
      formatted = this;
    for (option in options) {
      regex = new RegExp('#{' + option + '}', 'g');
      formatted = formatted.replace(regex, options[option]);
    }
    return formatted;
  };
  console.log(args[1].format(person));
}

 solve([
'{ "name": "John", "age": 13 }',
"My name is #{name} and I am #{age}-years-old"
]);