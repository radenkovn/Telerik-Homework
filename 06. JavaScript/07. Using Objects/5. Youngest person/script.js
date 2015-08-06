var outputBox = document.getElementById('output');
var person,
    people = [
        {firstName: 'Barrack', lastName: 'Obama', age: 13},
        {firstName: 'Vladimir', lastName: 'Putin', age: 15},
        {firstName: 'Katy', lastName: 'Perry', age: 17},
        {firstName: 'Ellen', lastName: 'Page', age: 20},
        {firstName: 'George', lastName: 'Clooney', age: 25}
    ];
for (person in people) {
    outputBox.value += people[person].firstName + ' ' + people[person].lastName + ' ' + people[person].age + '\r\n';
}
function printResult() {
    var youngest = findYoungest(people);
    outputBox.value += '\r\nThe youngest one is: ' + youngest.firstName + ' ' + youngest.lastName + ' ' + '\r\n';

}

function findYoungest(people) {
    var person,
        min = 500;
    for (person in people) {
        if (people[person].age < min) {
            min = people[person].age;
        }
    }
    for (person in people) {
        if (people[person].age == min) {
            return people[person];
        }
    }

}
