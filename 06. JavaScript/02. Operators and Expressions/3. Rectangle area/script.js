var firstSide = document.getElementById('firstSide'),
    secondSide = document.getElementById('secondSide'),
    outputBox = document.getElementById('output');
function findArea() {
    var a = firstSide.value,
        b = secondSide.value;
    if (a == 0 || b == 0) {
        outputBox.value += 'This is not a rectangle!\r\n';
    } else {
        outputBox.value += 'The area of the triangle is ' + a * b + ' !\r\n';
    }
}