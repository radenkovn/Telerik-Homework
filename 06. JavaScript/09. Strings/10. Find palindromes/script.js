var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function printResult() {
    var normal = firstNumber.value,
        result = findPalindromes(normal);
    outputBox.value += 'The text is:\r\n' + normal + '\r\n\r\n';
    outputBox.value += 'The palindromes in this text are:\r\n\r\n';
    result.forEach(function (palindrom) {
        outputBox.value += palindrom + '\r\n';
    })
}
function findPalindromes(str) {
    var i,
        j,
        word,
        wordLen,
        len,
        isPalin = true,
        index = 0,
        result = [],
        all = str.match(/\w+/g);
    for (i = 0, len = all.length; i < len; i += 1) {
        word = all[i];
        wordLen = word.length;
        if (!(wordLen % 2)) {
            for (j = 0; j <= wordLen / 2; j += 1) {
                if (word[j] != word[wordLen - j - 1]) {
                    isPalin = false;
                    break;
                }
                isPalin = true;
            }
            if (isPalin) {
                result[index] = word;
                index += 1;
            }
        }
        else {
            for (j = 0; j < (wordLen / 2) + 1; j += 1) {
                if (word[j] != word[wordLen - j - 1]) {
                    isPalin = false;
                    break;
                }
                isPalin = true;
            }
            if (isPalin) {
                result[index] = word;
                index += 1;
            }
        }
    }
    return result;

}