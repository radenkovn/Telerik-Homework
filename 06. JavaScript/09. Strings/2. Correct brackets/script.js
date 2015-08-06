var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function printResult() {
    var normal = firstNumber.value,
        result = correctBrackets(normal);
    outputBox.value += 'The brackets are correct -  ' + result + '\r\n';
}
function correctBrackets(str) {
    var left = str.indexOf('('),
        right = str.indexOf(')'),
        leftLast,
        counter = 0;
    if (left < 0 && right < 0) {
        return true;
    }
    if (left > right) {
        return false;
    }
    leftLast = str.lastIndexOf('(');
    while (left <= leftLast && left >= 0) {
        left = str.indexOf('(', left + 1);
        counter += 1;
        if (right < leftLast && right >= 0) {
            counter -= 1;
            right = str.indexOf(')', right + 1);
        }
    }
    if (counter <= 0) {
        return false;
    }
    while (right >= 0) {
        counter -= 1;
        right = str.indexOf(')', right + 1);
    }
    return !(counter);
}