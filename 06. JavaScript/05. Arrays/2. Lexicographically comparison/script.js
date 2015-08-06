var firstWord = document.getElementById('firstWord'),
    secondWord = document.getElementById('secondWord'),
    outputBox = document.getElementById('output');
function findGreater() {
    var i,
        len,
        result = 0,
        a = firstWord.value,
        b = secondWord.value;
    len = Math.min(a.length, b.length);
    for (i = 0; i < len; i += 1) {
        if (a[i].toLowerCase() > b[i].toLowerCase()) {
            result = 1;
            break;
        }
        else if (a[i].toLowerCase() < b[i].toLowerCase()) {
            result = -1;
            break;
        }
    }
    switch (result) {
        case 0:
            outputBox.value += 'The words are lexicographically the same and\r\n';
            if (a.length > b.length) {
                outputBox.value += b + ' is shorter than ' + a + '\r\n';
            }
            else if (a.length < b.length) {
                outputBox.value += a + ' is shorter than ' + b + '\r\n';
            }
            else {
                outputBox.value += 'they have the same length\r\n';
            }
            break;
        case 1:
            outputBox.value += b + ' is before ' + a + '\r\n';
            break;
        case -1:
            outputBox.value += a + ' is before ' + b + '\r\n';
            break;
    }
}