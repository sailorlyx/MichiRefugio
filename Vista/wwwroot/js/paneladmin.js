var modalEliminarUsuario = document.getElementById('modalEliminarUsuario');
var botonesEliminarUsuario = document.getElementsByClassName('abrirEliminarUsuario');
var cerrarModalUsuario = document.getElementById("cerrarModalUsuario");

Array.from(botonesEliminarUsuario).forEach(boton => {
    boton.onclick = function () {
        modalEliminarUsuario.style.display = "block";
    }
});

cerrarModalUsuario.onclick = function () {
    modalEliminarUsuario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarUsuario) {
        modalEliminarUsuario.style.display = "none";
    }
}

var modalEliminarGato = document.getElementById('modalEliminarGato');
var botonesEliminarGato = document.getElementsByClassName('abrirEliminarGato');
var cerrarModalGato = document.getElementById("cerrarModalGato");

Array.from(botonesEliminarGato).forEach(boton => {
    boton.onclick = function () {
        modalEliminarGato.style.display = "block";
    }
});

cerrarModalGato.onclick = function () {
    modalEliminarGato.style.display = "none";
}

window.onclick = function (event) {
    if (event.target === modalEliminarGato) {
        modalEliminarGato.style.display = "none";
    }
}

var modalEliminarFormulario = document.getElementById('modalEliminarFormulario');
var botonesEliminarFormulario = document.getElementsByClassName('abrirEliminarFormulario');
var cerrarModalFormulario = document.getElementById("cerrarModalFormulario");

Array.from(botonesEliminarFormulario).forEach(boton => {
    boton.onclick = function () {
        modalEliminarFormulario.style.display = "block";
    }
});

cerrarModalFormulario.onclick = function () {
    modalEliminarFormulario.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modalEliminarFormulario) {
        modalEliminarFormulario.style.display = "none";
    }
}


function AbrirEliminarUsu(id) {
    window.idUsu = id;
    alert(id);
    modalEliminarUsuario.style.display = "block";
}

function EliminarUsu() {
    alert(window.idUsu);
    location.href = 'EliminarUsuario/' + window.idUsu;
}

function EliminarMichi(id) {
    location.href = 'EliminarMichi/' + id;
}

function EliminarFormu(id) {
    location.href = 'EliminarFormulario/' + id;
}