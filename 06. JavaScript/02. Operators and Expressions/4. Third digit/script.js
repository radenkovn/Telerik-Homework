var myInput = document.getElementById('inputBox'),
    outputBox = document.getElementById('output');
function findIfDiv() {
    var input = myInput.value,
        result = ((input / 100) | 0) % 10 == 7;
    if (result) {
        outputBox.value += 'The third integer is 7 (' + result + ')\r\n';
    } else {
        outputBox.value += 'The third integer is NOT 7 (' + result + ')\r\n';
    }
}