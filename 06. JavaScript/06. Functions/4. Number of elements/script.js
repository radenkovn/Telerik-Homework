var outputBox = document.getElementById('output');
function printResult() {
    var result;
    result = countDivs();
    outputBox.value += 'There are '+ result+ ' divs on the page' + '\r\n';
}
function countDivs() {
    return document.getElementsByTagName('div').length;
}