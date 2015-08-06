function solve() {
    return function (selector) {
        var i, len, container, basicDiv, currentItem, currentOption, options, optionContainer, optionDiv, target, selectedIndex, selected = $(selector);
        if (selected.length == 0) {
            throw new Error('You did not select anything');
        }
        basicDiv = '\<div />';
        selected.wrap($(basicDiv).addClass('dropdown-list')).css('display', 'none');
        options = selected.children();
        optionContainer = $(basicDiv).addClass('options-container').css('position', 'absolute;').css('display', 'none');
        for (i = 0, len = options.length; i < len; i += 1) {
            optionDiv = $(basicDiv);
            currentOption = $(options[i]);
            optionDiv.addClass('dropdown-item').attr('data-value', currentOption.attr('value')).attr('data-index', i).html(currentOption.html());
            optionContainer.append(optionDiv);
        }
        currentItem = $(basicDiv).addClass('current').attr('data-value', '').html($(optionContainer.children()[0]).html());
        container = $('.dropdown-list');
        container.append(currentItem);
        container.append(optionContainer);
        currentItem.on('click', function () {
            currentItem.html('Select a value');
            optionContainer.show();
        });
        optionContainer.on('click', '.dropdown-item', function (ev) {
            target = $(ev.target);
            selectedIndex = target.attr('data-index');
            selected.val(target.attr('data-value'));

            currentItem.attr('data-value', target.val());
            currentItem.html(target.html());
            optionContainer.hide()
        });
    };
}
////
//function solve() {
//    var selecTTT = "select", error = "The element must be a SELECT", normalDiv = "<div />", optin = "option", dropList = "dropdown-list", current = "current", r = "options-container", l = "position", i = "absolute", dataval = "data-value", c = "data-index", h = "dropdown-item", p = "click", v = ".current", display = "display", m = "none", f = "Select a value", dropItem = ".dropdown-item";
//    return function (C) {
//        var content = $(C);
//        if (!content.is(selecTTT))throw new Error(error);
//        var E = content.find(optin), T = $(normalDiv).addClass(dropList), iamhere = $(normalDiv).addClass(current);
//        T.append(iamhere);
//        var S = $(normalDiv).addClass(r).hide().css(l, i);
//        E.each(function (t, e) {
//            var n = $(e);
//            t === content.get(0).selectedIndex && iamhere.html(n.html()).attr(dataval, n.val()), $(normalDiv).addClass(h).html(n.html()).attr(dataval, n.val()).attr(c, t).appendTo(S)
//        }), T.append(S), content.before(T), T.prepend(content), T.on(p, v, function () {
//            S.css(display) === m ? (S.show(), iamhere.html(f)) : S.hide()
//        }), T.on(p, dropItem, function () {
//            var target = $(this);
//            iamhere.html(target.html()).attr(dataval, target.val()), content.val(target.attr(dataval)), S.hide()
//        }), content.hide()
//    }
//}


module.exports = solve;
//
//var result = solve();
//var id = 'the-select',
//    select = document.createElement('select'),
//    count = 5;
//select.id = id;
//
//for (var i = 0; i < count; i += 1) {
//    var option = document.createElement('option');
//    option.innerHTML = 'Option #' + (i + 1);
//    option.value = (i + 1) + '';
//    select.appendChild(option);
//}
//
//document.body.innerHTML = select.outerHTML;
//
//result('#' + id);
//
//var clickEvent = document.createEvent('MouseEvents');
//clickEvent.initMouseEvent('click', true, true);
//
//var $dropdown = $('.dropdown-list');
//
//var $current = $dropdown.find('.current');
//$current.get(0).dispatchEvent(clickEvent);
//
//var clickedOption = $dropdown.find('.dropdown-item').get(Math.floor(count / 2));
//clickedOption.dispatchEvent(clickEvent);
//
////console.log(($('#' + id).val())===(clickedOption.getAttribute('data-value')));
//console.log($('#' + id).val());
//console.log($('#' + id)[0].outerHTML);
//console.log(clickedOption.getAttribute('data-value'));
//
//
//var $options = $dropdown.find('.dropdown-item');
//
//$options.each(function (index, option) {
//    var $option = $(option);
//    var $node = $option;
//    while (!($node.hasClass('dropdown-list')) && $node.css('display') !== 'none') {
//        $node = $node.parent();
//    }
//    console.log(($node.hasClass('dropdown-list')) !== true)
//});