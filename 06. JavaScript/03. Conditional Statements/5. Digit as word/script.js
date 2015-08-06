var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function digitWord() {
    var numStr = firstNumber.value;
    if (isNaN(numStr) || (numStr.length > 1)) {
        outputBox.value += 'not a digit\r\n';
    }
    else {
        switch (numStr) {
            case "0":
                outputBox.value += 'zero\r\n';
                break;
            case "1":
                outputBox.value += 'one\r\n';
                break;
            case "2":
                outputBox.value += 'two\r\n';
                break;
            case "3":
                outputBox.value += 'three\r\n';
                break;
            case "4":
                outputBox.value += 'four\r\n';
                break;
            case "5":
                outputBox.value += 'five\r\n';
                break;
            case "6":
                outputBox.value += 'six\r\n';
                break;
            case "7":
                outputBox.value += 'seven\r\n';
                break;
            case "8":
                outputBox.value += 'eight\r\n';
                break;
            case "9":
                outputBox.value += 'nine\r\n';
                break;
        }
    }
}