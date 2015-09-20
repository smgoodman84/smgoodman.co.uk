var Util = (function () {
    function hasClass(element, cls) {
        return element.className.match(new RegExp('(\\s|^)' + cls + '(\\s|$)'));
    }

    function addClass(element, cls) {
        if (!hasClass(element, cls)) element.className += " " + cls;
    }

    function removeClass(element, cls) {
        if (hasClass(element, cls)) {
            var reg = new RegExp('(\\s|^)' + cls + '(\\s|$)');
            element.className = element.className.replace(reg, ' ');
        }
    }


    var util =
    {
        addClass: addClass,
        removeClass: removeClass
    }
    return util;
})();