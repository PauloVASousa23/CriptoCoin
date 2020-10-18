<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="TransaçõesAgencia.aspx.cs" Inherits="CriptoCoinWeb.TransaçõesAgencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="TextBotton1">
                Filtrar por:
        <div class="BoxBotton1" style="width:20%">
            <div class="inputIcone1">  
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="CriptoMoeda" name="Cod.CriptoMoeda" type="text" id="Cod.CriptoMoeda" placeholder="Cód.Cripto Moeda">
        </div>        
        <div class="BoxBotton1" style="width:30%">
            <div class="inputIcone1"> 
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="Name1" name="Nome1" type="text" id="Nome1" placeholder="Nome">                             
        </div>
        <div class="BoxBotton1" style="width:20%">
            <div class="inputIcone1">  
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                 <input class="Data" name="Data" type="text" id="Data" placeholder="Data"> 
        </div>                                                      
                <input class="BtnPesquisar1" type="submit" name="Button1" value="Pesquisar" />          
</div>
</asp:Content>
