//Task 1
var first = 'this is a string',
    second = 5,
    third = 5.55,
    fourth = false,
    fifth = NaN,
    //Task 4
    sixth,
    nullVar = null,
    //Task 2
    quote = '\'How you doin\'?\', Joey said\'',
    //Task 3
    typeFirst = typeof(first),
    typeSecond = typeof(second),
    typeThird = typeof(third),
    typeFourth = typeof(fourth),
    typeFifth = typeof(fifth),
    typeSixth = typeof(sixth),
    typeNull = typeof(nullVar),
    output = document.getElementById('output'),
    buttonOne = document.getElementById('taskOne'),
    buttonTwo = document.getElementById("taskTwo"),
    buttonThree = document.getElementById("taskThree"),
    buttonFour = document.getElementById("taskFour");

//Task 1
function executeTaskOne() {
    output.value += 'Task 1\r\n\r\n';
    output.value += first + '\r\n';
    output.value += second + '\r\n';
    output.value += third + '\r\n';
    output.value += fourth + '\r\n';
    output.value += fifth + '\r\n';
    output.value += sixth + '\r\n';
    output.value += nullVar + '\r\n\r\n';
    buttonOne.disabled = true;
}

//Task 2
function executeTaskTwo() {
    output.value += 'Task 2\r\n\r\n';
    output.value += quote + '\r\n\r\n';
    buttonTwo.disabled = true;
}

//Task 3
function executeTaskThree() {
    output.value += 'Task 3\r\n\r\n';
    output.value += first + ' - ' + typeFirst + '\r\n';
    output.value += second + ' - ' + typeSecond + '\r\n';
    output.value += third + ' - ' + typeThird + '\r\n';
    output.value += fourth + ' - ' + typeFourth + '\r\n';
    output.value += fifth + ' - ' + typeFifth + '\r\n';
    output.value += sixth + ' - ' + typeSixth + '\r\n';
    output.value += nullVar + ' - ' + typeNull + '\r\n\r\n';
    buttonThree.disabled = true;
}

//Task 4
function executeTaskFour() {
    output.value += 'Task 4\r\n\r\n';
    output.value += 'The value - ' + nullVar + '      The type - ' + typeNull + '\r\n';
    output.value += 'The value - ' + sixth + ' The type - ' + typeSixth + '\r\n\r\n';
    buttonFour.disabled = true;
}