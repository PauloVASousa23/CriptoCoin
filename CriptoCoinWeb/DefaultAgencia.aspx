<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="DefaultAgencia.aspx.cs" Inherits="CriptoCoinWeb.DefaultAgencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="ContainerCards">
    <div class="card">
        <img class="CardImg" src="Content/Img/icone_clientes.png"/>
        <div class="CardText">
                Clientes
        </div>
    </div>
    <div class="card">
        <img class="CardImg" src="Content/Img/icone_transacoes.png"/>
        <div class="CardText">
                Transações
        </div>
    </div>
    <div class="card">
        <img class="CardImg" src="Content/Img/icone_relatorios.png"/>
        <div class="CardText">
                Relatórios
        </div>
    </div>
    <div class="card">
       <img class="CardImg" src="Content/Img/icone_monitoramento.png"/>
       <div class="CardText">
                Monitoramento
       </div>
    </div>
    <div class="card">
       <img class="CardImg" src="Content/Img/icone_indicacoes.png"/>
       <div class="CardText">
                indicações
       </div>
    </div>
</div>

</asp:Content>
