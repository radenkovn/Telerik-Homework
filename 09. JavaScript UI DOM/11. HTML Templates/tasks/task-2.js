/* globals $ */

function solve() {

    return function (selector) {
        var template = '\<div class="container">'+
        '\<h1>Animals</h1>'+
        '\<ul class="animals-list">'+
        '\{{#each animals}}'+
        '\<li>'+
        '\{{#if url}}'+
        '\<a href={{url}}>See a {{name}}</a>'+
        '\{{else}}'+
        '\<a href="http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg">No link for {{name}} , here is Batman!</a>'+
        '\{{/if}}'+
        '\</li>'+
        '\{{/each}}'+
        '\</ul>'+
        '\</div>';
        $(selector).html(template);
    };
}
//var result=solve();


////
//const BATMAN_LINK = 'http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg';
//document.body.innerHTML = '<script id="template"></script>';
//result('#template');
//var handlebars = Handlebars;
//var animals = [],
//    count = 15,
//    animal,
//    i;
//for (i = 0; i < count; i += 1) {
//    animal = {
//        name: 'Animal #' + i,
//    };
//    if (i % 3 !== 0) {
//        animal.url = 'http://animal-' + i + '.com';
//    }
//    animals.push(animal);
//}
//
//var data = { animals };
//
//var templateFunc = handlebars.compile($('#template').html());
//
//var output = templateFunc(data);
//
//document.body.innerHTML = output;
//
//var $container = $('div.container');
//var $list = $container.find('ul.animals-list');
//
//var $items = $list.find('li');
//$items.each(function (index, item) {
//    var $item = $(item);
//    var $link = $item.find('a');
//    console.log(($link).length==1);
//    if (animals[index].url) {
//        console.log(($link.attr('href'))==(animals[index].url));
//        console.log(($link.html())===('See a '+animals[index].name));
//    }
//    else {
//        console.log(($link.attr('href'))===(BATMAN_LINK));
//        console.log(($link.html())===('No link for '+animals[index].name+', here is Batman!'));
//    }
//});

module.exports = solve;