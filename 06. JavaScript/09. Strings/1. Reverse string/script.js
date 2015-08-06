var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function printResult() {
    var normal = firstNumber.value,
        result = reverseStr(normal);
    outputBox.value += 'The reversed string is:  ' + result + '\r\n';
}
function reverseStr(str) {
    var i,
        result = '',
        len = str.length;
    for (i = len - 1; i >= 0; i -= 1) {
        result += str[i];
    }
    return result;
}
