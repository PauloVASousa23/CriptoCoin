<%@ Page Title="" Language="C#" MasterPageFile="~/AgenciaMaster.Master" AutoEventWireup="true" CodeBehind="AgenciaConsultar.aspx.cs" Inherits="CriptoCoinWeb.AgenciaConsultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p style="font-size: 28px;margin-bottom: 0px;color: #10406c;font-weight: bold;">Filtrar por:</p>
    <div class="TextBotton">
        <div class="BoxBotton" style="width:15%">
            <div class="inputIcone">  
                <img class="Localiza" src="Content/Img/icone_procurar_azul.png"/>
            </div>
                <input class="ID" name="ID" type="text" id="ID" placeholder="ID">
        </div>        
        <div class="BoxBotton" style="width:55%">
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
                <input class="BtnPesquisar" type="submit" name="Button1" value="Pesquisar" style="width: 10%;height: 60px;" />          
    </div> 
    <div class="Tabel">
        <div class="TabelaConteudo">
            <table border="0">
                <thead>
                    <tr> 
                        <th>ID</th>
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
    <div class="Cartao">
        <div class="Borda">           
            <img class="Person" src="Content/Img/icone_person_preto.png"/>
        </div>
        <div class="CartaoConteudo">
            <div class="GrupoID">
                <label>001</label>
            </div>
            <div class="GrupoNome GrupoEstilo">
                <p>Nome:</p>
                <label>Washington Lima Da Silva</label>

            </div>
             <div class="GrupoRG GrupoEstilo">
                 <p>RG:</p>
                <label>000.000.000-00</label>

            </div>
             <div class="GrupoCPF GrupoEstilo">
                 <p>CPF:</p>
                <label>000.000.000-00</label>
            </div>
            <div class="GrupoCidade GrupoEstilo">
                <p>Cidade:</p>
                <label>Diadema</label>
            </div>
            <div class="GrupoSaldo GrupoEstilo">
                <p>Saldo:</p>
                <label>R$ 1000,00</label>
            </div>
            <div class="BotaoAlterar">
                <p>&nbsp;
                </p>
               <input type="button" value="Alterar" />
            </div>
        </div>

    </div>
        
</asp:Content>
