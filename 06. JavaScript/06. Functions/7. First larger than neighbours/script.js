var outputBox = document.getElementById('output'),
    arr1 = [1, 2, 3, 1, 2, 1, 0],
    arr2 = [1, 2, 3, 4, 5, 6, 7];

outputBox.value += 'Array 1: ' + arr1.join(', ') + '\r\n\r\n';
outputBox.value += 'Array 1: ' + arr2.join(', ') + '\r\n\r\n';
function printResult() {
    var result1,
        result2;
    result1 = firstLarger(arr1);
    result2 = firstLarger(arr2);
    outputBox.value += 'Array 1: ' + result1 + '\r\n';
    outputBox.value += 'Array 2: ' + result2 + '\r\n';
}
function firstLarger(array) {
    var i,
        len;
    for (i = 0, len = array.length; i < len; i += 1) {
        if (checkIfLarger(array, i)) {
            return i;
        }
    }
    return -1;
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