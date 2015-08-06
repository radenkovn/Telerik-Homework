/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function printResult() {
    var result,
        start = 3,
        end = 15,
        outputBox = document.getElementById('output');
    result = findPrimes(start, end).join(', ');
    outputBox.value += 'The prime numbers between ' + start + ' and ' + end + ' are:\r\n\r\n';
    outputBox.value += result + '\r\n\r\n';
}

function findPrimes(start, end) {
    var i,
        isPrime,
        maxDiv,
        number,
        result = [];
    if (isNaN(start) || isNaN(end)) {
        throw new Error('The numbers are not convertible to Number');
    }
    if (arguments[0] === undefined || arguments[1] === undefined) {
        throw new Error('One of the range params is missing');
    }
    start = +start;
    end = +end;
    start = start >= 2 ? start : 2;
    for (number = start; number <= end; number += 1) {
        isPrime = true;
        maxDiv = Math.sqrt(number) + 1;
        for (i = 2; i < maxDiv; i += 1) {
            if (!(number % i)) {
                isPrime = false;
                break;
            }
        }
        if ((isPrime || number === 2)) {
            result.push(number);
        }
    }
    return result;
}

//BG coder solution
function solve() {
    return function findPrimes(start, end) {
        var i,
            isPrime,
            maxDiv,
            number,
            result = [];
        if (isNaN(start) || isNaN(end)) {
            throw new Error('The numbers are not convertible to Number');
        }
        if (arguments[0] === undefined || arguments[1] === undefined) {
            throw new Error('One of the range params is missing');
        }
        start = +start;
        end = +end;
        start = start >= 2 ? start : 2;
        for (number = start; number <= end; number += 1) {
            isPrime = true;
            maxDiv = Math.sqrt(number) + 1;
            for (i = 2; i < maxDiv; i += 1) {
                if (!(number % i)) {
                    isPrime = false;
                    break;
                }
            }
            if ((isPrime || number === 2)) {
                result.push(number);
            }
        }
        return result;
    }
}
