var firstNumber = document.getElementById('firstNumber'),
    outputBox = document.getElementById('output');
function numbersWords() {
    var digita,
        digitb,
        digitc,
        number,
        ignoreLast=false,
        result = '',
        numStr = firstNumber.value;
    number = +numStr;
    if (numStr.length === 3) {
        digita = (number / 100) | 0;
        digitb = ((number / 10) | 0) % 10;
        digitc = number % 10;
    }
    else if (numStr.length === 2) {
        digitb = ((number / 10) | 0) % 10;
        digitc = number % 10;
    }
    else {
        digitc = number % 10;
    }
    if (numStr.length === 3) {

        switch (digita) {
            case 1:
                result += 'one';
                break;
            case 2:
                result += 'two';
                break;
            case 3:
                result += 'three';
                break;
            case 4:
                result += 'four';
                break;
            case 5:
                result += 'five';
                break;
            case 6:
                result += 'six';
                break;
            case 7:
                result += 'seven';
                break;
            case 8:
                result += 'eight';
                break;
            case 9:
                result += 'nine';
                break;
        }
        result += ' hundred';
        if ((digitb != 0) || (digitb ===0 && digitc!=0)) {
            result += ' and ';
        }
    }
    if (numStr.length >= 2) {
        if (digitb == 1) {
            ignoreLast=true;
            switch (digitc) {
                case 0:
                    result += 'ten';
                    break;
                case 1:
                    result += 'eleven';
                    break;
                case 2:
                    result += 'twelve';
                    break;
                case 3:
                    result += 'thirteen';
                    break;
                case 4:
                    result += 'fourteen';
                    break;
                case 5:
                    result += 'fifteen';
                    break;
                case 6:
                    result += 'sixteen';
                    break;
                case 7:
                    result += 'seventeen';
                    break;
                case 8:
                    result += 'eighteen';
                    break;
                case 9:
                    result += 'nineteen';
                    break;
            }
        }
        else {
            switch (digitb) {
                case 2:
                    result += 'twenty ';
                    break;
                case 3:
                    result += 'thirty ';
                    break;
                case 4:
                    result += 'forty ';
                    break;
                case 5:
                    result += 'fifty ';
                    break;
                case 6:
                    result += 'sixty ';
                    break;
                case 7:
                    result += 'seventy ';
                    break;
                case 8:
                    result += 'eighty ';
                    break;
                case 9:
                    result += 'ninety ';
                    break;
                case 0:
                    break;
            }
        }
    }
    if(!ignoreLast) {
        switch (digitc) {
            case 0:
                if (numStr.length === 1) {
                    result += "zero";
                }
                break;
            case 1:
                result += 'one';
                break;
            case 2:
                result += 'two';
                break;
            case 3:
                result += 'three';
                break;
            case 4:
                result += 'four';
                break;
            case 5:
                result += 'five';
                break;
            case 6:
                result += 'six';
                break;
            case 7:
                result += 'seven';
                break;
            case 8:
                result += 'eight';
                break;
            case 9:
                result += 'nine';
                break;
        }
    }
    result += '\r\n';
    result = capitalizeFirstLetter(result);
    outputBox.value += result + '\r\n\r\n';
}
// taken from internet
// http://lmgtfy.com/?q=capitalize+first+letter+javascript
// first result
function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}