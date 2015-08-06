var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output'),
    myText = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
outputBox.value = 'The text is as follows:\r\n\r\n' + myText + '\r\n\r\n';
function printResult() {
    var subS = firstNumber.value,
        result = subStrCount(myText, subS);
    outputBox.value += 'The text contains "' + subS + '" ' + result + ' times.\r\n';
}
function subStrCount(str, subS) {
    var count = 0,
        index = str.toLowerCase().indexOf(subS.toLowerCase());
    while (index >= 0) {
        count += 1;
        index = str.toLowerCase().indexOf(subS.toLowerCase(), index + 1);
    }
    return count;
}