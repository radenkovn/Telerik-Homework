var outputBox = document.getElementById('output');
var person,
    people = [
        {firstName: 'Barrack', lastName: 'Obama', age: 13},
        {firstName: 'Vladimir', lastName: 'Putin', age: 13},
        {firstName: 'Vladimir', lastName: 'Perry', age: 17},
        {firstName: 'Barrack', lastName: 'Perry', age: 17},
        {firstName: 'Barrack', lastName: 'Putin', age: 25}
    ];
for (person in people) {
    outputBox.value += people[person].firstName + ' ' + people[person].lastName + ' ' + people[person].age + '\r\n';
}
function printResult() {
    var firstNameArr = group(people, 'age');
    console.log(firstNameArr);
}
function group(people, property) {
    var i,
        j,
        len,
        grouped = [],
        count1 = 0,
        count2 = 0,
        check,
        repeat;
    for (i = 0, len = people.length; i < len; i += 1) {
        check = clone(people[i]);
        repeat = false;
        if (check != null) {
            count2 = 0;
            for (j = i + 1; j < len; j += 1) {
                if (check[property] === people[j][property]) {
                    if (people[i] != null) {
                        grouped[count1] = [];
                        grouped[count1][count2] = clone(people[i]);
                        count2 += 1;
                    }
                    grouped[count1][count2] = clone(people[j]);
                    count2 += 1;
                    repeat = true;
                    people[j] = null;
                }
            }
            if (repeat == false) {
                grouped[count1] = check;
            }
            count1 += 1;
        }
    }
    console.log('asd');
    return grouped;
}
function clone(obj) {
    var prop,
        copy;
    if (obj == null || typeof obj != "object") {
        return obj;
    }
    copy = obj.constructor();
    for (prop in obj) {
        if (obj.hasOwnProperty(prop)) {
            copy[prop] = obj[prop];
        }
    }
    return copy;
}