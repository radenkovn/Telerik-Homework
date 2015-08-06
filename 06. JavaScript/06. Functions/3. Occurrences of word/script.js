var searchWord = document.getElementById('searchWord'),
    outputBox = document.getElementById('output'),
    text = outputBox.value;
function printResult() {
    var result1,
        result2,
        result3,
        search = searchWord.value;
    result1 = searchForMe(text, search);
    result2 = searchForMe(text, search, true);
    result3 = searchForMe(text, search, false);
    outputBox.value = 'No third variable: ' + result1 +'\r\n';
    outputBox.value += 'Case sensitive: ' + result2 +'\r\n';
    outputBox.value += 'Case insensitive: ' + result3 +'\r\n';
}
function searchForMe(text, word, caseSensitive) {
    var i,
        counter = 0,
        arr = text.match(/\w+/g),
        len = arr.length;
    switch (arguments.length) {
        case 2:
            for (i = 0; i < len; i += 1) {
                if (word === arr[i]) {
                    counter += 1;
                }
            }
            break;
        case 3:
            if (caseSensitive) {
                for (i = 0; i < len; i += 1) {
                    if (word === arr[i]) {
                        counter += 1;
                    }
                }
            }
            else {
                for (i = 0; i < len; i += 1) {
                    if (word.toLowerCase() === arr[i].toLowerCase()) {
                        counter += 1;
                    }
                }
            }
            break;
    }
    return counter;

}