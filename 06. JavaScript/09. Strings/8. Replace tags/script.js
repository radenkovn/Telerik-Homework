var outputBox = document.getElementById('output');
function printResult() {
    var result,
        myText = '\<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    result = replace(myText, '<a href="', '[URL=');
    result = replace(result, '">', '[/URL]');
    outputBox.value += 'The original: \r\n\r\n' + myText + '\r\n\r\n';
    outputBox.value += 'The result: \r\n' + result + '\r\n';
}
function replace(str, replaceMe, replaceWith) {
    var index = str.indexOf(replaceMe);
    while (index >= 0) {
        str = str.replace(replaceMe, replaceWith);
        index = str.indexOf(replaceMe, index + 1);
    }
    return str;
}