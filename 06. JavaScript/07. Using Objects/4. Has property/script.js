var outputBox = document.getElementById('output');
function printResult() {
    var person = {
            firstName: 'Byron',
            lastName: 'Bernstein',
            age: '27',
            toString: function () {
                return 'firstName: ' + this.firstName + ', lastName: ' + this.lastName + ', age: ' + this.age;
            }
        },
        hasFirstN,
        hasLastN,
        hasAge,
        hasHeight;
    hasFirstN = hasProperty(person, 'firstName');
    hasLastN = hasProperty(person, 'lastName');
    hasAge = hasProperty(person, 'age');
    hasHeight = hasProperty(person, 'height');
    outputBox.value += 'Our object \r\n' + person + '\r\n\r\n';
    outputBox.value += 'The person has a firstName property: ' + hasFirstN + '\r\n';
    outputBox.value += 'The person has a lastName property:  ' + hasLastN + '\r\n';
    outputBox.value += 'The person has a age property:       ' + hasAge + '\r\n';
    outputBox.value += 'The person has a height property:   ' + hasHeight + '\r\n';
}
function hasProperty(obj, property) {
    var prop,
        result = false;
    for (prop in obj) {
        if (prop == property) {
            result = true;
        }
    }
    return result;
}
