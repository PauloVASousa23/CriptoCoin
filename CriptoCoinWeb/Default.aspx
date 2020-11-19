<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CriptoCoinWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CriptoCoin</title>
    <link rel="stylesheet" type="text/css" href="Content/css/Login.css" />
</head>
<body>
    <div class="topoBranco"></div>
    <form class="formLogin" id="form1" runat="server" onsubmit="event.preventDefault()">
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
                <input class="btnEntrar" type="submit" name="Button1" value="Entrar" id="Button1" onclick="entrar()">
         </div>

         <div class="Cadastrar">
                Não tem uma conta? Cadastre-se<br/>
                <input class="btnCadastrar" type="submit" name="Button2" value="Cadastre-se" id="Button2" onclick="cadastro()">       
         </div>						
       
        </div>
    </form>

    <script>
        function entrar() {
            $.ajax({
                url: "",
                type: "",
                data: {},
                success: function (data) {
                    console.log(data);
                }
            });
        }

        function cadastro() {
            window.location = "/Cadastro";
        }
    </script>
</body>
</html>
