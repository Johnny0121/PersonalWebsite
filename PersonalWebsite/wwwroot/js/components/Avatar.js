var avatarModule = function () {
    var avatars = $('.avatar');

    if (avatars.length == 1) {
        setBackgroundImage(avatars);
    }
    else if (avatars.length > 1) {
        $(avatars).each(function () {
            setBackgroundImage(this);
        });
    }

    function setBackgroundImage(avatarElem) {
        var childImage = $(avatarElem).children('img').first();

        if (childImage) {
            var resourceLocation = $(childImage).attr('src') || '';
            $(avatarElem).css('background-image', `url('${resourceLocation}')`)
        }
    }
}();