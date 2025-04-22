// Menu Toggle
const menuToggle = document.getElementById('menuToggle');
const navLinks = document.getElementById('navLinks');

menuToggle.addEventListener('click', () => {
  navLinks.classList.toggle('active');
});

// Carrossel
const slides = document.querySelector('.slides');
const totalSlides = slides.children.length;
let index = 0;

document.querySelector('.next').addEventListener('click', () => {
  index = (index + 1) % totalSlides;  // Passa para o próximo slide, e volta ao primeiro quando chegar no final
  updateSlide();
});

document.querySelector('.prev').addEventListener('click', () => {
  index = (index - 1 + totalSlides) % totalSlides;  // Volta para o slide anterior, e vai para o último quando chegar no início
  updateSlide();
});

// Função para atualizar o carrossel
function updateSlide() {
  slides.style.transform = `translateX(-${index * 100}%)`;
}

// Função para autoscroll (opcional)
setInterval(() => {
  index = (index + 1) % totalSlides;  // Faz o carrossel avançar automaticamente
  updateSlide();
}, 3000);  // Muda a cada 3 segundos
