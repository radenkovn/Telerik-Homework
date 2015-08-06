var outputBox = document.getElementById('output');
function printResult() {
    var result,
        str = '\<html>\r\n <head>\r\n  <title>Sample site</title>\r\n </head>\r\n <body>\r\n  <div>text\r\n   <div>more text</div>\r\n   and more... \r\n </div>\r\n in body \r\n</body>\r\n</html>';
    result = parseHTML(str);
    outputBox.value += 'The initial text(with nested): \r\n\r\n' + str + '\r\n\r\n';
    outputBox.value += 'The end result:\r\n' + result + '\r\n\r\n';

}
function parseHTML(str) {
    var indexE,
        subS,
        result = '',
        indexS = str.indexOf('<');
    while (indexS >= 0 && indexS < str.length) {
        indexS = str.indexOf('>', indexS + 1);
        indexE = str.indexOf('<', indexS + 1) >= 0 ? str.indexOf('<', indexS + 1) : str.length;
        subS = str.substring(indexS + 1, indexE).trim();
        result += subS;
        indexS = indexE;
    }
    return result;
}
