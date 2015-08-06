var outputBox = document.getElementById('output');
function printResult() {
    var i,
        j,
        number,
        rep,
        index,
        maxrep = 0,
        myArr = [3, 2, 3, 4, 2, 2, 4],
        resultArr = [],
        len = myArr.length - 1;
    outputBox.value += 'The Array: \n' + myArr.join(', ') + '\r\n';
    for (i = 0; i < len; i += 1) {
        if (myArr[i] < myArr[i + 1]) {
            rep = 1;
            j = i;
            while (myArr[j] < myArr[j + 1] && j < len) {
                number = myArr[j];
                rep += 1;
                j += 1;
            }
            if (maxrep < rep) {
                maxrep = rep;
                index = j - maxrep + 1;
            }
            i = j;
        }
    }
    j = 0;
    for (i = index; i < index + maxrep; i += 1) {
        resultArr[j] = myArr[i];
        j += 1;
    }
    outputBox.value += 'The max incr SEQ Array: \n' + resultArr.join(', ') + '\r\n';
}