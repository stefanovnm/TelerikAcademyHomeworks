/* globals module, document, HTMLElement, console */

function solve(){
    return function(selector, isCaseSensitive){

        var selected; 

        //Selecting

        selected = document.querySelector(selector);
        /*
        if (selector[0] === '#') {
            selected = document.getElementById(selector.substr(1));
        } else if (selector[0] === '.') {
            selected = document.getElementsByClassName(selector.substr(1));
        } else {
            selected = document.getElementsByTagName(selector);
        } //TODO nested selector*/

        selected.className = 'items-control';

        //Adding elements

        var addingElements = document.createElement('div');
        addingElements.className = 'add-controls';

        var textToAdd = document.createElement('label');
        textToAdd.innerHTML = 'Enter text';
        addingElements.appendChild(textToAdd);

        var inputToAdd = document.createElement('input');
        addingElements.appendChild(inputToAdd);

        var buttonToAdd = document.createElement('button');
        buttonToAdd.className = 'button';
        buttonToAdd.innerHTML = 'Add';
        buttonToAdd.addEventListener('click', onButtonClick);

        addingElements.appendChild(buttonToAdd);

        selected.appendChild(addingElements);

        function onButtonClick() {
            var itemsListSelected = document.getElementsByClassName('items-list');
            itemsListSelected=itemsListSelected[0];

            var listItem = document.createElement('div');
            listItem.className = 'list-item';

            var labelForListItem = document.createElement('label');
            labelForListItem.innerHTML = inputToAdd.value;

            var buttonForListItem = document.createElement('button');
            buttonForListItem.className = 'button';
            buttonForListItem.innerHTML = 'X';

            buttonForListItem.addEventListener('click', function(){
                var item = this.parentNode;
                item.parentNode.removeChild(item);
            });

            listItem.appendChild(buttonForListItem);
            listItem.appendChild(labelForListItem);

            itemsListSelected.appendChild(listItem);
        }


        //Search elements

        var searchElements = document.createElement('div');
        searchElements.className = 'search-controls';

        var labelToAddInSearch = document.createElement('label');
        labelToAddInSearch.innerHTML = 'Search:';
        searchElements.appendChild(labelToAddInSearch);

        var inputToAddInSearch = document.createElement('input');
        searchElements.appendChild(inputToAddInSearch);

        inputToAddInSearch.addEventListener('keyup',function (e) {
            var searchedText = inputToAddInSearch.value;
            //console.log(searchedText);

            var selectedResultElements = document.getElementsByClassName('list-item');
            //console.log(selectedResultElements.length);

            for (var i = 0, len = selectedResultElements.length; i < len; i+=1) {
                var selectedLabel = selectedResultElements[i].getElementsByTagName('label');
                var textToSearch = selectedLabel[0].innerHTML;
                
                if (!isCaseSensitive) {
                    textToSearch = textToSearch.toLowerCase();
                    searchedText = searchedText.toLowerCase();
                }

                if (textToSearch.indexOf(searchedText) === -1) {
                    selectedResultElements[i].style.display = 'none';
                } else {
                    selectedResultElements[i].style.display = 'block';
                }
                
            }


        });

        selected.appendChild(searchElements);

        //Result elements

        var resultElements = document.createElement('div');
        resultElements.className = 'result-controls';

        var itemList = document.createElement('div');
        itemList.className = 'items-list';
        resultElements.appendChild(itemList);

        selected.appendChild(resultElements);

    };
}
module.exports = solve;