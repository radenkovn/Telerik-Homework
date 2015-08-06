var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function numbersToN() {
    var i,
        result='',
        n = +firstNumber.value;
    for (i = 1; i <= n; i += 1) {
        result += i + ' ';
    }
    outputBox.value += result + '\r\n';
}

