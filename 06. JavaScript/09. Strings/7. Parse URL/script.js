var outputBox = document.getElementById('output');
function printResult() {
    var result,
        prop,
        str = 'http://telerikacademy.com/Courses/Courses/Details/239';
    result = parseURL(str);
    outputBox.value += 'The initial text(with nested): \r\n\r\n' + str + '\r\n\r\n';
    for (prop in result) {
        outputBox.value += prop + ': ' + result[prop] + '\r\n';
    }
}
function parseURL(str) {
    var result = {};
    result['protocol'] = str.substring(0, str.indexOf('://'));
    result['server'] = str.substring(str.indexOf('//') + 2, str.indexOf('/', str.indexOf('//') + 2));
    result['resource'] = str.substring(str.indexOf('/', str.indexOf('//') + 2) + 1);
    return result;
}
