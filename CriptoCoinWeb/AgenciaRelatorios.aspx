<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaRelatorios.aspx.cs" Inherits="CriptoCoinWeb.AgenciaRelatórios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="RadioRel"> 
        <P style="margin-bottom: -1px;">Período:</P>
            <input id="Radio1" type="radio" />
            <asp:Label class="Negrito" ID ="Label1" runat="server" Text="Diário"></asp:Label>
            <input id="Radio2" type="radio" />
            <asp:Label class="Negrito" ID="Label2" runat="server" Text="Semanal"></asp:Label>
            <input id="Radio3" type="radio" />
            <asp:Label class="Negrito" ID="Label3" runat="server" Text="Mensal"></asp:Label>         
    </div>
      <div class="TextRel1"> 
        <P>Filtrar por busca:</P>                  
    </div>
    <div class="BottonRel">            
            <div class="BotõesRel" style="width:15%">
                <div class="inputIcone1">  
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                <input class="TextRelMatri" name="TextRelID" type="text" id="TextRelID" placeholder="Matric.">
            </div>        
            <div class="BotõesRel" style="width:30%">
                <div class="inputIcone1"> 
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                    <input class="TextNameRel" name="TextNameRel" type="text" id="TextNameRel" placeholder="Nome">                             
            </div>
            <div class="BotõesRel" style="width:21%">
                <div class="inputIcone1">  
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                     <input class="TextRelCPF" name="TextRelCPF" type="text" id="TextRelCPF" placeholder="CPF"> 
            </div> 
            <div class="BotõesRel" style="width:25%">
                <div class="inputIcone1">  
                    <img class="Localiza1" src="Content/Img/icone_procurar_azul.png"/>
                </div>
                     <input class="TextRelCid" name="TextRelCid" type="text" id="TextRelCid" placeholder="Cidade"> 
            </div>   
                  
    </div>
    <div class="Tabel">
        <div class="TabelaRel">
            <table border="0">
                <thead>
                    <tr> 
                        <th>Matricula</th>
                        <th>Nome</th>
                        <th>CPF</th>
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
    </div>
    <input class="BtnRelGerar" type="submit" name="Button1" value="Gerar relatório dos clientes acima" />
</asp:Content>
