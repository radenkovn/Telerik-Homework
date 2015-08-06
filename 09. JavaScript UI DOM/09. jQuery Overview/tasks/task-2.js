function solve() {
    function validateSelector(selector) {
        if (typeof selector !== 'string') {
            throw new Error('The provided selector is invalid');
        }
        if ($(selector).length === 0) {
            throw new Error('The provided selector selects nothing!');
        }
    }

    return function (selector) {
        var $buttonsContents,
            $container;
        validateSelector(selector);
        $container = $(selector);
        $buttonsContents = $container.find('\.button,.content');
        $buttonsContents.each(function (idnex, item) {
            var $item = $(item);
            if ($item.hasClass('button')) {
                $item.html('hide');
            }
        });
        $container.on('click', function (ev) {
            var i,
                j,
                length,
                index,
                $currentButton,
                $currentChecker,
                buttonAfterContentExists,
                $currentContent;
            $currentButton = $(ev.target);
            if ($currentButton.hasClass('button')) {
                index = $buttonsContents.index($currentButton);
                for (i = index, length = $buttonsContents.length; i < length; i += 1) {
                    $currentContent = $($buttonsContents[i]);
                    if ($currentContent.hasClass('content')) {
                        for (j = i; j < length; j += 1) {
                            $currentChecker=$($buttonsContents[j]);
                            if ($currentChecker.next().hasClass('button')) {
                                buttonAfterContentExists = true;
                                break;
                            }
                            buttonAfterContentExists = false;
                        }
                        if (buttonAfterContentExists) {
                            if ($currentContent.css('display') !== 'none') {
                                $currentContent.css('display', 'none');
                                $currentButton.html('show');
                                break;
                            } else {
                                $currentContent.css('display', '');
                                $currentButton.html('hide');
                                break;
                            }
                        }
                    }
                }
            }
        });
    };
}

module.exports = solve;