<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CriptoCoinWeb.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Content/css/Cadastro.css" />
</head>
<body>
    <form class="formCadastrar" id="form1" runat="server">
        <div class="boxCadastrar">
            <div class="boxCriptoCoin">
                CriptoCoin
            </div>
            <div class="boxCadastro">
                Cadastre-se
                <input name="Nome" type="text" id="Nome">
                <input name="RG" type="text" id="RG">
                <input name="CPF" type="text" id="CPF">
                <input name="Telefone" type="text" id="Telefone">
                <input name="E-mail" type="text" id="E-mail">
                <input name="CEP" type="text" id="CEP">
                <input name="Cidade" type="text" id="Cidade">
                <input name="Estado" type="text" id="Estado">
                <input name="Rua" type="text" id="Rua">
                <input name="Senha" type="text" id="Senha">
                <input name="confirmarSenha" type="text" id="ConfirmarSenha">
                <input class="btnLimpar" type="submit" name="Button2" value="Limpar" id="Button2">
                <input class="btnCadastrar1" type="submit" name="Button2" value="Cadastrar" id="Button2">
            </div>
        </div>
    </form>
</body>
</html>
