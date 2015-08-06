var outputBox = document.getElementById('output');
function printResult() {
    var result,
        str = '\We are <mixcase>living</mixcase> in a <upcase>yellow <mixcase>submarine</mixcase></upcase>. We <mixcase>don\'t</mixcase> have <lowcase>ANYTHING</lowcase> else.';
    result = parseText(str);
    outputBox.value += 'The initial text(with nested): \r\n\r\n' + str + '\r\n\r\n';
    outputBox.value += 'The end result:\r\n' + result + '\r\n\r\n';

}
function parseText(str) {
    var subS,
        indexS,
        indexE,
        result = '',
        mix = str.indexOf('\<mixcase>'),
        low = str.indexOf('\<lowcase>'),
        up = str.indexOf('\<upcase>');
    if (mix < 0 && low < 0 && up < 0) {
        return str;
    }
    indexS = str.indexOf('<');
    subS = str.substring(0, indexS);
    result += subS;
    while (indexS >= 0 && indexS < str.length - 1) {
        switch (str[indexS + 1]) {
            case'm':
            {
                indexE = str.indexOf('<', indexS + 1);
                subS = str.substring(str.indexOf('>', indexS) + 1, indexE);
                result += mixCase(subS);
                indexS = indexE >= 0 ? indexE : str.length;
            }
                break;
            case'l':
            {
                indexE = str.indexOf('<', indexS + 1);
                subS = str.substring(str.indexOf('>', indexS) + 1, indexE);
                result += lowCase(subS);
                indexS = indexE >= 0 ? indexE : str.length;
            }
                break;
            case'u':
            {
                indexE = str.indexOf('<', indexS + 1);
                subS = str.substring(str.indexOf('>', indexS) + 1, indexE);
                result += upCase(subS);
                indexS = indexE >= 0 ? indexE : str.length;
            }
                break;
            case'/':
            {
                indexE = str.indexOf('<', indexS + 1);
                indexE = indexE >= 0 ? indexE : str.length;
                indexS = str.indexOf('>', indexS + 1) + 1;
                subS = str.substring(indexS, indexE);
                result += subS;
                indexS = indexE;
            }
                break;
        }
    }
    return result;
}
function mixCase(str) {
    var i,
        len,
        rand,
        result = '';
    for (i = 0, len = str.length; i < len; i += 1) {
        rand = ((Math.random() * 2) + 1) | 0;
        if (rand == 1) {
            result += str[i].toUpperCase();
        }
        if (rand == 2) {
            result += str[i].toLowerCase();
        }
    }
    return result;
}
function upCase(str) {
    return str.toUpperCase();
}
function lowCase(str) {
    return str.toLowerCase();
}