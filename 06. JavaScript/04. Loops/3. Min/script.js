var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    thirdNumber = document.getElementById('thirdNumber'),
    fourthNumber = document.getElementById('fourthNumber'),
    fifthNumber = document.getElementById('fifthNumber'),
    outputBox = document.getElementById('output');
function findSeq() {
    var min,
        max,
        myArr,
        len,
        i,
        a = +firstNumber.value,
        b = +secondNumber.value,
        c = +thirdNumber.value,
        d = +fourthNumber.value,
        e = +fifthNumber.value;
    myArr = [a, b, c, d, e];
    len = myArr.length;
    min = myArr[0];
    max = myArr[0];
    for (i = 1; i < len; i += 1) {
        if (min >= myArr[i]) {
            min = myArr[i];
        }
        if (max <= myArr[i]) {
            max = myArr[i];
        }
    }
    outputBox.value += 'The min is ' + min + '\r\n';
    outputBox.value += 'The max is ' + max + '\r\n\r\n';
}