function solve() {
    return function () {
        $.fn.listview = function (data) {
            var prop,
                template,
                selectorData,
                currentTemplate,
                eachStartIndex,
                eachEndIndex,
                eachPattern,
                currentArray,
                initialTemplateEach,
                templateEachContainer,
                templateEach,
                $this = $(this);
            selectorData = $this.attr('data-template');
            template = $('#' + selectorData).html();
            data.forEach(function (item) {
                currentTemplate = template;
                if (typeof (item) !== 'object') {
                    if (currentTemplate.indexOf('{{this}}') > 0) {
                        currentTemplate = currentTemplate.replace('{{this}}', item.toString());
                    }
                } else {
                    for (prop in item) {
                        if (Array.isArray(item[prop])) {
                            currentArray = item[prop];
                            eachPattern = '{{#each ' + prop + '}}';
                            eachStartIndex = currentTemplate.indexOf(eachPattern);
                            if (eachStartIndex > 0) {
                                eachEndIndex = currentTemplate.indexOf('{{/each}}', eachStartIndex);
                                initialTemplateEach = currentTemplate.substring(eachStartIndex, eachEndIndex + 10);
                                currentTemplate = currentTemplate.replace(initialTemplateEach, '');
                                templateEachContainer = '';
                                currentArray.forEach(function (item, index) {
                                    templateEach = initialTemplateEach;
                                    templateEach = templateEach.replace(eachPattern, '');
                                    templateEach = templateEach.replace('{{/each}}', '');
                                    templateEach = templateEach.replace('{{this}}', item.toString());
                                    templateEachContainer += templateEach;

                                });
                                currentTemplate = currentTemplate.slice(0, eachStartIndex) + templateEachContainer + currentTemplate.slice(eachStartIndex);
                            }
                        } else {
                            currentTemplate = currentTemplate.replace(('{{' + prop + '}}'), item[prop]);
                        }
                    }
                }
                $this.append(currentTemplate);
            });
            return this;
            //console.log(template);
        };
    };
}
//solve()();
//
//TEST 1

//var books = [{id: 1, title: 'JavaScript: The Good Parts'},
//    {id: 2, title: 'Secrets of the JavaScript Ninja'},
//    {id: 3, title: 'Core HTML5 Canvas'},
//    {id: 4, title: 'Javascript Patterns'}];
//$('#books-list').listview(books);

//Test 2

var result = solve();

//var data = [],
//    count = 5,
//    id = 'list-view';
//
//document.body.innerHTML = '<ul id="' + id + '" data-template="item-template"></ul>' +
//    '<script id="item-template" type="text/handlebars-template"><li>{{this}}</li></script>';
//result();
//var count = 5,
//    data = Array.apply(null, {length: count})
//        .map(Number.call, Number)
//
//
//$('#' + id).listview(data);
//
//var $listview = $('#' + id);
//
//var $items = $listview.find('li');
//console.log(($items).length === (count));
//
//$items.each(function (index, item) {
//    console.log((item.innerHTML) === (data[index].toString()));
//});
//
//var data = [],
//    count = 5,
//    id = 'list-view';
//
////document.body.innerHTML = '<div id="' + id + '" data-template="item-template"></div>' +
////    '<script id="item-template" type="text/handlebars-template"><div class="outer"><h1>{{title}}</h1>{{#each numbers}}<div class="number-item">{{this}}</div>{{/each}}</div></script>';
//result();
//
//var i;
//
//for (i = 0; i < count; i += 1) {
//    data.push({
//        title: 'Title #' + (i + 1),
//        numbers: Array.apply(null, {length: (i + 5) % 6})
//            .map(Number.call, Number)
//    });
//}
//
////console.log(document.body.innerHTML);
//$('#' + id).listview(data);
//
////console.log(data);
//var $listview = $('#' + id);
//
//var $outerDivs = $listview.find('div.outer');
//console.log(($outerDivs).length === (count));
//
//$outerDivs.each(function (index, outerDiv) {
//    var $outerDiv = $(outerDiv);
//    var $heading = $outerDiv.find('h1');
//    console.log(($heading).length === (1));
//    console.log(($heading.html()) === (data[index].title));
//
//    var $innerDivs = $outerDiv.find('div.number-item');
//    console.log(($innerDivs) === (data[index].numbers.length));
//
//    $innerDivs.each(function (i, innerDiv) {
//        console.log((innerDiv.innerHTML) === (data[index].numbers[i].toString()));
//    });
//});

module.exports = solve;

//var myitem=$('#my-ul');
//console.log($('#my-ul').html());
//var kappa =$('#my-ul').html();
//console.log(kappa.replace('li','il'))
