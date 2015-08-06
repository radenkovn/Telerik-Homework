var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output'),
    myarr = [1, 2, 2, 3, 4, 1, 2, 3, 2, 2, 2, 1];
outputBox.value += 'The array: ' + myarr.join(', ') + '\r\n';
function printResult() {
    var element = +firstNumber.value;
    myarr = myarr.removeAll(element);
    outputBox.value += 'Result: ' + myarr.join(', ') + '\r\n';
}
Array.prototype.removeAll = function (element) {
    var i,
        len = this.length,
        result = [],
        count = 0;
    for (i = 0; i < len; i += 1) {
        if (this[i] != element) {
            result[count] = this[i];
            count = count + 1;
        }
    }
    return result;
};