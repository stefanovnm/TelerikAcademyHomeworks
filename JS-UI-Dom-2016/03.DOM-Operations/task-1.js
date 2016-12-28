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
          //var document = typeof document === 'undefined' ? '' : document;
          var res,
              div = document.createElement("div"),
              divElement,
              fragment = document.createDocumentFragment();

        if (typeof element !== "string" && !(element instanceof HTMLElement)) {
            throw new Error("The provided first parameter is neither string or existing DOM element");
        }

        if (typeof element === "string") {
            res = document.getElementById(element);
          
            if (res === null) {
              throw new Error("The provided id does not select anything (there is no element that has such an id)");
            }
            } else if (element instanceof HTMLElement) {
            res = element;
            }

  /*
  * Add divs to the element
    * Each div's content must be one of the items from the contents array
  */
          for (var i = 0, len = contents.length; i < len; i+=1) {

              if (typeof contents[i] !== "string" && typeof contents[i] !== "number") {
                  throw new Error("* Any of the contents is neight `string` or `number`");
              }

              divElement = div.cloneNode(true);
              divElement.innerHTML = contents[i];
              fragment.appendChild(divElement);
          }

//* The function must remove all previous content from the DOM element provided
          res.innerHTML = "";
          res.appendChild(fragment);
  };
}

module.exports = solve;

