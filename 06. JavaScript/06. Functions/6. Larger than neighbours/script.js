var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output'),
    arr = [1, 2, 3, 1, 2, 1, 0];

outputBox.value += 'The array: ' + arr.join(', ') + '\r\n\r\n';
function printResult() {
    var result,
        myNum = +firstNumber.value;
    result = checkIfLarger(arr, myNum);
    outputBox.value += result + '\r\n';
}
function checkIfLarger(array, i) {
    var result = false,
        number = array[i];
    if (neighboursExist(array, i)) {
        result = (array[i - 1] < number && number > array[i + 1]);
    }
    return result;
}
function neighboursExist(array, i) {
    return (i > 1 && i < array.length - 1);
}