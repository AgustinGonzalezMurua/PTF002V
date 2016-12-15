<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoEvento.aspx.cs" Inherits="Vista.web.catalogo.CatalogoEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

<!-- modal -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Listado de Eventos</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- Inicio de listado -->

    <div class="single-product-area">
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <form action="default.aspx" method="post">
                    </form>
                    <div class="single-shop-product">

                                    <div class="product-upper">
                        &nbsp;<asp:Image ID="Image1" runat="server" BorderStyle="None" Height="276px" ImageUrl="~/im/product-2.jpg" 
                            Width="294px" />
                    </div>
                                <h3>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </h3>
                        <asp:Label ID="Label4" runat="server" Text="Label">Fecha: </asp:Label>
                        &nbsp;
                        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

                        &nbsp;&nbsp;<br />

                        <asp:Label ID="Label6" runat="server" Text="Label">Recinto</asp:Label>
                        &nbsp; <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                         
                         <asp:Label ID="Label17" runat="server" Text="Label">Codigo: </asp:Label>
                        &nbsp;
                        <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>

                        &nbsp;&nbsp;<br />
                        <div class="product-option-shop">
                        <asp:Button ID="btnSubmit" class="btn-info" runat="server" Text="Detalle" OnClick="btnSubmit_Click"></asp:Button>
                        <br />
                       </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                                                                                        <div class="single-shop-product">
                    <div class="product-upper">
                        &nbsp;<asp:Image ID="Image2" runat="server" BorderStyle="None" Height="276px" ImageUrl="~/im/product-3.jpg" 
                            Width="294px" />
                    </div>
                    <h3>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </h3>
                    <asp:Label ID="Label8" runat="server" Text="Label">Fecha: </asp:Label>
                    &nbsp;
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>

                    &nbsp;&nbsp;<br />

                    <asp:Label ID="Label10" runat="server" Text="Label">Recinto</asp:Label>
                    &nbsp; <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>


                    <div class="product-option-shop">
                        <asp:Button ID="Button2" runat="server" Text="Detalle"  OnClick="btnSubmit_Click"/>
                    </div>                       
                </div>                    
                </div>
                <div class="col-md-3 col-sm-6">

                                                                                        <div class="single-shop-product">
                    <div class="product-upper">
                        &nbsp;<asp:Image ID="Image3" runat="server" BorderStyle="None" Height="276px" ImageUrl="~/im/product-5.jpg" 
                            Width="294px" />
                    </div>
                    <h3>
                        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                    </h3>
                    <asp:Label ID="Label13" runat="server" Text="Label">Fecha: </asp:Label>
                    &nbsp;
                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>

                    &nbsp;&nbsp;<br />

                    <asp:Label ID="Label15" runat="server" Text="Label">Recinto</asp:Label>
                    &nbsp; <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>


                    <div class="product-option-shop">
                        <asp:Button ID="Button3" runat="server" Text="Detalle"  OnClick="btnSubmit_Click"/>
                    </div>                       
                </div>            
                   
                </div>
                <div class="col-md-3 col-sm-6">
                   
                </div>
                <div class="col-md-3 col-sm-6">
                    
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
   
</asp:Content>
