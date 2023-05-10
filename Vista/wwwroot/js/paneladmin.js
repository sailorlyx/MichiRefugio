var modalEliminarUsuario = document.getElementById('modalEliminarUsuario');
var botonEliminarUsuario = document.getElementById('abrirEliminarUsuario');
var cerrarModalUsuario = document.getElementById("cerrarModalUsuario");

botonEliminarUsuario.onclick = function () {
    modalEliminarUsuario.style.display = "block";
}

cerrarModalUsuario.onclick = function () {
    modalEliminarUsuario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarUsuario) {
        modalEliminarUsuario.style.display = "none";
    }
}

var modalEliminarGato = document.getElementById('modalEliminarGato');
var botonEliminarGato = document.getElementById('abrirEliminarGato');
var cerrarModalGato = document.getElementById("cerrarModalGato");

botonEliminarGato.onclick = function () {
    modalEliminarGato.style.display = "block";
}

cerrarModalGato.onclick = function () {
    modalEliminarGato.style.display = "none";
}

window.onclick = function (event) {
    if (event.target === modalEliminarGato) {
        modalEliminarGato.style.display = "none";
    }
}

var modalEliminarFormulario = document.getElementById('modalEliminarFormulario');
var botonEliminarFormulario = document.getElementById('abrirEliminarFormulario');
var cerrarModalFormulario = document.getElementById("cerrarModalFormulario");

botonEliminarFormulario.onclick = function () {
    modalEliminarFormulario.style.display = "block";
}

cerrarModalFormulario.onclick = function () {
    modalEliminarFormulario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarFormulario) {
        modalEliminarFormulario.style.display = "none";
    }
}