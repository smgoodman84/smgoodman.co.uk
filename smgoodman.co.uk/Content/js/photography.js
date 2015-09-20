(function () {
    var modal = Modal('modal', 'modal-close', 50, 'gallery-photo', 'modal-container');
    var gallery = Gallery('/Content/images/portfolio/', Photos, modal, 'gallery-photo', 'gallery-next', 'gallery-previous', 15, 48);

    //register event handlers
    function registerPhotoClickHandler(element, index, array) {
        element.addEventListener("click", function () {
            var photoUrl = element.getAttribute("data-fullsize-url");
            gallery.selectByFilename(photoUrl)
        });
    }

    var photos = document.getElementsByClassName('ph-thumb');
    Array.prototype.forEach.call(photos, registerPhotoClickHandler);

    window.addEventListener("resize", function () {
        gallery.sizeGallery();
    });

    window.addEventListener("orientationchange", function () {
        gallery.sizeGallery();
    });

    document.onkeydown = function (e) {
        if (!e) e = event;
        switch (e.keyCode) {
            case 27: //ESC
                modal.closeModal();
                break;
            case 37: //LEFT
                gallery.previous();
                break;
            case 39: //RIGHT
                gallery.next();
                break;
        }
    }
})();