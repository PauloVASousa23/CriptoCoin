﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMaximizado.aspx.cs" Inherits="CriptoCoinWeb.AdminMaximizado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CriptoCoin</title>
     <link rel="stylesheet" type="text/css" href="Content/css/AdminMaximizado.css" />
</head>
<body>
    <div class="conteudo">
            Colocar o perfil Admin maximizado neste campo
        </div> 
    <form class="formPerfis" id="form1" runat="server">         
        <div class="imagem">
            <img src="C:\Users\Washington\Documents\Materias\GitPim4°\CriptoCoin\images\Logo_CriptoCoin_transp_branco.png" alt="Moeda Criptocoin" style="width:200px;height:200px;" />
              <!--colocar o logo CriptoCoin depois aqui!-->
         </div>
         <div class="perfis">
             <input class="btnGerenciarContas" type="submit" name="Button2" value="Gerenciar Contas" id="Button2"/> 
             <input class="btnConsultar" type="submit" name="Button2" value="Consultar" id="Button2"/>
             <input class="btnCadastrar" type="submit" name="Button2" value="Cadastrar" id="Button2"/>
             <input class="btnAlterar" type="submit" name="Button2" value="Alterar" id="Button2"/>
             <input class="btnTransações" type="submit" name="Button2" value="Transações" id="Button2"/> 
             <input class="btnRelatórios" type="submit" name="Button2" value="Relatórios" id="Button2">             
             <input class="btnIndicações" type="submit" name="Button2" value="Indicações" id="Button2"/>  
             <input class="btnMonitoramento" type="submit" name="Button2" value="Monitoramento" id="Button2"/>
             <input class="btnGerenciarPerfil" type="submit" name="Button2" value="Gerenciar Perfis" id="Button2"/> 
         </div>
              
    </form>
</body>
</html>