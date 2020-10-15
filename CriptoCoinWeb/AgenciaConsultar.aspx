<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaConsultar.aspx.cs" Inherits="CriptoCoinWeb.AgenciaConsultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="TextBotton">
                Filtrar por:
        <div class="BoxBotton" style="width:10%">
            <div class="inputIcone">  
                <img class="Localiza" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="ID" name="ID" type="text" id="ID" placeholder="ID">
        </div>        
        <div class="BoxBotton" style="width:250px">
            <div class="inputIcone"> 
                <img class="Localiza" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="Name" name="Nome" type="text" id="Nome" placeholder="Nome">                             
        </div>
        <div class="BoxBotton" style="width:20%">
            <div class="inputIcone">  
                <img class="Localiza" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                 <input class="CPF" name="CPF" type="text" id="CPF" placeholder="CPF"> 
        </div>                                                      
                <input class="BtnPesquisar" type="submit" name="Button1" value="Pesquisar" />          
    </div> 
    <div class="Tabel">
        <table border="0">
            <tr> 
                <th>ID</th>
                <th>Nome</th>
                <th>CPF</th>
                <th>Cidade</th>
            </tr>
            <tr>
                <td>001</td>
                <td>Adriano Ludwig</td>
                <td>000.000.000-00</td>
                <td>São Paulo</td>
            </tr>
            <tr>
                <td>002</td>
                <td>Diego Medeiros</td>
                <td>000.000.000-00</td>
                <td>São Paulo</td>
            </tr>
            <tr>
                <td>003</td>
                <td>Juliana Ferreira</td>
                <td>000.000.000-00</td>
                <td>São Paulo</td>
            </tr>
            <tr>
                <td>004</td>
                <td>Paulo Victor</td>
                <td>000.000.000-00</td>
                <td>São Paulo</td>
            </tr>
            <tr>
                <td>005</td>
                <td>Washington Lima</td>
                <td>000.000.000-00</td>
                <td>São Paulo</td>
            </tr>
            
        </table>
    </div>
    <div class="Cartao">
        <div class="Borda">
            <img class="Person" src="Content/Img/icone_person_preto.png"/>
        </div>

    </div>
        
</asp:Content>
