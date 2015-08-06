var outputBox = document.getElementById('output');
function lexMinMax() {
    var prop,
        min = 'z',
        max = 'a';
    for (prop in document) {
        if (prop.toLowerCase() <= min.toLowerCase()) {
            min = prop;
        }
        if (prop.toLowerCase() >= max.toLowerCase()) {
            max = prop;
        }
    }
    outputBox.value += 'min in document: ' + min + '\r\n';
    outputBox.value += 'max in document: ' + max + '\r\n\r\n';
    min = 'z';
    max = 'a';
    for (prop in window) {
        if (prop.toLowerCase() <= min.toLowerCase()) {
            min = prop;
        }
        if (prop.toLowerCase() >= max.toLowerCase()) {
            max = prop;
        }
    }
    outputBox.value += 'min in window: ' + min + '\r\n';
    outputBox.value += 'max in window: ' + max + '\r\n\r\n';
    min = 'z';
    max = 'a';
    for (prop in navigator) {
        if (prop.toLowerCase() <= min.toLowerCase()) {
            min = prop;
        }
        if (prop.toLowerCase() >= max.toLowerCase()) {
            max = prop;
        }
    }
    outputBox.value += 'min in navigator: ' + min + '\r\n';
    outputBox.value += 'max in navigator: ' + max + '\r\n\r\n';
}