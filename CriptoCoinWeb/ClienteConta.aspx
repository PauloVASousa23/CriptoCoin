<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteConta.aspx.cs" Inherits="CriptoCoinWeb.ClienteConta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ContainerMonCli">
        <div class="CardMonCli">
            <div class="TextSiglaCli">
                BTC  
                <div class="TextNomeCli">
                    Bitcoin                
                </div>
            </div>
            <div class="VolMonCli">
                     Volume: <span id="VolBTC"> </span>
                <div class="ValorMonCli">
                    Valor: <span id="ValBTC"> </span>
                </div>
            </div>
        </div>
        <div class="CardMonCli">
            <div class="TextSiglaCli">
                    ETH 
                <div class="TextNomeCli">
                    Ethereum
                </div>    
            </div>
            <div class="VolMonCli" >
                    Volume: <span id="VolETH"> </span>
                <div class="ValorMonCli">
                    Valor: <span id="ValETH"> </span>
                </div>
            </div>
        </div>
        <div class="CardMonCli">       
            <div class="TextSiglaCli">
                LTC 
                <div class="TextNomeCli">
                    Litecoin
                </div>    
            </div>
            <div class="VolMonCli">
                     Volume: <span id="VolLTC"> </span>
                <div class="ValorMonCli">
                    Valor: <span id="ValLTC"> </span>
                </div>
            </div>
        </div>
    </div>
    <div>
        <asp:Button Class="ButtonMovCli" ID="ButtonMovCli" runat="server" Text="Movimentar Conta" />
    </div>
    <div>
        <p class="IndCli">Indicações da sua Agência</p>
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
