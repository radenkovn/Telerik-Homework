function solve() {
    function validateCount(count) {
        if (typeof (count) === 'undefined') {
            throw new Error('You have not provided a count!');
        }
        if (count === null) {
            throw new Error('Your count is null!');
        }
        if (isNaN(count)) {
            throw new Error('Your count is not a number!!');
        }
        count = +count;
        if (typeof (count) !== 'number') {
            throw new Error('Your count is not a number!!');
        }
        if (typeof(count) === 'number' && count < 1) {
            throw new Error('The count cannot be a number less than 1!');
        }
        return count;
    }

    function validateSelector(selector) {
        if (typeof (selector) !== 'string') {
            throw new Error('Your selector must be a string!');
        }
    }

    return function (selector, count) {
        var i,
            $list;
        count = validateCount(count);
        validateSelector(selector);
        $list = $('\<ul />').addClass('items-list');
        for (i = 0; i < count; i += 1) {

            $list.append('\<li class="list-item">List item #'+i+'\</li>');
        }
        $(selector).append($list);
    };
}



module.exports = solve;