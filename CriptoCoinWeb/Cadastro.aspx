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
                <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Nome" type="text" value="" id="Nome">
                </div>          
                <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Rg" type="text" id="Rg">
                </div>
                <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Cpf" type="text" id="Cpf">
                </div> 
                <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Telefone" type="text" id="Telefone">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="E-mail" type="text" id="E-mail">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Cep" type="text" id="Cep">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Cidade" type="text" id="Cidade">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Estado" type="text" id="Estado">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Rua" type="text" id="Rua">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="Senha" type="text" id="Senha">
                </div> 
                 <div class="inputGrupo">
                    <div class="inputIcone">

                    </div>
                    <input name="confirmaSenha" type="text" id="confirmaSenha">                  
                </div> 
                <input class="btnLimpar" type="submit" name="Button1" value="Limpar" id="Button1">
                <input class="btnCadastrar" type="submit" name="Button1" value="Cadastrar" id="Button1">
                         
            </div>
        </div>
    </form>
</body>
</html>
