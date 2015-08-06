function solve() {
    return function result(selector) {
        var i,
            j,
            currentContent,
            buttonBeforeContent,
            nextContent,
            len;
        if (typeof (selector) !== 'string' && typeof (selector) !== 'object') {
            throw new Error('Your selector is neither a string nor an DOM element!');
        }
        if (typeof (selector) === 'string' && document.getElementById(selector) === null) {
            throw new Error('The ID does not select any dom element!');
        }
        if (typeof(selector) === 'object' && typeof (selector.tagName === 'undefined')) {
            throw new Error('You have not provided a correct DOM element!');
        }
        var buttonsContents = document.querySelectorAll('.button,.content');
        selector = document.getElementById(selector);
        if (buttonsContents.length > 0) {
            for (i = 0, len = buttonsContents.length; i < len; i += 1) {
                buttonsContents[i].innerHTML = 'hide';
            }
            selector.addEventListener('click', function (ev) {
                var index,
                    currentButton = ev.target;
                if (currentButton.className.indexOf('button') >= 0) {
                    index = [].indexOf.call(buttonsContents, currentButton);
                    for (i = index, len = buttonsContents.length; i < len; i += 1) {
                        if (buttonsContents[i].className.indexOf('content') >= 0) {
                            currentContent = buttonsContents[i];
                            if (currentContent.nextElementSibling.className.indexOf('button') >= 0) {
                                if (currentContent.style.display != 'none') {
                                    currentContent.style.display = 'none';
                                    currentButton.innerHTML = 'show';
                                    break;
                                } else {
                                    currentContent.style.display = '';
                                    currentButton.innerHTML = 'hide';
                                    break;
                                }
                            }
                        }
                    }
                }
            }, false);
        }
    };
}

module.exports = solve;