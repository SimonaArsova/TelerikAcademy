/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

function solve() {

  return function (element, contents) {
    if (typeof element === 'string') {
      element = document.getElementById(element);
    }

    for (var i = 0; i < contents.length; i += 1) {
      if (typeof contents[i] !== 'number' && typeof contents[i] !== 'string') {
        throw Error('Content must be number or string');
      }
    }

    element.textContent = '';

    for (var i = 0; i < contents.length; i += 1) {
      var div = document.createElement('div');
      div.textContent = contents[i];
      element.appendChild(div);
    }
  }
}

module.exports = solve;