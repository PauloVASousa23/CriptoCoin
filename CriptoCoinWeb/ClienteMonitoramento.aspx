<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteMonitoramento.aspx.cs" Inherits="CriptoCoinWeb.ClienteMonitoramento" %>
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
</asp:Content>
