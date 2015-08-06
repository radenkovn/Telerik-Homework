var outputBox = document.getElementById('output');
function printResult() {
    var input = 'Lorem ipsum dolor sit amet, consectetur@yahoo.com adipisicing elit. Earum error impedit porro reiciendis rem! Accusamus@gmail.com ad at consequatur corporis@abv.bg error ex excepturi illum ipsa magnam officia, quia reiciendis rerum@asdqwe.com saepe sed soluta! Accusantium adipisci@gmail.ru delectus, deserunt digniss@imos.de dolor doloribus et, excepturi in@asd.qwe ipsam iure maiores minima necessitatibus provident quae, sunt!',
        result = extractEmails(input);
    outputBox.value += 'The text is:\r\n' + input;
    outputBox.value += '\r\n\r\nThe result is:\r\n' + result;
}

function extractEmails(text) {
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}