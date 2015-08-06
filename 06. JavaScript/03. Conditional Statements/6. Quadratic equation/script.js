var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    thirdNumber = document.getElementById('thirdNumber'),
    outputBox = document.getElementById('output');
function solveQuadr() {
    var d,
        a = +firstNumber.value,
        b = +secondNumber.value,
        c = +thirdNumber.value;
    d = b * b - (4 * a * c);
    if (d < 0) {
        outputBox.value += 'no real roots\r\n\r\n';
    }
    else if (d === 0) {
        outputBox.value += 'x1=x2=' + (-b / (2 * a)) + '\r\n\r\n';
    }
    else {
        outputBox.value += 'x1=' + ((-b - Math.sqrt(d)) / (2 * a)) + '; x2=' + ((-b + Math.sqrt(d)) / (2 * a)) + '\r\n\r\n';
    }

}