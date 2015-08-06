var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    thirdNumber = document.getElementById('thirdNumber'),
    fourthNumber = document.getElementById('fourthNumber'),
    fifthNumber = document.getElementById('fifthNumber'),
    outputBox = document.getElementById('output');
function biggestFive() {
    var max,
        a = +firstNumber.value,
        b = +secondNumber.value,
        c = +thirdNumber.value,
        d = +fourthNumber.value,
        e = +fifthNumber.value;
    max = a;
    if (max <= b) {
        max = b;
        if (max <= c) {
            max = c;
        }
        if (max <= d) {
            max = d;
        }
        if (max <= e) {
            max = e;
        }
    }
    else {
        if (max <= c) {
            max = c;
        }
        if (max <= d) {
            max = d;
        }
        if (max <= e) {
            max = e;
        }
    }


    outputBox.value += 'The max is ' + max + '\r\n\r\n';
}