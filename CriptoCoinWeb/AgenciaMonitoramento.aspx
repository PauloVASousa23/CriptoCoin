<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaMonitoramento.aspx.cs" Inherits="CriptoCoinWeb.AgenciaMonitoramento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ContainerMon">
        <div class="CardMon">
            <div class="TextSigla">
                BTC  
                <div class="TextNome">
                    Bitcoin                
                </div>
            </div>
            <div class="VolMon">
                     Volume: <span id="VolBTC"> </span>
                <div class="ValorMon">
                    Valor: <span id="ValBTC"> </span>
                </div>
            </div>
        </div>
        <div class="CardMon">
            <div class="TextSigla">
                    ETH 
                <div class="TextNome">
                    Ethereum
                </div>    
            </div>
            <div class="VolMon" >
                    Volume: <span id="VolETH"> </span>
                <div class="ValorMon">
                    Valor: <span id="ValETH"> </span>
                </div>
            </div>
        </div>
        <div class="CardMon">       
            <div class="TextSigla">
                LTC 
            <div class="TextNome">
                Litecoin
            </div>    
            </div>
            <div class="VolMon">
                     Volume: <span id="VolLTC"> </span>
                <div class="ValorMon">
                    Valor: <span id="ValLTC"> </span>
                </div>
            </div>
        </div>
        <div class="DadosMon"> 
            Dados atualizados em: <span id="diaAtual"></span>
        </div>

    
    </div>
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"
  integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0="
  crossorigin="anonymous"></script>

    <script>

        (
            () => {
                let $volBTC = $("#VolBTC");
                let $volETH = $("#VolETH");
                let $volLTC = $("#VolLTC");
                let $valBTC = $("#ValBTC");
                let $valETH = $("#ValETH");
                let $valLTC = $("#ValLTC");

                $.ajax({
                    type: "GET",
                    url: "https://www.mercadobitcoin.net/api/btc/ticker/",
                    success: function (data) {
                        $volBTC.html(Number(data.ticker.vol).toFixed(2));
                        $valBTC.html(Number(data.ticker.buy).toFixed(2));
                    },
                    error: console.log(""),
                    dataType: "JSON"
                });

                $.ajax({
                    type: "GET",
                    url: "https://www.mercadobitcoin.net/api/eth/ticker/",
                    success: function (data) {
                        $volETH.html(Number(data.ticker.vol).toFixed(2));
                        $valETH.html(Number(data.ticker.buy).toFixed(2));
                    },
                    error: console.log(""),
                    dataType: "JSON"
                });

                $.ajax({
                    type: "GET",
                    url: "https://www.mercadobitcoin.net/api/ltc/ticker/",
                    success: function (data) {
                        $volLTC.html(Number(data.ticker.vol).toFixed(2));
                        $valLTC.html(Number(data.ticker.buy).toFixed(2));
                    },
                    error: console.log(""),
                    dataType: "JSON"
                });

                let data = new Date();
                let dia = (Number(data.getDay()) + 1) + "/" + (Number(data.getMonth()) + 1) + "/" + data.getFullYear() + " " + data.getHours() + ":" + data.getMinutes();

                let $diaAtual = $("#diaAtual");
                $diaAtual.html(dia);
            }  
        )();

    </script>
</asp:Content>
