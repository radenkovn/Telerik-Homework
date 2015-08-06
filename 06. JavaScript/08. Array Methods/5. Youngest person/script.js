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

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i,
            len;
        for (i = 0, len = this.length; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
        return undefined;
    }
}

function printResult() {

    var youngestMale = youngestMaleOne(people);
    outputBox.value += 'Method 1 Youngest male: ' + youngestMale + '\r\n';

    var youngestMale2 = youngestMaleTwo(people);
    outputBox.value += 'Method 2 Youngest male: ' + youngestMale2 + '\r\n';

}

//FirstMethod WITHOUT find
function youngestMaleOne(people) {
    return people.filter(function (person) {
        return person.gender === false;
    }).sort(function (x, y) {
        return x.age - y.age;
    })[0];
}

//SecondMethod WITH find
function youngestMaleTwo(people) {
    return people.find(function (person) {
        return person.age === people.filter(function (person) {
                return person.gender === false;
            }).map(function (person) {
                return person.age;
            }).sort(function (x, y) {
                return x - y;
            })[0];
    });
}
