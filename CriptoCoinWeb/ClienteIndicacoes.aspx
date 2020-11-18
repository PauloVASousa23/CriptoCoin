<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteIndicacoes.aspx.cs" Inherits="CriptoCoinWeb.ClienteIndicações" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="TitleInd">
        <p>Indicações da sua agência</p>
    </div>  
    <div class="BordarInd">
        <div class="Indicacoes">
            <p class="DataEsqInd">Data:</p>
            <p class="ObsEsqInd">Observação:</p>
            <p class="CriptCentral">Criptomoeda:</p>
            <textarea class="TextInd" id="TextArea1" cols="20" rows="4"></textarea>
        </div>
        <div class="Indicacoes">
            <p class="DataEsqInd">Data:</p>
            <p class="ObsEsqInd">Observação:</p>
            <p class="CriptCentral">Criptomoeda:</p>
            <textarea class="TextInd" id="TextArea2" cols="20" rows="4"></textarea>
        </div>
    </div>
</asp:Content>
