module.exports = function () {
    return function result(element, contents) {
        var fragment = document.createDocumentFragment();
        if (typeof (element) === 'undefined') {
            throw new Error('Your ID/Element is missing!');
        }
        if (typeof (contents) === 'undefined') {
            throw new Error('Your contents array is missing!');
        }
        if (!(element) || !(contents)) {
            throw new Error('Your ID/Element or contents array are missing!');
        }
        if (typeof (element) !== 'string' && typeof (element) !== 'object') {
            throw new Error('The provided parameter is neither a string nor a dom element!');
        }
        if (typeof (element) === 'object' && typeof(element.tagName) === 'undefined') {
            throw  new Error('The provided parameter is not a dom element!');
        }
        if (typeof (element) === 'string' && document.getElementById(element) === null) {
            throw new Error('There was no element found with such an ID!');
        }
        if (!Array.isArray(contents)) {
            throw new Error('Your contents parameter is not an array!');
        }
        if (contents.length === 0) {
            //throw new Error('You have provided an empty array for contents!');
        }
        if (typeof (element) === 'string') {
            element = document.getElementById(element);
        }
        contents.forEach(function (item) {
            if (typeof (item) !== 'string' && typeof(item) !== 'number') {
                throw new Error('The type of an item you have provided is not a string or number!');
            }
        });
        element.innerHTML = '';
        contents.forEach(function (item) {
            fragment.innerHTML += '\<div>' + item + '\</div>';
        });
        if (contents.length > 0) {
            element.innerHTML += fragment.innerHTML;
        }
    }
};
