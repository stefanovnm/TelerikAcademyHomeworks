/* globals document, window, console */

function solve() {
    return function(selector, initialSuggestions) {


        var root = document.querySelector(selector);



        var button = document.getElementsByClassName("btn-add")[0];
        button.addEventListener('click', onButtonAdd);

        var suggestionList = document.getElementsByClassName("suggestions-list")[0];
        var input = document.getElementsByClassName("tb-pattern")[0];
        var suggestions = document.getElementsByClassName('suggestion');

        //first fill
        if (initialSuggestions) {
            
            for (var j = 0, lengthInit = initialSuggestions.length; j < lengthInit; j+=1) {

                if (!checkForExisting(initialSuggestions[j])) {
                    var initSuggestion = document.createElement('li');
                    var linkToAdd = document.createElement('a');
                    linkToAdd.className = "suggestion";
                    linkToAdd.href = '#';
                    linkToAdd.innerText = initialSuggestions[j];
                    initSuggestion.appendChild(linkToAdd);
                    suggestionList.appendChild(initSuggestion);
                }
            }
        }

        function initialHideSuggestions() {
            for (var k = 0,lengths = suggestions.length; k < lengths; k+=1) {
                if (input.value === '') {
                    suggestions[k].style.display = 'none';
                }
            }
        }
        initialHideSuggestions();

        function checkForExisting(toAdd) {
            var sugg = document.getElementsByClassName('suggestion');
            for (var i = 0, len = sugg.length; i < len; i+=1) {
            if (sugg[i].innerText.toLowerCase() === toAdd.toLowerCase()) {
                    return true;
                }
            }
            return false;
        };

        function onButtonAdd(){
            inputValue = input.value;
            if (!checkForExisting(inputValue)) {
                var suggestion = document.createElement('li');
                var linkToAdd = document.createElement('a');
                linkToAdd.className = "suggestion";
                linkToAdd.href = '#';
                linkToAdd.innerText = inputValue;
                suggestion.appendChild(linkToAdd);
                suggestionList.appendChild(suggestion);
            }
        };

        function showSuggestions() {
            searchedText = input.value;

            for (var k = 0,lengths = suggestions.length; k < lengths; k+=1) {
                if (suggestions[k].innerHTML.toLowerCase().indexOf(searchedText.toLowerCase()) === -1) {
                    suggestions[k].style.display = 'none';
                } else {
                    suggestions[k].style.display = 'block';
                }

                suggestions[k].addEventListener('click', function () {
                    var item = this.innerHTML;
                    input.value = item;
                    showSuggestions();
                });
            }

            if (searchedText === '') {
                initialHideSuggestions();
            }
        };

        input.addEventListener('keyup', showSuggestions);
    };
}

module.exports = solve;


//["Apples", "Oranges", "Kiwis", "Watermelons", "Peaches"]
//solve()("#root", ["Apples", "Oranges", "Kiwis", "Watermelons", "Peaches"]);