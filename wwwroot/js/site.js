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
