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