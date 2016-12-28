/* globals $ */

/*
Create a function that takes an id or DOM element and:

    If an id is provided, select the element
    Finds all elements with class button or content within the provided element
        Change the content of all .button elements with "hide"
    When a .button is clicked:
        Find the topmost .content element, that is before another .button and:
            If the .content is visible:
                Hide the .content
                Change the content of the .button to "show"
            If the .content is hidden:
                Show the .content
                Change the content of the .button to "hide"
            If there isn't a .content element after the clicked .button and before other .button, do nothing
    Throws if:
        The provided DOM element is non-existant
        The id is neither a string nor a DOM element

*/

function solve(){
  return function (selector) {
    var res,
        buttons;

    if (typeof selector !== "string" && !(selector instanceof HTMLElement)) {
      throw new Error("The id is neither a string nor a DOM element");
    }

    if ( typeof selector === "string") {
      res = document.getElementById(selector);

      if (res === null) {
        throw new Error("The provided DOM element is non-existant");
      }
    }

    buttons = res.getElementsByClassName("button");

    for (var i = 0, len = buttons.length; i < len; i+=1) {
      buttons[i].innerHTML = "hide";
      
      buttons[i].addEventListener("click", function(ev){
        var nextSibling = ev.target.nextElementSibling;

        if (ev.target.className === "button") {
          while (nextSibling.className !== "button" || nextSibling === null) {
            if (nextSibling.className === "content") {
              if (nextSibling.style.display === "none") {
                nextSibling.style.display = "";
                ev.target.innerHTML = "hide";
              } else {
                nextSibling.style.display = "none";
                ev.target.innerHTML = "show";
              }
              break;
            }

            nextSibling = nextSibling.nextElementSibling;
          }
        }

      }, true)
    }
    
  };
};

module.exports = solve;