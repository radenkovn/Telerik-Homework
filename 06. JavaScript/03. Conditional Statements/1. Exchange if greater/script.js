var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    outputBox = document.getElementById('output');
function findGreater() {
    var temp,
        a = +firstNumber.value,
        b = +secondNumber.value;
    if (a > b) {
        temp = b;
        b = a;
        a = temp;
    }
    outputBox.value += 'The numbers are: a=' + a + ", b=" + b + ' !\r\n';
    outputBox.value += a + ' ' + b + '\r\n';
}


