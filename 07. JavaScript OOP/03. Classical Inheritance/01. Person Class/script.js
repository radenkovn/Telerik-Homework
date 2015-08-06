/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
(function () {
    var person = solve(),
        myPerson = new person('Firsttest', 'Lasttest', '5');
    console.log(myPerson);
    console.log(myPerson.firstname);
    console.log(myPerson.lastname);
    console.log(myPerson.fullname);
    myPerson.fullname = myPerson.fullname + 'z';
    console.log(myPerson.fullname);
    console.log(myPerson.introduce());

    function solve() {
        var Person = (function () {
            function Person(firstName, lastName, age) {
                checkParams(firstName, lastName, age);
                this.firstname = firstName;
                this.lastname = lastName;
                this.age = +age;
                return this;
            }

            Person.prototype = {
                get introduce() {
                    return function () {
                        return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
                    }
                },
                get fullname() {
                    return this.firstname + ' ' + this.lastname;
                },
                set fullname(fullname) {
                    var firstName,
                        lastName;
                    fullname = fullname.split(' ');
                    firstName = fullname [0];
                    lastName = fullname [1];
                    checkParams(firstName, lastName, 0);
                    this.firstname = firstName;
                    this.lastname = lastName;
                    return this;
                }
            };

            function checkParams(firstName, lastName, age) {
                var minimumNameLength = 3,
                    maximumNameLength = 20,
                    minimumAge = 0,
                    maximumAge = 150;

                if (firstName.toString().length < minimumNameLength || firstName.toString().length > maximumNameLength) {
                    throw new Error('The first name should be between ' + minimumNameLength + ' and ' + maximumNameLength + ' characters long!');
                }
                if (lastName.toString().length < minimumNameLength || lastName.toString().length > maximumNameLength) {
                    throw new Error('The last name should be between ' + minimumNameLength + ' and ' + maximumNameLength + ' characters long!');
                }
                if (+age < minimumAge || +age > maximumAge) {
                    throw new Error('The age should be between ' + minimumAge + ' and ' + maximumAge + ' years!');
                }
                if (isNaN(age)) {
                    throw new Error('You have entered an ')
                }
            }

            return Person;
        }());
        return Person;
    }
}());

console.log('asd');