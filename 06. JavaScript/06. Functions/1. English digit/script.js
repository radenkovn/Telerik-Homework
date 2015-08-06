var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function printResult() {
    var result,
        numStr = firstNumber.value;
    if (isNaN(numStr)) {
        outputBox.value += 'not a number\r\n';
    }
    else {
        numStr = +numStr;
        result = digitWord(numStr);
        outputBox.value += result + '\r\n';
    }
}
function digitWord(number) {
    var result = '',
        digit = (number % 10) | 0;
    switch (digit) {
        case 0:
            result += 'zero\r\n';
            break;
        case 1:
            result += 'one\r\n';
            break;
        case 2:
            result += 'two\r\n';
            break;
        case 3:
            result += 'three\r\n';
            break;
        case 4:
            result += 'four\r\n';
            break;
        case 5:
            result += 'five\r\n';
            break;
        case 6:
            result += 'six\r\n';
            break;
        case 7:
            result += 'seven\r\n';
            break;
        case 8:
            result += 'eight\r\n';
            break;
        case 9:
            result += 'nine\r\n';
            break;
    }
    return result;
}