var outputBox = document.getElementById('output'),
    people = [];
people[0] = createPerson('Barrack', 'Obama', 13, false);
people[1] = createPerson('Vladimir', 'Putin', 15, false);
people[2] = createPerson('Katy', 'Perry', 17, true);
people[3] = createPerson('Lady', 'Gaga', 19, true);
people[4] = createPerson('Al', 'Bundy', 21, false);
people[5] = createPerson('Ellen', 'Page', 22, true);
people[6] = createPerson('Harry', 'Potter', 23, false);
people[7] = createPerson('Bilbo', 'Baggins', 24, false);
people[8] = createPerson('Kesha', 'Rihanna', 25, true);
people[9] = createPerson('Natalie', 'Portman', 26, true);
outputBox.value += printArr(people) + '\r\n';

function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender,
        toString: function () {
            return firstName + ' ' + lastName + ' - ' + age + ', ' + (gender ? 'female' : 'male');
        }
    }
}

function printArr(array) {
    var printResult = '';
    array.forEach(function (item) {
        printResult += item + '\r\n';
    });
    return printResult;
}

function printResult() {
    var averageAgeFemale = avgFemale(people);
    outputBox.value += 'Average female age: \r\n' + averageAgeFemale + '\r\n';

}

function avgFemale(people) {
    return people.filter(function (person) {
        return person.gender === true;
    }).reduce(function (avg, female, i, femArr) {
        return avg + (female.age / femArr.length);
    }, 0);
}
