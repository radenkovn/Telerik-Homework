var outputBox = document.getElementById('output');
function printResult() {
    var str = stringFormat('Hello {0}!', 'Peter'),
        frmt = '{0}, {1}, {0} text {2}',
        str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');

    outputBox.value += 'The result of:\r\n\r\nstringFormat(\'Hello {0}!\', \'Peter\');   is:\r\n\r\n';
    outputBox.value += str + '\r\n\r\n';
    outputBox.value += 'The result of:\r\n\r\nfrmt = \'{0}, {1}, {0} text {2}\'\r\nstr2 = stringFormat(frmt, 1, \'Pesho\', \'Gosho\');   is:\r\n\r\n';
    outputBox.value += str2 + '\r\n\r\n';
}
function stringFormat() {
    var i,
        len,
        format = arguments[0],
        args = [],
        checker,
        index = -1;
    for (i = 1, len = arguments.length; i < len; i += 1) {
        args[i - 1] = arguments[i];
    }
    for (i = 0; i < 30; i += 1) {
        checker = '{' + i + '}';
        format = replace(format, checker, args[i]);
        index = format.indexOf(checker, index + 1);
    }
    return format;
}
function replace(str, replaceMe, replaceWith) {
    var index = str.indexOf(replaceMe);
    while (index >= 0) {
        str = str.replace(replaceMe, replaceWith);
        index = str.indexOf(replaceMe, index + 1);
    }
    return str;
}