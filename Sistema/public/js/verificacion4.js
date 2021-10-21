$(document).ready(function () {
    $("#btnCambiar").click(function () {
        var pass1 = $("#pass1").val();
        var pass2 = $("#pass2").val();

        if ((pass1 == "" || pass1 == null) || (pass2 == "" || pass2 == null)) {
            Swal.fire({
                //error
                type: 'error',
                title: 'Error',
                text: '¡Ingresar la Contraseña!',
            });
            $("#pass1").focus();
            return false;
        }
        if (pass1 != pass2) {
            Swal.fire({
                //error
                type: 'error',
                title: 'Error',
                text: '¡Las contraseñas no son iguales!',
            });
            $("#pass1").focus();
            return false;
        }
    });
});