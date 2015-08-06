var outputBox = document.getElementById('output');
function printResult() {
    var i,
        myArr = [],
        len = 20;
    for (i = 0; i < len; i++) {
        myArr[i] = i * 5;
    }
    outputBox.value += 'The Array: \n' + myArr.join(', ') + '\r\n';
}