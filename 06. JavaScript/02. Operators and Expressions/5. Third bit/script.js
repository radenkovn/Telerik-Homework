var myInput = document.getElementById('inputBox'),
    outputBox = document.getElementById('output');
function findIfDiv() {
    var input = myInput.value,
        result = (input >> 3) & 1;
    outputBox.value += 'The third bit is: ' + result + '\r\n';
}