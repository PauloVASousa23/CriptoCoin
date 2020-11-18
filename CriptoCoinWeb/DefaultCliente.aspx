<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="DefaultCliente.aspx.cs" Inherits="CriptoCoinWeb.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ContainerCardsCli">
        <div class="CardCli">
            <img class="CardImgCli" src="Content/Img/icone_clientes.png"/>
            <div class="CardTextCli">
                Conta
            </div>
        </div>
        <div class="CardCli">
            <img class="CardImgCli" src="Content/Img/icone_relatorios.png"/>
            <div class="CardTextCli">
                Relatórios
            </div>
        </div>
        <div class="CardCli">
            <img class="CardImgCli" src="Content/Img/icone_monitoramento.png"/>
        <div class="CardTextCli">
                Monitoramento
       </div>
    </div>
    <div class="CardCli">
       <img class="CardImgCli" src="Content/Img/icone_indicacoes.png"/>
       <div class="CardTextCli">
                indicações
       </div>
    </div>
</div>

</asp:Content>
