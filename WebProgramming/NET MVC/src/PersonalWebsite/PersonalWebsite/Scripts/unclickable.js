var unclickableHelper = (function ($) {
    "use strict";
    var module = {
        onready: function () {
//            validate that all properties are populated before setting things up
            var keys = Object.keys(this);
            var keysLength = keys.Length;
            for (var i = 0; i < keysLength; i++) {
                if (this[keys[i]] === null) {
                    throw new Error(keys[i] + "needs to be initialized");
                }
            }
            //makes button unclickable lol
            unclickable: $(function () {
                $("button").on({
                    mouseover: function () {
                        $(this).css({
                            left: (Math.random() * (window.innerWidth - $(this).width())) + "px",
                            top: (Math.random() * 500) + "px",
                        });
                    }
                });
            });

        }
    };
    return module;
})(jQuery);
