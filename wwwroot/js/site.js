var modal = document.getElementById('modal');
var modal2 = document.getElementById('modal2');
var boton = document.getElementById('abrirModal');
var boton = document.getElementById('abrirModal2');
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
