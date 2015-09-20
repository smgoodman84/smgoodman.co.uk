function Modal(id_modal, id_modalClose, margin, id_modalContent, id_modalContainer) {
    var activeModalClassName = 'modal-active';

    var modal = document.getElementById(id_modal);
    var modalContainer = document.getElementById(id_modalContainer);
    var modalContent = document.getElementById(id_modalContent);
    var modalClose = document.getElementById(id_modalClose);
    var body = window.document.body;

    function closeModal() {
        Util.removeClass(modal, activeModalClassName);
        body.style.overflow = "auto";
    }

    function openModal() {
        Util.addClass(modal, activeModalClassName);
        body.style.overflow = "hidden";
    }

    function sizeModal(width, height, margin) {
        modalContainer.style.margin = margin + 'px auto';
        modalContainer.style.height = height + 'px';
        modalContainer.style.width = width + 'px';

        modalContent.style.height = height + 'px';
        modalContent.style.width = width + 'px';
    }

    function getMargin() {
        return margin;
    }

    modalClose.addEventListener("click", closeModal)

    var result =
    {
        openModal: openModal,
        closeModal: closeModal,
        sizeModal: sizeModal,
        getMargin: getMargin,
    };
    return result;
}