<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteConsultar.aspx.cs" Inherits="CriptoCoinWeb.ClienteConsultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: 28px;margin-bottom: 0px;color: #10406c;font-weight: bold; margin-top: -20%">Filtrar por:</p>
    <div class="TextBottonCon">
        <div class="BoxBottonCon" style="width:30%">
            <div class="inputIconeCon">  
                <img class="LocalizaCon" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="Codigo" name="Codigo" type="text" id="Codigo" placeholder="Código">
        </div>        
        <div class="BoxBottonCon" style="width:40%">
            <div class="inputIconeCon"> 
                <img class="LocalizaCon" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="Criptomoeda" name="Criptomoeda" type="text" id="Criptomoeda" placeholder="Criptomoeda">                             
        </div>
        <div class="BoxBottonCon" style="width:30%">
            <div class="inputIconeCon">  
                <img class="LocalizaCon" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                 <input class="Data" name="Data" type="text" id="Data" placeholder="Data"> 
        </div>                                                      
                <input class="BtnPesquisar" type="submit" name="Button1" value="Pesquisar" style="width: 10%;height: 60px;" />          
    </div> 
    <div class="Tabel">
        <div class="TabelaConteudo">
            <table border="0">
                <thead>
                    <tr> 
                        <th>Código</th>
                        <th>Criptomoeda</th>
                        <th>Valor</th>
                        <th>Operação</th>
                        <th>Data</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>R$ 740,00</td>
                        <td>Compra</td>
                        <td>15/09/2020</td>
                    </tr>
                    <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>R$ 2.640,00</td>
                        <td>Venda</td>
                        <td>12/09/2020</td>
                    </tr>
                    <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>R$ 5.600,00</td>
                        <td>Compra</td>
                        <td>12/09/2020</td>
                    </tr>
                    <tr>
                       <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>R$ 1.600,00</td>
                        <td>Compra</td>
                        <td>12/09/2020</td>
                    </tr>
                    <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>R$ 3.300,00</td>
                        <td>Venda</td>
                        <td>12/09/2020</td>
                    </tr>
                </tbody>                     
            </table>
        </div>
    </div>
</asp:Content>
