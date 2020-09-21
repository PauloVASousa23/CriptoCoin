<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgenciaMinimizado.aspx.cs" Inherits="CriptoCoinWeb.AgenciaMinimizado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CriptoCoin</title>
     <link rel="stylesheet" type="text/css" href="Content/css/ClienteMinimizado.css" />
</head>
<body>
    <div class="conteudo">
            Colocar o perfil cliente minimizado aqui
        </div> 
    <form class="formPerfis" id="form1" runat="server">         
        <div class="imagem">
            <img src="C:\Users\Washington\Documents\Materias\GitPim4°\CriptoCoin\.png" alt="Moeda Criptocoin" style="width:200px;height:200px;" />
              <!--colocar o logo CriptoCoin depois aqui!-->
         </div>
         <div class="perfis">
             <input class="btnConta" type="submit" name="Button2" value="Conta" id="Button2"/>             
             <input class="btnRelatórios" type="submit" name="Button2" value="Relatórios" id="Button2">             
             <input class="btnIndicações" type="submit" name="Button2" value="Indicações" id="Button2"/>  
             <input class="btnMonitoramento" type="submit" name="Button2" value="Monitoramento" id="Button2"/> 
         </div>
              
    </form>
</body>
</html>
