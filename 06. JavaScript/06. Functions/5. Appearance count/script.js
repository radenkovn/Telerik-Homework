var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output'),
    arr = [1, 1, 1, 1, 2, 2, 2, 3, 3, 4];

outputBox.value += 'The array: ' + arr.join(', ') + '\r\n\r\n';
function printResult() {
    var result,
        testResult,
        myNum = +firstNumber.value;
    result = countInArr(arr, myNum);
    testResult = testing(myNum);
    outputBox.value += 'There are ' + result + ' ' + myNum + '-s in the array (test result : ' + testResult+ ' )\r\n\r\n';
}
function countInArr(array, number) {
    var i,
        len,
        count = 0;
    for (i = 0, len = array.length; i < len; i += 1) {
        if (array[i] === number) {
            count += 1;
        }
    }
    return count;
}
// I'm not really sure what I'm supposed to do here,
// so I just entered what the result should be according to my array
function testing(number) {
    switch (number) {
        case 1:
            return 4;
        case 2:
            return 3;
        case 3:
            return 2;
        case 4:
            return 1;
        default:
            return 0;
    }
}