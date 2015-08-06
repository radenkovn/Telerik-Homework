var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function findNonDiv() {
    var i,
        result='';
        n = +firstNumber.value;
    for (i = 1; i <= n; i += 1) {
        if (!!(i % 35)) {
            result += i + ' ';
        }
    }
    outputBox.value += result + '\r\n';
}