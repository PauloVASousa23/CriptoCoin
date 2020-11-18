<%@ Page Title="" Language="C#" MasterPageFile="~/ClienteMaster.Master" AutoEventWireup="true" CodeBehind="ClienteMovimentar.aspx.cs" Inherits="CriptoCoinWeb.ClienteMovimentar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="TitleMov">
        <p>Movimentar conta</p>
    </div>
    <div class="ContainerMonMov">
        <div class="CardMonMov">
            <div class="CardInfo">
                <div class="SalMov">
                    Saldo
                </div>
                <div class="TextSiglaMov">
                    BTC  
                    <div class="TextNomeMov">
                        Bitcoin                
                    </div>
                </div>
                <div class="QuanMonMov">
                    Quantidade: <span id="QuanBTC"></span>
                    <div class="ValorMonMov">
                        Valor: <span id="ValBTC"></span>
                    </div>
                </div>           
            </div>
            <div class="CardMovimentacao">
                <h2>Movimentar</h2>
                <div class="GrupoMovimentar">
                    <span>Quantidade</span>
                    <input type="text" />
                    <button style="margin-left: auto">Comprar</button>
                </div>

                <div class="GrupoValor">
                    <span>Valor</span>
                    <input type="text" />
                    <button style="background-color: #2b6ca7;">Vender</button>
                </div>
            </div>
        </div>
        <div class="CardMonMov">      
            <div class="CardInfo">
                <div class="SalMov">
                    Saldo
                </div>
                <div class="TextSiglaMov">
                    ETH 
                    <div class="TextNomeMov">
                        Ethereum
                    </div>    
                </div>
                <div class="QuanMonMov" >
                    Quantidade: <span id="QuanETH"> </span>
                    <div class="ValorMonMov">
                        Valor: <span id="ValETH"> </span>
                    </div>
                </div>
            </div>
            <div class="CardMovimentacao">
                <h2>Movimentar</h2>
                <div class="GrupoMovimentar">
                    <span>Quantidade</span>
                    <input type="text" />
                    <button style="margin-left: auto">Comprar</button>
                </div>

                <div class="GrupoValor">
                    <span>Valor</span>
                    <input type="text" />
                    <button style="background-color: #2b6ca7;">Vender</button>
                </div>
            </div>

        </div>
        <div class="CardMonMov">
            <div class="CardInfo">
                <div class="SalMov">
                    Saldo
                </div>
                <div class="TextSiglaMov">
                    LTC 
                    <div class="TextNomeMov">
                        Litecoin
                    </div>    
                </div>
                <div class="QuanMonMov">
                         Quantidade: <span id="QuanLTC"> </span>
                    <div class="ValorMonMov">
                        Valor: <span id="ValLTC"> </span>
                    </div>
                </div>
            </div>
            <div class="CardMovimentacao">
                <h2>Movimentar</h2>
                <div class="GrupoMovimentar">
                    <span>Quantidade</span>
                    <input type="text" />
                    <button style="margin-left: auto">Comprar</button>
                </div>

                <div class="GrupoValor">
                    <span>Valor</span>
                    <input type="text" />
                    <button style="background-color: #2b6ca7;">Vender</button>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
