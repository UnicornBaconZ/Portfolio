document.addEventListener('DOMContentLoaded', function () {
    const scrollableList = document.querySelector('.media-list');
    const scrollMultiplier = 3;

    scrollableList.addEventListener('wheel', function (e) {
        e.preventDefault();
        scrollableList.scrollBy({
            left: e.deltaY * scrollMultiplier,
            behavior: 'smooth'
        });
    });
});