var firstPoint = document.getElementById('firstPoint'),
    secondPoint = document.getElementById('secondPoint'),
    outputBox = document.getElementById('output');
function checkIfInside() {
    var a = firstPoint.value,
        b = secondPoint.value,
        checker;
    checker=(a*a+b*b)<=25;
    if (checker) {
        outputBox.value += 'The point is within the circle!\r\n';
    } else {
        outputBox.value += 'The point is outside of the circle!\r\n';
    }
}