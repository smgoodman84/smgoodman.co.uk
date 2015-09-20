function Gallery(photoDirectory, photos, modal, id_photo, id_nextButton, id_previousButton, containerMargin, buttonRadius) {
    var index = 0;
    var maxIndex = photos.length - 1;
    var currentFilename = "";

    var photo = document.getElementById(id_photo);
    var nextButton = document.getElementById(id_nextButton);
    var previousButton = document.getElementById(id_previousButton);

    function next() {
        index = index + 1;
        if (index > maxIndex) {
            index = 0;
        }
        display(index);
    }

    function previous() {
        index = index - 1;
        if (index < 0) {
            index = maxIndex;
        }
        display(index);
    }

    function findIdOfFile(filename) {
        for (var i = 0; i < photos.length; i++) {
            if (photos[i].Filename == filename) {
                return i;
            }
        }

        return -1;
    }

    function selectByFilename(filename) {
        if (currentFilename == filename)
        {
            modal.openModal();
        }

        var id = findIdOfFile(filename);

        if (id == -1) {
            return;
        }

        index = id;
        display(index);
    }

    function sizeGallery() {
        var width = photos[index].Width;
        var height = photos[index].Height;
        var twoMargin = 2 * modal.getMargin();

        var photoWidth = 0;
        var photoHeight = 0;
        var verticalMargin = 0;
        if (window.innerWidth - twoMargin < (window.innerHeight - twoMargin) * width / height) {
            //limit width, calculate height
            photoWidth = window.innerWidth - twoMargin;
            photoHeight = photoWidth * height / width;
            verticalMargin = window.innerHeight - photoHeight;
        } else {
            //limit height, calculate width
            photoHeight = window.innerHeight - twoMargin;
            photoWidth = photoHeight * width / height;
            verticalMargin = twoMargin;
        }

        var modalMargin = (verticalMargin / 2) - containerMargin;
        nextButton.style.top = ((window.innerHeight / 2) - buttonRadius) + 'px';
        previousButton.style.top = ((window.innerHeight / 2) - buttonRadius) + 'px';

        modal.sizeModal(photoWidth, photoHeight, modalMargin);
    }

    function onImageLoaded() {
        sizeGallery();
        modal.openModal();
    }

    function display(index) {
        currentFilename = photos[index].Filename;
        photo.src = photoDirectory + currentFilename;
    }

    nextButton.addEventListener("click", next);
    previousButton.addEventListener("click", previous);
    photo.addEventListener("load", onImageLoaded);

    var result =
    {
        next: next,
        previous: previous,
        selectByFilename: selectByFilename,
        sizeGallery: sizeGallery
    };
    return result;
};
