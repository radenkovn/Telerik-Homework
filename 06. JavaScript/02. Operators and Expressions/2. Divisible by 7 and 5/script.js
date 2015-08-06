var myInput = document.getElementById('inputBox'),
    outputBox = document.getElementById('output');
function findIfDiv() {
    var input = myInput.value,
        checker = !(input % 35);
    if (checker) {
        outputBox.value += 'The number is divisible (' + checker + ')\r\n';
    } else {
        outputBox.value += 'The number is NOT divisible (' + checker + ')\r\n';
    }
}

