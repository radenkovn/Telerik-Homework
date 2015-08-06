var outputBox = document.getElementById('output');
function printResult() {
    solve([7]);
    solve([10]);
    solve([40]);
}
function solve(params) {
    var s = +params[0],
        count = 0,
        i,
        j,
        k,
        sum = 0;
    for (i = 0; i < 200 / 3 + 1; i += 1) {
        for (j = 0; j < 200 / 4 + 1; j += 1) {
            for (k = 0; k <= 20; k += 1) {
                sum = i * 3 + j * 4 + k * 10;
                if (sum == s) {
                    count += 1;
                }
            }
        }
    }
    console.log(count);
}

