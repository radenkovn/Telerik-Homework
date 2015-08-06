(function () {
    function solve() {
        var student,
            homeWorkIDs,
            Course = {
                init: function (title, presentations) {
                    validateTitle(title);
                    validatePresentations(presentations);
                    this.title = title;
                    this.presentations = presentations;
                    this.students = [];
                    homeWorkIDs.get().add();
                    return this;
                },
                addStudent: function (name) {
                    var currentStudent = Object.create(student).init(name);
                    currentStudent.id = this.students.length + 1;
                    this.students.push(currentStudent);
                    return currentStudent.id;
                },
                getAllStudents: function () {
                    if (this.students.length === 0) {
                        return [];
                    }
                    return this.students;
                },
                submitHomework: function (studentID, homeworkID) {
                    validateID(studentID);
                    validateID(homeworkID);
                    if (!this.students.some(function (student) {
                            return student.id === studentID;
                        })) {
                        throw new Error('Invalid student ID');
                    }
                    if (homeworkID > homeWorkIDs.get().count) {
                        throw  new Error('Invalid homework ID');
                    }

                },
                pushExamResults: function (results) {
                    var i,
                        j,
                        currentID,
                        nextID,
                        length,
                        students = this.students;
                    if (arguments.length < 1) {
                        throw new Error('Empty results!');
                    }
                    if (!Array.isArray(results)) {
                        throw new Error('Not an array!');
                    }
                    length = results.length;
                    results.forEach(function (result) {
                        if (typeof (result.score) === 'undefined') {
                            throw new Error('Empty result!');
                        }
                        if (isNaN(result.score)) {
                            throw new Error('The score is not a number!');
                        }
                        validateID(result.StudentID);
                        if (!students.some(function (student) {
                                return student.id === result.StudentID;
                            })) {
                            throw new Error('Invalid student ID');
                        }
                    });
                    for (i = 0; i < length - 1; i += 1) {
                        currentID = results[i].StudentID;
                        for (j = i + 1; j < length; j += 1) {
                            nextID = results[j].StudentID;
                            if (currentID === nextID) {
                                throw new Error('You have entered the same ID more than once!');
                            }
                        }
                    }
                },
                getTopStudents: function () {
                    throw new Error('Not implemented yet!');
                }
            };

        student = (function () {
            var student = {};
            student.init = function (fullname) {
                if (typeof (fullname) !== 'string') {
                    throw new Error('You did not enter a string!');
                }
                var firstname = parseNames(fullname)[0],
                    lastname = parseNames(fullname)[1];
                validateName(firstname);
                validateName(lastname);
                this.firstname = firstname;
                this.lastname = lastname;
                return this;
            };

            function parseNames(fullName) {
                var firstName,
                    lastName;
                fullName = fullName.split(' ');
                if (fullName.length > 2) {
                    throw new Error('You have entered a bigger name!');
                }
                return fullName;
            }

            function validateName(name) {
                var checker = /^[A-Z]$|^[A-Z][a-z]+$/;
                if (!checker.test(name)) {
                    throw  new Error('Invalid name!');
                }
            }

            return student;
        }());

        homeWorkIDs = (function () {
            var homeWorkIDs = {
                count: 0,
                add: function () {
                    this.count += 1;
                }
            };
            homeWorkIDs = Object.preventExtensions(homeWorkIDs);
            return {
                get: function () {
                    return homeWorkIDs;
                }
            };
        }());

        function validateTitle(title) {
            var i,
                length = title.length;
            if (length < 1) {
                throw new Error('Empty title!');
            }
            if (title[0] === ' ' || title[length - 1] === ' ') {
                throw new Error('Invalid title!');
            }
            for (i = 0; i < length - 1; i += 1) {
                if (title[i] === ' ' && title[i + 1] === ' ') {
                    throw  new Error('Two consecutive spaces!');
                }
            }
        }

        function validateID(id) {
            if (id === 0) {
                throw new Error('Invalid ID');
            }
            if (id % 1 !== 0) {
                throw new Error('Invalid ID');
            }
        }

        function validatePresentations(presentations) {
            var length = presentations.length;
            if (!Array.isArray(presentations)) {
                throw new Error('You did not enter an array!');
            }
            if (length < 1) {
                throw  new Error('Empty array!');
            }
            presentations.forEach(function (presentation) {
                validateTitle(presentation);
            });
        }

        return Course;
    }

    var validTitles = [
        'Modules and Patterns',
        'Ofcourse, this is a valid title!',
        'No errors hIr.',
        'Moar taitles',
        'Businessmen arrested for harassment of rockers',
        'Miners handed cabbages to the delight of children',
        'Dealer stole Moskvitch',
        'Shepherds huddle',
        'Retired Officers rally',
        'Moulds detonate tunnel',
        'sailors furious'
    ], validNames = [
        'Pesho',
        'Notaname',
        'Johny',
        'Marulq',
        'Keremidena',
        'Samomidena',
        'Medlar',
        'Yglomer',
        'Elegant',
        'Analogical',
        'Bolsheviks',
        'Reddish',
        'Arbitrage',
        'Toyed',
        'Willfully',
        'Transcribing'
    ];

    function getValidTitle() {
        return validTitles[(Math.random() * validTitles.length) | 0];
    }

    function getValidName() {
        return validNames[(Math.random() * validNames.length) | 0];
    }

    var Course = solve(),
        jsoop, ids, i;
    jsoop = Object.create(Course);
    jsoop.init(getValidTitle(), [getValidTitle()]);
    ids = [];
    for (i = 0; i < 10; i += 1) {
        ids.push(jsoop.addStudent(getValidName() + ' ' + getValidName()));
    }
    console.log("The course we created:");
    console.log(jsoop);
    console.log();
    console.log("The method getAllStudents:");
    console.log(jsoop.getAllStudents());
}());
