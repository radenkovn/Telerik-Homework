var firstNumber = document.getElementById('firstNumber'),
    secondNumber = document.getElementById('secondNumber'),
    thirdNumber = document.getElementById('thirdNumber'),
    outputBox = document.getElementById('output');
function findBiggest() {
    var max,
        a = +firstNumber.value,
        b = +secondNumber.value,
        c = +thirdNumber.value;
    if(a>=b){
        if(a>=c){
           max=a;
        }
        else{
            max=c;
        }
    }
    else{
        if(b>=c){
            max=b;
        }
        else{
            max=c;
        }
    }
    outputBox.value += 'The biggest number is: ' + max + '\r\n\r\n';
}