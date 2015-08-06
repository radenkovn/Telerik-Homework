var outputBox = document.getElementById('output');
function printResult() {

    outputBox.value += ('\<div data-bind-content="name"></div>'.bind({name: 'Steven'})) +'\r\n\r\n';
    outputBox.value += ('\<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'.bind({
        name: 'Elena',
        link: 'http://telerikacademy.com'
    }))+'\r\n';

}
if (!String.prototype.format) {
    String.prototype.bind = function (parameters) {
        var content,
            href,
            clss,
            prop,
            output = this;

        for (prop in parameters) {
            content = new RegExp('(<.*?data-bind-content="' + prop + '".*?>)(.*?)(<\\s*/.*?>)', 'g');
            href = new RegExp('(<.*?data-bind-href="' + prop + '".*?)>', 'g');
            clss = new RegExp('(<.*?data-bind-class="(' + prop + ')".*?)>', 'g');
            //Copied from internet:
            output = output.replace(content, function (element, openingTag, content, closingTag) {
                return openingTag + parameters[prop] + closingTag;
            });
            //Copied from internet:
            output = output.replace(href, function (tag, contentBeforeClosing) {
                return contentBeforeClosing + ' href="' + parameters[prop] + '">';
            });
            //Copied from internet:
            output = output.replace(clss, function (tag, contentBeforeClosing) {
                return contentBeforeClosing + ' class="' + parameters[prop] + '">';
            });
        }
        return output;
    };
}