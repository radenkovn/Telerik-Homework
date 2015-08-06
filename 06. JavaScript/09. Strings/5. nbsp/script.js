var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function printResult() {
    var normal = firstNumber.value,
        result = replaceNbsp(normal);
    outputBox.value += 'The normal string is: \r\n\r\n' + normal + '\r\n\r\n';
    outputBox.value += 'The replacedNBSP string is: \r\n\r\n' + result + '\r\n';
}
function replaceNbsp(str) {
    var index = str.indexOf('&nbsp;');
    while (index >= 0) {
        str = str.replace('&nbsp;', ' ');
        index = str.indexOf('&nbsp;', index + 1);
    }
    return str;
}