<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarroDeCompra.aspx.cs" Inherits="Vista.web.carrito.CarroDeCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<!-- titulo-->

    <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Carrito de Compra</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>



<!------->

    <asp:GridView ID="gvCaritoCompras" runat="server" AutoGenerateColumns="False" EmptyDataText="No hay eventos en su carrito" GridLines="None" Width="100%" CellPadding="5" ShowFooter="True" DataKeyNames="pCodigo">
    <Columns>
      <asp:BoundField DataField=”pCodigo” HeaderText=”Nombre” /> 
        <asp:TemplateField HeaderText=”Prueba”>
            <ItemTemplate>
                
               
                <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CommandName="Eliminar" CommandArgument='Eval(“pCodigo”)'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
       
    </Columns>
    
    </asp:GridView>



    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
    
    <asp:Label ID="Label1" runat="server" Text="Label">
    </asp:Label>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
