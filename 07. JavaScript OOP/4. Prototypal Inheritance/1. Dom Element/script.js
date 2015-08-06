var domElement = (function () {
    var domElement = {};
    Object.defineProperty(domElement, 'init', {
        value: function (type) {
            this.type = type;
            this.attributes = {};
            this.children = [];
            return this;
        }
    });

    Object.defineProperty(domElement, 'attributes', {
        get: function () {
            return this._attributes;
        },
        set: function (value) {
            this._attributes = value;
        }
    });
    Object.defineProperty(domElement, 'content', {
        get: function () {
            if (typeof (this._content) !== 'undefined') {
                return this._content;
            }
            return '';
        },
        set: function (value) {
            if (this.children.length === 0) {
                this._content = value;
            }
        }
    });

    Object.defineProperty(domElement, 'parent', {
        get: function () {
            return this._parent;
        },
        set: function (value) {
            this._parent = value;
        }
    });

    Object.defineProperty(domElement, 'children', {
        get: function () {
            return this._children;
        },
        set: function (value) {
            this._children = value;
        }
    });

    Object.defineProperty(domElement, 'innerHTML', {
        get: function () {
            return '<' + this.type + convertAttributesToHTML(this.attributes) + '>' + this.content + convertChildrenToHTML(this.children) + '</' + this.type + '>';
        }
    });

    Object.defineProperty(domElement, 'type', {
        get: function () {
            return this._type;
        },
        set: function (value) {
            testTypeName(value);
            this._type = value;
        }
    });

    Object.defineProperty(domElement, 'appendChild', {
        value: function (childElement) {
            //if (typeof (childElement) === 'object') {
            childElement.parent = this;
            this.children.push(childElement);
            /*}
             if (typeof (childElement) === 'string') {
             if (typeof (this.content) !== 'undefined') {
             this.content += childElement;
             } else {
             this.content = childElement;
             }
             }*/
            return this;
        }
    });

    Object.defineProperty(domElement, 'addAttribute', {
        value: function (name, value) {
            testAttributeName(name);
            this.attributes[name] = value;
            this.attributes = sortObject(this.attributes);
            return this;
        }
    });

    Object.defineProperty(domElement, 'removeAttribute', {
        value: function (attribute) {
            if (typeof(this.attributes[attribute]) === 'undefined') {
                throw new Error('Non existent attribute!');
            }
            delete this.attributes[attribute];
            return this;
        }
    });

    function testTypeName(type) {
        var reg = /^[a-z0-9]+$/i;
        if (!reg.test(type)) {
            throw new Error('Invalid name!');
        }
        if (!(typeof(type) === 'string')) {
            throw new Error('Invalid name!');
        }
    }

    function testAttributeName(name) {
        var reg = /^[a-z0-9-]+$/i;
        if (!reg.test(name)) {
            throw new Error('Invalid name!');
        }
        if (!(typeof(name) === 'string')) {
            throw new Error('Invalid name!');
        }
    }

    //Taken from Internet
    function sortObject(obj) {
        var sorted = {},
            key,
            keyArray = [];

        for (key in obj) {
            if (obj.hasOwnProperty(key)) {
                keyArray.push(key);
            }
        }

        keyArray = keyArray.sort(function (a, b) {
            return a > b;
        });

        for (key = 0; key < keyArray.length; key++) {
            sorted[keyArray[key]] = obj[keyArray[key]];
        }
        return sorted;
    }

    function convertChildrenToHTML(children) {
        var child,
            result = '';
        if (children.length > 0) {
            for (child in children) {
                if (typeof (children[child]) === 'object') {
                    result += (children[child].innerHTML);
                } else {
                    result += children[child];
                }
            }
        }
        return result;
    }

    function convertAttributesToHTML(attributes) {
        var attribute,
            result;
        if (typeof (attributes) !== 'undefined') {
            result = ' ';
            for (attribute in attributes) {
                result += attribute + '="' + attributes[attribute] + '" ';
            }
            result = result.substring(0, result.length - 1);
        }
        return result;
    }

    return domElement;
}());

var meta = Object.create(domElement)
        .init('meta')
        .addAttribute('charset', 'utf-8'),
    head = Object.create(domElement)
        .init('head')
        .appendChild(meta),
    div = Object.create(domElement)
        .init('div')
        .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
        .init('body')
        .appendChild(div)
        .addAttribute('id', 'myid')
        .addAttribute('bgcolor', '#012345'),
    root = Object.create(domElement)
        .init('html')
        .appendChild(head)
        .appendChild(body);

console.log(root.innerHTML);