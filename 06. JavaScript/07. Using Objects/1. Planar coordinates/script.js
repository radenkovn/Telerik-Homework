var outputBox = document.getElementById('output');
function printResult() {
    var triangle,
        side1,
        side2,
        side3,
        point1 = createPoint(1, 2),
        point2 = createPoint(2, 3),
        point3 = createPoint(3, 4),
        point4 = createPoint(5, 6),
        point5 = createPoint(7, 8),
        point6 = createPoint(9, 10);
    side1 = createSegment(point1, point2);
    side2 = createSegment(point3, point4);
    side3 = createSegment(point5, point6);
    triangle = checkIfTriangle(side1, side2, side3);
    outputBox.value += 'The distance between ' + point1 + ' and ' + point2 + ' is ' + calcDistance(point1, point2) + '\r\n';
    outputBox.value += side1 + ' and ' + side2 + ' and ' + side3 + ' ';
    if (triangle) {
        outputBox.value += 'can form a triangle \r\n';
    }
    else {
        outputBox.value += 'can\'t form a triangle \r\n';
    }

}
function createPoint(X, Y) {
    return {
        x: X,
        y: Y,
        toString: function () {
            return 'P(' + this.x + ',' + this.y + ')';
        }
    }
}
function createSegment(A, B) {
    return {
        a: A,
        b: B,
        toString: function () {
            return 'L(' + this.a.toString() + ',' + this.b.toString() + ')';
        }
    }
}
function calcDistance(P1, P2) {
    return Math.sqrt(Math.pow((P2.x - P1.x), 2) + Math.pow((P2.y - P1.y), 2));
}
function checkIfTriangle(s1, s2, s3) {
    var a = calcDistance(s1.a, s1.b),
        b = calcDistance(s2.a, s2.b),
        c = calcDistance(s3.a, s3.b);
    return (a + b <= c || a + c <= b || b + c <= a);
}