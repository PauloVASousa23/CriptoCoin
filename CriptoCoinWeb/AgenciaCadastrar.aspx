<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaCadastrar.aspx.cs" Inherits="CriptoCoinWeb.AgenciaCadastrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="boxCadastro">
    Cadastro de Cliente
    <div class="inputGrupo">
        <img class="person" src="Content/Img/icone_person.png"/>
        <input name="Nome" type="text" value="" id="Nome" placeholder ="Nome Completo">
    </div>
    <div class="campos">
        <div class="inputGrupo" style="width:50%">
            <img class="person" src="Content/Img/icone_person.png"/>            
            <input name="Rg" type="text" id="Rg" placeholder="RG">
        </div>
        <div class="inputGrupo" style="width:50%">
            <img class="person" src="Content/Img/icone_person.png"/>      
            <input name="Cpf" type="text" id="Cpf" placeholder="CPF">
        </div> 
    </div>
    <div class="campos">
        <div class="inputGrupo" style="width:50%" >            
            <img class="Telefone" src="Content/Img/icone_telefone.png"/>                                        
            <input name="Telefone" type="text" id="Telefone" placeholder="Telefone">
        </div> 
        <div class="inputGrupo" style="width:50%">            
            <img class="Email" src="Content/Img/icone_email.png"/> 
            <input name="E-mail" type="text" id="E-mail" placeholder="E-mail">
        </div> 
    </div> 
    <div class="campos">
        <div class="inputGrupo" style="width:35%">
            <img class="Cep" src="Content/Img/icone_cep.png"/> 
            <input name="Cep" type="text" id="Cep" placeholder="CEP">
        </div> 
        <div class="inputGrupo" style="width:25%">      
            <img class="Cidade" src="Content/Img/icone_cidade.png"/> 
        <input name="Cidade" type="text" id="Cidade" placeholder="Cidade">
        </div> 
        <div class="inputGrupo" style="width:50%">
            <img class="Cidade" src="Content/Img/icone_cidade.png"/> 
            <input name="Estado" type="text" id="Estado" placeholder="Estado">
        </div>
    </div>    
    <div class="inputGrupo" >
        <img class="Logradouro" src="Content/Img/icone_endereco.png"/> 
        <input name="Rua" type="text" id="Rua" placeholder="Logradouro">
    </div> 
    <div class="Mensagem">
        Será gerado uma senha com os 6 primeiros dígitos do CPF do cliente!
    </div>          
        <div class="Botoes">
            <input class="btnLimpar" type="submit" name="Button1" value="Limpar" id="Button1">
            <input class="btnCadastrar" type="submit" name="Button1" value="Cadastrar" id="Button2">
        </div>              
    </div>
</asp:Content>
