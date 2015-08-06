// I am really not sure about this one but i think this should be sufficient.

(function () {
    var addScroll,
        browser = navigator.appName,
        positionX = 0,
        positionY = 0;
    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }
    document.onmousemove = mouseMove;
    function mouseMove(event) {
        if (browser === 'Netscape') {
            positionX = event.pageX - 5;
            positionY = event.pageY;
        } else {
            positionX = event.x - 5;
            positionY = event.y;
        }
        if (browser === 'Netscape') {
            if (document.layers['ToolTip'].visibility === 'show') {
                PopTip(event);
            }
        } else {
            if (document.getElementById('ToolTip').style.visibility === 'visible') {
                PopTip(event);
            }
        }
    }

    function PopTip(event) {
        var layer;
        if (browser === "Netscape") {
            layer = document.layers['ToolTip'];
            if ((positionX + 120) > window.innerWidth) {
                positionX = window.innerWidth - 150;
            }
            layer.left = positionX + 10;
            layer.top = positionY + 15;
            layer.visibility = 'show';
        } else {
            layer = document.getElementById('ToolTip');
            if (layer) {
                positionX = event.x - 5;
                positionY = event.y;
                if (addScroll) {
                    positionX = positionX + document.body.scrollLeft;
                    positionY = positionY + document.body.scrollTop;
                }
                if ((positionX + 120) > document.body.clientWidth) {
                    positionX = positionX - 150;
                }
                layer.style.pixelLeft = positionX + 10;
                layer.style.pixelTop = positionY + 15;
                layer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {
        var layer;
        if (browser === "Netscape") {
            layer = document.layers['ToolTip'];
            layer.visibility = 'hide';
        }
        else {
            layer = document.getElementById('ToolTip');
            layer.style.visibility = 'hidden';
        }
    }

    function HideMenu(menuName) {
        var layer;
        if (browser === "Netscape") {
            layer = document.layers[menuName];
            layer.visibility = 'hide';
        } else {
            layer = document.getElementById(menuName);
            layer.style.visibility = 'hidden';
        }
    }

    function ShowMenu(menuName) {
        var layer;
        if (browser === "Netscape") {
            layer = document.layers[menuName];
            layer.visibility = 'show';
        } else {
            layer = document.getElementById(menuName);
            layer.style.visibility = 'visible';
        }
    }
}());
