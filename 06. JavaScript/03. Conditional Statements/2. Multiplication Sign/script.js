var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    thirdNumber = document.getElementById('thirdNumber'),
    outputBox = document.getElementById('output');
function showSign() {
    var result,
        a = +firstNumber.value,
        b = +secondNumber.value,
        c = +thirdNumber.value;
    if (a === 0 || b === 0 || c === 0) {
        result = "0";
    }
    else if (a > 0) {
        if ((b < 0 && c < 0)||(b>0 && c>0)) {
            result = "+";
        }
        else {
            result = "-";
        }
    }
    else if (a < 0) {
        if (b < 0 && c < 0 || (b>0 && c>0)) {
            result = "-";
        }
        else {
            result = "+";
        }
    }
    outputBox.value += 'The numbers sign of their multiplication is: ' + result + '\r\n\r\n';
}