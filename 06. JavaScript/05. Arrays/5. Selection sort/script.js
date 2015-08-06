var outputBox = document.getElementById('output');
function printResult() {
    var i,
        j,
        min,
        myArr = [3, 2, 3, 4, 2, 2, 4],
        resultArr = [],
        len = myArr.length;
    outputBox.value += 'The Array: \n' + myArr.join(', ') + '\r\n';
    for (j = 0; j < len; j += 1) {
        min=Number.MAX_VALUE;
        for (i = 1; i < len; i += 1) {
            if (min >= myArr[i] && myArr[i] != 'a') {
                min = myArr[i];
            }
        }
        myArr[myArr.indexOf(min)] = 'a';
        resultArr[j] = min;
    }
    outputBox.value += 'The sorted Array: \n' + resultArr.join(', ') + '\r\n';
}