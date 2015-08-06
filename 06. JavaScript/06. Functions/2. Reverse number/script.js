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
        result = reverseDigits(numStr);
        outputBox.value += result + '\r\n';
    }
}
function reverseDigits(number) {
    var i,
        len,
        result = '',
        numStr = number+'';
    len = numStr.length;
    for (i = len - 1; i >= 0; i -= 1) {
        result += numStr[i];
    }
    result = +result;
    return result;
}





