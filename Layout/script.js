const menuToggle = document.getElementById('menuToggle');
const navLinks = document.getElementById('navLinks');

menuToggle.addEventListener('click', () => {
  navLinks.classList.toggle('active');
});

const slides = document.querySelector('.slides');
const totalSlides = slides.children.length;
let index = 0;


  document.querySelector('.next').addEventListener('click', () => {
    index = (index + 1) % totalSlides;
    updateSlide();
  });

  document.querySelector('.prev').addEventListener('click', () => {
    index = (index - 1 + totalSlides) % totalSlides;
    updateSlide();
  });

  function updateSlide() {
    slides.style.transform = `translateX(-${index * 100}%)`;
  }

