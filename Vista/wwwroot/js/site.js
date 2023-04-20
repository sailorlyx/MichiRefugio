var modal = document.getElementById('modal');
var boton = document.getElementById('abrirModal');
var span = document.getElementsByClassName("cerrarModal")[0];

boton.addEventListener("click", function () {
    modal.style.display = "block";
});

span.addEventListener("click", function () {
    modal.style.display = "none";
});

window.addEventListener("click", function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
});

var segundoModal = document.getElementById('segundoModal');
var botonModal = document.getElementById('abrirSegundoModal');
var cerrarModal = document.getElementsByClassName("cerrarModal")[1];

botonModal.onclick = function () {
    segundoModal.style.display = "block";
}

cerrarModal.onclick = function () {
    segundoModal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == segundoModal) {
        segundoModal.style.display = "none";
    }
}