<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteRelatorios.aspx.cs" Inherits="CriptoCoinWeb.ClienteRelatorios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="RadioRel"> 
        <P style="margin-bottom: -1px;">Período:</P>
            <input id="Radio1" type="radio" />
            <asp:Label class="NegritoRel" ID ="Label1" runat="server" Text="Diário"></asp:Label>
            <input id="Radio2" type="radio" />
            <asp:Label class="NegritoRel" ID="Label2" runat="server" Text="Semanal"></asp:Label>
            <input id="Radio3" type="radio" />
            <asp:Label class="NegritoRel" ID="Label3" runat="server" Text="Mensal"></asp:Label>         
    </div>
    <div class="TextRel"> 
        <P>Filtrar por busca:</P>                  
    </div>
    <div class="BottonRel">            
        <div class="BotoesRel" style="width:15%">
            <div class="inputIcone1">  
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
            <input class="TextRelCod" name="TextRelCod" type="text" id="TextRelCod" placeholder="Código">
        </div>        
        <div class="BotoesRel" style="width:30%">
            <div class="inputIcone1"> 
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
            <input class="TextNameCrip" name="TextNameCrip" type="text" id="TextNameCrip" placeholder="Criptomoeda">                             
        </div>
        <div class="BotoesRel" style="width:21%">
            <div class="inputIcone1">  
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
            <input class="TextRelOpe" name="TextRelOpe" type="text" id="TextRelOpe" placeholder="Operação"> 
        </div> 
        <div class="BotoesRel" style="width:25%">
            <div class="inputIcone1">  
                <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
            </div>
            <input class="TextRelData" name="TextRelData" type="text" id="TextRelData" placeholder="Data"> 
        </div>             
    </div>
    <div class="Tabel">
        <div class="TabelaRel">
            <table border="0">
                <thead>
                    <tr> 
                        <th>Código</th>
                        <th>Criptomoeda</th>
                        <th>Operação</th>
                        <th>Data</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>Compra</td>
                        <td>15/11/2020</td>
                    </tr>
                   <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>Venda</td>
                        <td>13/10/2020</td>
                    </tr>
                  <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>Compra</td>
                        <td>11/10/2020</td>
                    </tr>
                   <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>Compra</td>
                        <td>10/09/2020</td>
                    </tr>
                   <tr>
                        <td>BTC</td>
                        <td>Bitcoin</td>
                        <td>Venda</td>
                        <td>07/09/2020</td>
                    </tr>
                </tbody>                     
            </table>
        </div>
    </div>

    <input class="BtnRelGerar" type="submit" name="Button1" value="Gerar relatório" /> 
</asp:Content>
