<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaTransações.aspx.cs" Inherits="CriptoCoinWeb.AgenciaTransações" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="TextBotton1">
                    Filtrar por:
            <div class="BoxBotton1" style="width:20%">
                <div class="inputIcone1">  
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                    <input class="CriptoMoeda" name="Cod.CriptoMoeda" type="text" id="Cod.CriptoMoeda" placeholder="Cód.Cripto Moeda">
            </div>        
            <div class="BoxBotton1" style="width:30%">
                <div class="inputIcone1"> 
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                    <input class="Name1" name="Nome1" type="text" id="Nome1" placeholder="Nome">                             
            </div>
            <div class="BoxBotton1" style="width:20%">
                <div class="inputIcone1">  
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                     <input class="Data" name="Data" type="text" id="Data" placeholder="Data"> 
            </div>                                                      
                    <input class="BtnPesquisar1" type="submit" name="Button1" value="Pesquisar" />          
    </div>
	<div class="TabelTran">
        <table border="0">
            <thead>
                <tr> 
                    <th>ID</th>
                    <th>Nome</th>
                    <th>CPF</th>
                    <th>Cidade</th>
                    <th>Cidade</th>
                </tr>
            </thead>
            <tbody>
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
            </tbody>                     
        </table>
    </div>
    
</asp:Content>
