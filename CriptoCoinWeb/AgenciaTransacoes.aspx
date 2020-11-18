<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaTransacoes.aspx.cs" Inherits="CriptoCoinWeb.AgenciaTransações" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="TextBotton1">
                    Filtrar por:
            <div class="BoxBotton1" style="width:20%">
                <div class="inputIcone1">  
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                <input class="CriptoMoeda" name="CriptoMoeda" type="text" id="CriptoMoeda" placeholder="Cripto Moeda">
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
	<div class="Tabel">
        <div class="TabelaTran">
            <table  border="0">
                <thead>
                    <tr> 
                        <th>Criptomoeda</th>
                        <th>Nome</th>
                        <th>Valor</th>
                        <th>Operação</th>
                        <th>Data</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>BTC</td>
                        <td>Adriano Ludwig</td>
                        <td>R$ 350,00</td>
                        <td>Compra</td>
                        <td>15/09/2020</td>
                    </tr>
                    <tr>
                        <td>BTC</td>
                        <td>Diego Medeiros</td>
                        <td>R$ 1.050,00</td>
                        <td>Compra</td>
                        <td>10/09/2020</td>
                    </tr>
                    <tr>
                        <td>ETH</td>
                        <td>Juliana Ferreira</td>
                        <td>R$ 150,00</td>
                        <td>Venda</td>
                        <td>05/09/2020</td>
                    </tr>
                    <tr>
                        <td>LTC</td>
                        <td>Paulo Victor</td>
                        <td>R$ 50,00</td>
                        <td>Compra</td>
                        <td>10/09/2020</td>
                    </tr>
                    <tr>
                        <td>LTC</td>
                        <td>Washington Lima</td>
                        <td>R$ 1.550,00</td>
                        <td>Venda</td>
                        <td>06/09/2020</td>
                    </tr>
                     <tr>
                        <td>BTC</td>
                        <td>Washington Lima</td>
                        <td>R$ 150,00</td>
                        <td>Compra</td>
                        <td>11/09/2020</td>
                    </tr>
                     <tr>
                        <td>ETH</td>
                        <td>Juliana Ferreira</td>
                        <td>R$ 1.050,00</td>
                        <td>Compra</td>
                        <td>20/10/2020</td>
                    </tr>
                     <tr>
                        <td>BTC</td>
                        <td>Juliana Ferreira</td>
                        <td>R$ 350,00</td>
                        <td>Venda</td>
                        <td>10/10/2020</td>
                    </tr>
                      <tr>
                        <td>LTC</td>
                        <td>Diego Medeiros</td>
                        <td>R$ 1.000,00</td>
                        <td>Venda</td>
                        <td>25/10/2020</td>
                    </tr>
                      <tr>
                        <td>BTC</td>
                        <td>Adriano Ludwig</td>
                        <td>R$ 2.000,00</td>
                        <td>Compra</td>
                        <td>29/10/2020</td>
                    </tr>
                </tbody>                     
            </table>
        </div>
    </div>
    
</asp:Content>
