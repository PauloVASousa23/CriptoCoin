var btnMenu = false;

$("#btnHamburguer").on("click", function () {
    if (btnMenu) {
        $("#btnHamburguer").css("transform", "rotate(0deg)");
        $(".menu").removeClass("menuExpandido");
    } else {
        $("#btnHamburguer").css("transform", "rotate(180deg)");
        $(".menu").addClass("menuExpandido");
    }
    btnMenu = !btnMenu;
});

$("#btnHome").on("click", function () {
    location.href = '/Dashboard/';
});

$("#btnPerfil").on("click", function () {
    location.href = '/Dashboard/Perfil';
});

$("#btnConta").on("click", function () {
    location.href = '/Dashboard/Conta';
});

$("#btnHistorico").on("click", function () {
    location.href = '/Dashboard/Historico';
});

$("#btnMercado").on("click", function () {
    location.href = '/Dashboard/Mercado';
});

$("#btnConfiguracao").on("click", function () {
    location.href = '/Dashboard/Configuracao';
});
