<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteConta.aspx.cs" Inherits="CriptoCoinWeb.ClienteConta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ContainerMonCon">
        <div class="CardMonCon">
            <div class="TextSiglaCon">
                BTC  
                <div class="TextNomeCon">
                    Bitcoin                
                </div>
            </div>
            <div class="VolMonCon">
                     Volume: <span id="VolBTC"> </span>
                <div class="ValorMonCon">
                    Valor: <span id="ValBTC"> </span>
                </div>
            </div>
        </div>
        <div class="CardMonCon">
            <div class="TextSiglaCon">
                    ETH 
                <div class="TextNomeCon">
                    Ethereum
                </div>    
            </div>
            <div class="VolMonCon" >
                    Volume: <span id="VolETH"> </span>
                <div class="ValorMonCon">
                    Valor: <span id="ValETH"> </span>
                </div>
            </div>
        </div>
        <div class="CardMonCon">       
            <div class="TextSiglaCon">
                LTC 
                <div class="TextNomeCon">
                    Litecoin
                </div>    
            </div>
            <div class="VolMonCon">
                     Volume: <span id="VolLTC"> </span>
                <div class="ValorMonCon">
                    Valor: <span id="ValLTC"> </span>
                </div>
            </div>
        </div>
    </div>
    <div>
        <asp:Button Class="ButtonMovCon" ID="ButtonMovCon" runat="server" Text="Movimentar Conta" />
    </div>
    <div>
        <p class="IndCon">Indicações da sua Agência</p>
    </div>
    <div class="BlocoIndicacoes">
          <asp:Button Class="VerConta" runat="server" Text="Ver mais" />
          <div class="IndConta">
            <p class="DataConta"> Data: </p>
            <p class="CriptomoedaConta"> Criptomoeda: </p>
            <p class="ObservacaoConta"> Observação: </p>
          </div>
          <div class="IndConta">
            <p class="DataConta"> Data: </p>
            <p class="CriptomoedaConta"> Criptomoeda: </p>
            <p class="ObservacaoConta"> Observação: </p>
          </div>
          <div class="IndConta">
            <p class="DataConta"> Data: </p>
            <p class="CriptomoedaConta"> Criptomoeda: </p>
            <p class="ObservacaoConta"> Observação: </p>
          </div>  
    </div>
</asp:Content>
