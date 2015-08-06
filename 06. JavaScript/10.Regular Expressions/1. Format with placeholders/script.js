var outputBox = document.getElementById('output');
function printResult() {
    var options = {name: 'John'},
        initial = 'Hello, there! Are you #{name}?\'.format({name: \'John\'})',
        result = 'Hello, there! Are you #{name}?'.format(options);
    outputBox.value += 'Initial: \r\n' + initial + '\r\n';
    outputBox.value += 'Result: \r\n' + result + '\r\n\r\n';
    options = {name: 'John', age: 13};
    initial = 'My name is #{name} and I am #{age}-years-old\'.format({name: \'John\', age: 13})';
    result = 'My name is #{name} and I am #{age}-years-old'.format(options);
    outputBox.value += 'Initial: \r\n' + initial + '\r\n';
    outputBox.value += 'Result: \r\n' + result + '\r\n\r\n';

}
if (!String.prototype.format) {
    String.prototype.format = function (args) {
        var prop,
            result = this;
        for (prop in args) {
            result = result.replace(new RegExp('#{' + prop + '}', 'g'), args[prop]);
        }
        return result;
    };
}