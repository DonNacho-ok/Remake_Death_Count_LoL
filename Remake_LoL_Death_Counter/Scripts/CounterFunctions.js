$(function () {
    $("#EnviarDatos").click(function () {
        $.ajax({
            type: "GET", 
            url: ROOT + 'Counter/GetTotalDeath',
            data: ({
                NombreInvocador = $("#NombreInvocador").val(),
                Servidor = $("#Servidor").val()
            }),
            dataType = JSON,
            success: function (data) {
                console.log(data),
            },
            error: function () {
                console.log("Algo Salió Mal...")
            }
        })
    })
})