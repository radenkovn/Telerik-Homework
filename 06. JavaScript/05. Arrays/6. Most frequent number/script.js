var outputBox = document.getElementById('output');
function printResult() {
    var i,
        j,
        number,
        rep,
        maxrep = 0,
        myArr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
        len = myArr.length;
    outputBox.value += 'The Array: \n' + myArr.join(', ') + '\r\n';
    for (i = 0; i < len; i += 1) {
        if (myArr[i] != 'a') {
            rep = 1;
            for (j = i + 1; j < len; j += 1) {
                if (myArr[i] === myArr[j]) {
                    rep += 1;
                    myArr[j] = 'a';
                }
            }
            if (rep > maxrep) {
                maxrep = rep;
                number = myArr[i];
            }
        }
    }
    outputBox.value += number + ' (' + maxrep + ' times)' + '\r\n';
}