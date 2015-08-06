/* Task Description */
/*
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number
 */


function printResult() {
    var outputBox = document.getElementById('output'),
        myArr = [2, 3, '5', '14'];

    outputBox.value += 'The array is:\r\n' + myArr.join(', ') + '\r\n\r\n';
    outputBox.value += 'The sum of the numbers is ' + sum(myArr)+'\r\n\r\n';
}

function sum(arr) {
    var sum = 0;

    if (!arr.length) {
        return null;
    }
    if (!arr) {
        throw new Error('The parameter is not passed!');
    }
    if (arr.some(function (item) {
            return isNaN(item);
        })) {
        throw new Error('An item is not a number!');
    }

    arr.forEach(function (item) {
        sum += +item;
    });
    return +sum;
}

//BG Coder Solution
function solve() {
    return function sum(arr) {
        var sum = 0;

        if (!arr.length) {
            return null;
        }
        if (!arr) {
            throw new Error('The parameter is not passed!');
        }
        if (arr.some(function (item) {
                return isNaN(item);
            })) {
            throw new Error('An item is not a number!');
        }

        arr.forEach(function (item) {
            sum += +item;
        });
        return +sum;
    }
}