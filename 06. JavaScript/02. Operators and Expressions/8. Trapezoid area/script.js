var firstSide = document.getElementById('firstSide'),
    secondSide = document.getElementById('secondSide'),
    height = document.getElementById('height'),
    outputBox = document.getElementById('output');
function checkIfInside() {
    var s,
        a = firstSide.value,
        b = secondSide.value,
        h = height.value;
    if (a === 0 || b === 0 || h === 0) {
        outputBox.value += 'This is not a rectangle!\r\n';
    } else {
        s = ((-(-a - b)) / 2) * h;
        outputBox.value += 'The area of the triangle is ' + s + ' !\r\n';
    }
}