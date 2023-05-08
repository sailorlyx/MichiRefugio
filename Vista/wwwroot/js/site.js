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

var tercerModal = document.getElementById('tercerModal');
var botonModalTres = document.getElementById('abrirTercerModal');
var cerrarModal = document.getElementsByClassName("cerrarModal")[2];

botonModalTres.onclick = function () {
    tercerModal.style.display = "block";
}

cerrarModal.onclick = function () {
    tercerModal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == tercerModal) {
        tercerModal.style.display = "none";
    }
}

var modalEliminarGato = document.getElementById('modalEliminarGato');
var botonEliminarGato = document.getElementById('abrirEliminarGato');
var cerrarModal = document.getElementsByClassName("cerrarModal")[3];

botonEliminarGato.addEventListener('click', function () {
    modalEliminarGato.style.display = "block";
});

cerrarModal.addEventListener('click', function () {
    modalEliminarGato.style.display = "none";
});

window.addEventListener('click', function (event) {
    if (event.target === modalEliminarGato) {
        modalEliminarGato.style.display = "none";
    }
});

var modalEliminarUsuario = document.getElementById('modalEliminarUsuario');
var botonEliminarUsuario = document.getElementById('abrirEliminarUsuario');
var cerrarModal = document.getElementsByClassName("cerrarModal")[4];

botonEliminarUsuario.onclick = function () {
    modalEliminarUsuario.style.display = "block";
}

cerrarModal.onclick = function () {
    modalEliminarUsuario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarUsuario) {
        modalEliminarUsuario.style.display = "none";
    }
}

var modalEliminarFormulario = document.getElementById('modalEliminarFormulario');
var botonEliminarFormulario = document.getElementById('abrirEliminarFormulario');
var cerrarModal = document.getElementsByClassName("cerrarModal")[5];

botonEliminarFormulario.onclick = function () {
    modalEliminarFormulario.style.display = "block";
}

cerrarModal.onclick = function () {
    modalEliminarFormulario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarFormulario) {
        modalEliminarFormulario.style.display = "none";
    }
}
