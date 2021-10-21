$(document).ready(function () {
    $("#btnIngresar").click(function () {
        var email = $("#email").val();
        var pass = $("#pass").val();


        if (email == "" || email == null) {
            Swal.fire({
                //error
                type: 'error',
                title: 'Error',
                text: '¡Ingresar el Correo!',
            });
            $("#email").focus();
            return false;
        }
        if (pass == "" || pass == null) {
            Swal.fire({
                //error
                type: 'error',
                title: 'Error',
                text: '¡Ingresar la Contraseña!',
            });
            $("#pass").focus();
            return false;
        }
    });
    $("#btnRecuperar").click(function () {
        var email = $("#email").val();
        var pass = $("#pass").val();


        if (email == "" || email == null) {
            Swal.fire({
                //error
                type: 'error',
                title: 'Error',
                text: '¡Ingresa el Correo!',
            });
            $("#email").focus();
            return false;
        }
    });
});