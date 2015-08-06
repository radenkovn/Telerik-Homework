var outputBox = document.getElementById('output'),
    myarr = [1, 2, 2, 3, 4, 1, 2, 3, 2, 2, 2, 1],
    a = 5;
outputBox.value += 'Original: ' + myarr.join(', ') + '\r\n';
outputBox.value += 'Primitive value a = ' + a + '\r\n\r\n';
function printResult() {
    var b,
        arr2;
    arr2 = clone(myarr);
    b = clone(a);
    outputBox.value += 'Copy:     ' + arr2.join(', ') + '\r\n';
    outputBox.value += 'Copy primitive  b = ' + b + '\r\n\r\n';
    arr2[0] = 0;
    b = 0;
    outputBox.value += 'After a change: arr2[0]=0;\r\n';
    outputBox.value += 'Original: ' + myarr.join(', ') + '\r\n';
    outputBox.value += 'Copy:     ' + arr2.join(', ') + '\r\n\r\n';
    outputBox.value += 'After a primitive change: b = 0;\r\n';
    outputBox.value += 'Primitive value a = ' + a + '\r\n';
    outputBox.value += 'Copy primitive  b = ' + b + '\r\n\r\n';


}
function clone(obj) {
    var prop,
        copy;
    if (obj == null || typeof obj != "object") {
        return obj;
    }
    copy = obj.constructor();
    for (prop in obj) {
        if (obj.hasOwnProperty(prop)) {
            copy[prop] = obj[prop];
        }
    }
    return copy;
}