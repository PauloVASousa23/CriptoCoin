<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CriptoCoinWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CriptoCoin</title>
    <link rel="stylesheet" type="text/css" href="Content/css/Login.css" />
</head>
<body>
    <form class="formLogin" id="form1" runat="server">
        <div class="boxLogin">
            
          <div class="Logo">
              CriptoCoin
         </div>
         
         <div class="Acesse">
                Acesse<br />
                <div class="inputGrupo">
                    <div class="inputIcone">
                        <img class="Person" src="Content/Img/icone_person.png"/>
                    </div>
                    <input name="Usuário" type="text" value="Usuário" id="Usuário">
                </div>          
                <div class="inputGrupo">
                    <div class="inputIcone">
                        <img class="Cadeado" src="Content/Img/icone_cadeado.png"/>
                    </div>
                    <input name="Senha" type="text" value="Senha" id="Senha">
                </div>                             
                <input class="btnEntrar" type="submit" name="Button1" value="Entrar" id="Button1">
         </div>

         <div class="Cadastrar">
                Não tem uma conta? Cadastre-se<br/>
                <input class="btnCadastrar" type="submit" name="Button2" value="Cadastre-se" id="Button2">       
         </div>						
       
        </div>
    </form>
</body>
</html>
