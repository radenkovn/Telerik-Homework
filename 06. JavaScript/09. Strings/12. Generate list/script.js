var outputBox = document.getElementById('output');
function printResult() {
    var people = [
            {name: 'Peter', age: 14},
            {name: 'George', age: 18},
            {name: 'John', age: 20},
            {name: 'Raymond', age: 22},
            {name: 'Putin', age: 24}],
        template = document.getElementById('list-item').innerHTML.trim(),
        peopleList = generateList(people, template);

    outputBox.value +='The initial value =:\r\n'+template;
    outputBox.value +='\r\nAfter the operation:\r\n\r\n'+ peopleList;
}
function generateList(objArr, template) {
    var result = '\<ul>',
        i,
        tag,
        j,
        len,
        currentProp,
        innerStart = 0,
        innerEnd = 0,
        changer,
        index = 0,
        start,
        end;
    for (i = 0, len = objArr.length; i < len; i += 1) {
        result += '\r\n' + '\<li>';
        innerStart = 0;
        innerEnd = 0;
        index = 0;
        while (index >= 0) {
            tag = template.substring(template.indexOf('<', index), template.indexOf('>', index) + 1);
            result += tag;
            start = template.indexOf(tag, index) + tag.length;

            tag = replace(tag, '<', '</');
            end = template.indexOf(tag, index);
            changer = template.substring(start, end);
            innerStart = 0;
            innerEnd = 0;
            while (innerStart >= 0) {
                innerStart = changer.indexOf('-{', innerStart) + 2;
                innerEnd = changer.indexOf('}-', innerEnd);
                currentProp = changer.substring(innerStart, innerEnd);
                result += objArr[i][currentProp];
                innerStart = changer.indexOf('-{', innerEnd);
            }
            result += tag;
            index = template.indexOf('<', end + 1);
        }
        result += '\</li>';
    }
    result += '\r\n' + '\</ul>';

    return result;
}
function replace(str, replaceMe, replaceWith) {
    var index = str.indexOf(replaceMe);
    while (index >= 0) {
        str = str.replace(replaceMe, replaceWith);
        index = str.indexOf(replaceMe, index + 1);
    }
    return str;
}