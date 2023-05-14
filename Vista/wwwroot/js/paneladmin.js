var modalEliminarUsuario = document.getElementById('modalEliminarUsuario');
var botonesEliminarUsuario = document.getElementsByClassName('abrirEliminarUsuario');
var cerrarModalUsuario = document.getElementById("cerrarModalUsuario");
var botonYesUsu = document.getElementsByClassName("yesUsu")[0];


cerrarModalUsuario.onclick = function () {
    modalEliminarUsuario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarUsuario) {
        modalEliminarUsuario.style.display = "none";
    }
}

function AbrirEliminarUsu(id) {
    window.idUsu = id;
    console.log(id)
    modalEliminarUsuario.style.display = "block";
    botonYesUsu.onclick = function () {
        console.log(id)
        EliminarUsu(id);
    }
}

function EliminarUsu(id) {
    location.href = 'EliminarUsuario/' + id;
}

var modalEliminarGato = document.getElementById('modalEliminarGato');
var botonesEliminarGato = document.getElementsByClassName('abrirEliminarGato');
var cerrarModalGato = document.getElementById("cerrarModalGato");
var botonYesGato = document.getElementsByClassName("yesGato")[0];

cerrarModalGato.onclick = function () {
    modalEliminarGato.style.display = "none";
}

window.onclick = function (event) {
    if (event.target === modalEliminarGato) {
        modalEliminarGato.style.display = "none";
    }
}

function AbrirEliminarGato(id) {
    window.idUsu = id;
    modalEliminarGato.style.display = "block";
    botonYesGato.onclick = function () {
        console.log(id)
        EliminarGato(id);
    }
}

function EliminarGato(id) {
    location.href = 'EliminarGato/' + id;
}


var modalEliminarFormulario = document.getElementById('modalEliminarFormulario');
var botonesEliminarFormulario = document.getElementsByClassName('abrirEliminarFormulario');
var cerrarModalFormulario = document.getElementById("cerrarModalFormulario");
var botonYesFormu = document.getElementsByClassName("yesFormu")[0];

cerrarModalFormulario.onclick = function () {
    modalEliminarFormulario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarFormulario) {
        modalEliminarFormulario.style.display = "none";
    }
}
function AbrirEliminarFormu(id) {
    modalEliminarFormulario.style.display = "block";
    botonYesFormu.onclick = function () {
        EliminarFormu(id);
    }
}

function EliminarFormu(id) {
    location.href = 'EliminarFormu/' + id;
}