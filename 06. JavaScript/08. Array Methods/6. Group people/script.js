var outputBox = document.getElementById('output'),
    people = [];
people[0] = createPerson('Barrack', 'Obama', 13, false);
people[1] = createPerson('Bladimir', 'Putin', 15, false);
people[2] = createPerson('Katy', 'Perry', 17, true);
people[3] = createPerson('Kady', 'Gaga', 19, true);
people[4] = createPerson('Al', 'Bundy', 21, false);
people[5] = createPerson('Ellen', 'Page', 22, true);
people[6] = createPerson('Harry', 'Potter', 23, false);
people[7] = createPerson('Bilbo', 'Baggins', 24, false);
people[8] = createPerson('Nesha', 'Rihanna', 25, true);
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

    var prop,
        resultStr = '',
        groupedOne = groupByNameOne(people),
        groupedTwo = groupByNameTwo(people);

    console.log(groupedOne);
    console.log(groupedTwo);
    for (prop in groupedOne) {
        resultStr += prop + ':' + '\r\n';
        resultStr += printArr(groupedOne[prop]);
    }

    outputBox.value += 'Please check the console for the results!\r\n';
    outputBox.value += resultStr;

}

//FIRST METHOD WITHOUT reduce
function groupByNameOne(people) {
    var grouped = {};
    people.sort(function (x, y) {
        return x.firstName.toLowerCase() > y.firstName.toLowerCase();
    }).forEach(function (person) {
        if (!(grouped.hasOwnProperty(person.firstName[0].toLowerCase()))) {
            grouped[person.firstName[0].toLowerCase()] = people.filter(function (sortedPerson) {
                return sortedPerson.firstName[0].toLowerCase() === person.firstName[0].toLowerCase();
            });
        }
    });
    return grouped;
}

//SECOND METHOD WITH reduce
function groupByNameTwo(people) {
    return people.sort(function (x, y) {
        return x.firstName.toLowerCase() > y.firstName.toLowerCase();
    }).reduce(function (grpObj, person) {
        if (!(grpObj.hasOwnProperty(person.firstName[0].toLowerCase()))) {
            grpObj[person.firstName[0].toLowerCase()] = people.filter(function (sortedPerson) {
                return sortedPerson.firstName[0].toLowerCase() === person.firstName[0].toLowerCase();
            });
        }
        return grpObj;
    }, {});
}
