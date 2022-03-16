var slideIndex = 1;
var slideIndex2 = 0;
showSlides(slideIndex);
// showSlidesAutomatic();

// Controle de Próximo/Anterior
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Controles de imagem em miniatura
function currentSlide(n) {
  showSlides(slideIndex = n);
}

// Função para exibir as imagens
function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) { slideIndex = 1 }
  if (n < 1) { slideIndex = slides.length }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex - 1].style.display = "block";
  dots[slideIndex - 1].className += " active";
}

// function showSlidesAutomatic() {
//   var i;
//   var slides = document.getElementsByClassName("mySlides");
//   var dots = document.getElementsByClassName("dot");
//   for (i = 0; i < slides.length; i++) {
//     slides[i].style.display = "none";
//   }
//   slideIndex2++;
//   if (slideIndex2 > slides.length) { slideIndex2 = 1 }

//   for (i = 0; i < dots.length; i++) {
//     dots[i].className = dots[i].className.replace(" active", "");
//   }
  
//   slides[slideIndex2 - 1].style.display = "block";
//   dots[slideIndex2 - 1].className += " active";
//   setTimeout(showSlidesAutomatic, 2000);
// }

var slideIndex = 1;
var slideIndex2 = 0;
mostraSlides(slideIndex);

// Controle de Próximo/Anterior
function adicionaSlides(n) {
  mostraSlides(slideIndex += n);
}

// Controles de imagem em miniatura
function atualSlide(n) {
  mostraSlides(slideIndex = n);
}

// Função para exibir as imagens
function mostraSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlidesProd");
  var dots = document.getElementsByClassName("ponto");
  if (n > slides.length) { slideIndex = 1 }
  if (n < 1) { slideIndex = slides.length }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex - 1].style.display = "block";
  dots[slideIndex - 1].className += " active";
}


function validaSenha(){
    var campoSenha = document.getElementById("txtSenha");
    var valorSenha = txtSenha.value;

    if(valorSenha.length < 6){
        document.getElementById("txtSenha").style.color="red"
        alert("Senha precisa ter ao menos 6 caracteres");
        return false;
    }

    else if(valorSenha.length == 0){
        alert("Digite sua senha");
        return false;
    }

    else
    {  
        document.getElementById("txtSenha").style.color="black"
        return true;
    }
}


