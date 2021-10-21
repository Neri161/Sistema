$(document).ready(function () {
    $("#btnRecuperar").click(function () {
        var email = $("#email").val();


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