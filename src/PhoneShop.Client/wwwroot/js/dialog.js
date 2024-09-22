window.ShowDialog = function () {
    document.getElementById('my-dialog').showModal()
}

//let currentIndex = 0;

//function showSlides() {
//    const carousel = document.querySelector('.carousel');
//    const totalItems = document.querySelectorAll('.carousel-item').length;

//    if (currentIndex < 0) {
//        currentIndex = totalItems - 3 // Adjust for displaying three items at a time
//    } else if (currentIndex >= totalItems - 2) {
//        currentIndex = 0;
//    }

//    const translateValue = -currentIndex * (100 / 3) + '%';  //Adjust for displaying three items at a time
//    carousel.style.transform = 'transLateX(' + translateValue + ')';
//}

//function prevSlide() {
//    currentIndex--;
//    showSlides();
//}

//function nextSlide() {
//    currentIndex++;
//    showSlides();
//}

////Initial slide
//showSlides();