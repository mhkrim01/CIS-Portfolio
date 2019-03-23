/*google analytics to Track outbound link*/
var trackOutboundLink = function (url) {
    ga('send', 'event', 'outbound', 'click', url, {
        'transport': 'beacon',
        'hitCallback': function () {
            document.location = url;
            alert("You are navigating to a new page");/** lets user know they are leaving site **/
        }
    });
}