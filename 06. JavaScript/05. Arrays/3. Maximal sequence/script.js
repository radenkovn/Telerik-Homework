var outputBox = document.getElementById('output');
function printResult() {
    var i,
        j,
        number,
        rep,
        maxrep = 0,
        myArr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1],
        resultArr = [],
        len = myArr.length - 1;
    outputBox.value += 'The Array: \n' + myArr.join(', ') + '\r\n';
    for (i = 0; i < len; i += 1) {
        if (myArr[i] === myArr[i + 1]) {
            rep = 1;
            j = i;
            while (myArr[j] === myArr[j + 1] && j < len) {
                number = myArr[j];
                rep += 1;
                j += 1;
            }
            if (maxrep < rep) {
                maxrep = rep;
            }
            i = j;
        }
    }
    for (i = 0; i < maxrep; i += 1) {
        resultArr[i] = number;
    }
    outputBox.value += 'The max SEQ Array: \n' + resultArr.join(', ') + '\r\n';
}