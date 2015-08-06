var outputBox = document.getElementById('output');
function printResult() {
    solve(['3 5', 'dr dl dr ur ul', 'dr dr ul ur ur', 'dl dr ur dl ur']);
    solve(['3 5', 'dr dl dl ur ul', 'dr dr ul ul ur', 'dl dr ur dl ur']);


}
function solve(params) {
    var firstLine = params[0],
        row,
        col,
        line,
        myARR = [],
        valueArr = [],
        sum = 0,
        currentRow,
        currentCol,
        end = false;

    firstLine = firstLine.split(' ');
    var rows = firstLine[0];
    var cols = firstLine[1];
    for (row = 0; row < rows; row += 1) {
        line = params[row + 1].split(' ');
        myARR[row] = [];
        valueArr[row] = [];
        for (col = 0; col < cols; col += 1) {
            valueArr[row][col] = Math.pow(2, row) + col;
            myARR[row][col] = line[col];
        }
    }
    currentCol = 0;
    currentRow = 0;
    while (!end) {
        sum += valueArr[currentRow][currentCol];
        valueArr[currentRow][currentCol] = 0;
        switch (myARR[currentRow][currentCol]) {
            case 'dr':
            {
                currentRow = currentRow + 1;
                currentCol = currentCol + 1;
            }
                break;
            case 'dl':
            {
                currentRow = currentRow + 1;
                currentCol = currentCol - 1;
            }
                break;
            case 'ur':
            {
                currentRow = currentRow - 1;
                currentCol = currentCol + 1;
            }
                break;
            case 'ul':
            {
                currentRow = currentRow - 1;
                currentCol = currentCol - 1;
            }
                break;
        }
        if ((currentCol < 0 || currentCol >= cols) || (currentRow < 0 || currentRow >= rows)) {
            console.log('successed with ' + sum);
            end = true;
            break;
        }
        if ((valueArr[currentRow][currentCol] === 0)) {
            console.log('failed at (' + currentRow + ', ' + currentCol + ')');
            end = true;
            break;
        }
    }
}

