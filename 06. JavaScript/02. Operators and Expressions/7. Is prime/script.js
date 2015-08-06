var myInput = document.getElementById('inputBox'),
    outputBox = document.getElementById('output');
function findIfOdd() {
    var i,
        max,
        isPrime = true,
        input = myInput.value;
    if (input > 100) {
        outputBox.value += 'The number is greater than 100! \r\n';
    }
    else {
        if (input > 1) {
            max = Math.sqrt(input) | 0;
            for (i = 2; i <= max; i += 1) {
                if (!(input % i)) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                outputBox.value += 'The number is prime! \r\n';
            }
            else {
                outputBox.value += 'The number is NOT prime! \r\n';
            }
        }
        else {
            outputBox.value += 'The number is NOT prime! \r\n';
        }
    }
}

