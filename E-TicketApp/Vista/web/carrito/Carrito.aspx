<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Vista.web.carrito.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Carrito de compra</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>   

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:gridview runat="server" id="gridViewCarrito">
                </asp:gridview>
                <hr />
                <center>
                    <asp:button style="float-right" runat="server" text="Pagar" 
                        id="btnComprar" onclick="btnComprar_Click" />
                </center>
            </div>
        </div>
 



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
