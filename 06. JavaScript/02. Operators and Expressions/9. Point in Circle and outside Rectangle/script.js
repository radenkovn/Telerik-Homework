var firstPoint = document.getElementById('firstPoint'),
    secondPoint = document.getElementById('secondPoint'),
    outputBox = document.getElementById('output');
function checkIfInside() {
    var checkerCircle,
        checkerRectX,
        checkerRect,
        x = firstPoint.value,
        y = secondPoint.value;

    checkerCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
    if(x>0){
        checkerRectX=x>5;
    }
    else{
        checkerRectX=x<-1;
    }
    if(!checkerRectX){
        if(y>0){
            checkerRect=y>1;
        }
        else{
            checkerRect=y<-1;
        }
    }
    else{
        checkerRect=true;
    }

    if (checkerCircle&&checkerRect) {
        outputBox.value += 'The point is in the circle and outside of the rectangle!\r\n';
    } else {
        outputBox.value += 'The point does not meet the conditions!\r\n';
    }

}