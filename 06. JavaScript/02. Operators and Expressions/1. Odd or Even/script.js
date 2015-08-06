var myInput = document.getElementById('inputBox'),
    outputBox = document.getElementById('output');
function findIfOdd() {
    var input = myInput.value;
    if (input % 2) {
        outputBox.value += 'The number is ODD \r\n';
    } else {
        outputBox.value += 'The number is EVEN \r\n';
    }
}