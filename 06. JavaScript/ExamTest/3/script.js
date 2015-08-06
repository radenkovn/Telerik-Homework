var outputBox = document.getElementById('output');
function printResult() {
    outputBox.value+= c(['-1','-2'])+'\r\n';
    outputBox.value+= c(['1','-2'])+'\r\n';
    outputBox.value+= c(['-1','2'])+'\r\n';
    outputBox.value+= c(['1','2'])+'\r\n';

}
function c(c, a){ a = (c[1] > 0 ? 0 : 2);return c[0] > 0 ? a + 1 : a;}

