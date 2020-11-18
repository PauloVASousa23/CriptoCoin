<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaIndicacoes.aspx.cs" Inherits="CriptoCoinWeb.AgenciaIndicacoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="boxInd">
    <div class="Titulo">
        <p class="TitInd"> Cadastrar indicação</p>
    </div>
    <div class="EsqNomes">
        <p class="SepIndEsq"> Título: </p>
        <p class="SepIndEsq"> Data: </p>
        <p class="SepIndEsq"> Observação: </p>
    </div>
    <div class="DirNomes">
        <p class="SepIndDir"> Criptomoeda: </p>
    </div>
       
    <div class="InputIndicacoes">    
        <input class="TituloInd" name="TitInd"  id="TitInd" >
        <input class="DataInd" name="DataInd"   id="DataInd" >
        <input class="ObservacaoInd" name="ObservacaoInd"   id="ObservacaoInd" >
    </div>   
    <div class="Moedas">
        <asp:DropDownList ID="Moedas" runat="server">  </asp:DropDownList>
    </div>
    <div class="BotoesInd">
	    <input class="btnLimparInd" type="submit" name="Button1" value="Limpar" id="Button1">
        <input class="btnCadastrarInd" type="submit" name="Button1" value="Cadastrar" id="Button2">
    </div> 

</div>

</asp:Content>
