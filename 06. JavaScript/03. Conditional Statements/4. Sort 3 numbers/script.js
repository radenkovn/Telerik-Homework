var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    thirdNumber = document.getElementById('thirdNumber'),
    outputBox = document.getElementById('output');
function sortThree() {
    var temp,
        a = +firstNumber.value,
        b = +secondNumber.value,
        c = +thirdNumber.value;
    if (a <= b) {
        temp = b;
        b = a;
        a = temp;
        if (b <= c) {
            temp = b;
            b = c;
            c = temp;
            if (a <= b) {
                temp = b;
                b = a;
                a = temp;
            }
        }
    }
    else if (b <= c) {
        temp = b;
        b = c;
        c = temp;
        if (a <= b) {
            temp = b;
            b = a;
            a = temp;
        }
    }
    outputBox.value += 'The sorted numbers are: ' + a + ' ' + b + ' ' + c + '\r\n\r\n';
}