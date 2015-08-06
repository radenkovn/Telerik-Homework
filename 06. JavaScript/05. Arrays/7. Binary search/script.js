var outputBox = document.getElementById('output'),
    numberValue = document.getElementById('number'),
    myArr = [1, 2, 3, 4, 5, 5, 6, 8, 9, 15, 20];

outputBox.value += 'The Array: \n' + myArr.join(', ') + '\r\n';

function printResult() {
    var min,
        mid,
        max,
        number = +numberValue.value,
        found = false,
        len = myArr.length;
    min = 0;
    max = len;
    while (min != max - 1) {
        mid = min + ((max - min) / 2) | 0;
        if (number === myArr[mid]) {
            outputBox.value += number + ' has been found at the ' + mid + ' index !\r\n';
            found = true;
            break;
        }
        else if (number < myArr[mid]) {
            max = mid;
        }
        else if (number > myArr[mid]) {
            min = mid;
        }
    }
    if (!found) {
        outputBox.value += number + ' has not been found in the array\r\n';
    }

}


