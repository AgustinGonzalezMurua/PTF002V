<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CatalogoEvento.aspx.cs" Inherits="Vista.web.catalogo.CatalogoEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

<!-- modal -->

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Bootstrap Modal Dialog -->
    <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h4 class="modal-title"><asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="modal-footer">
                            <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Close</button>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>




    <div class="col-md-12">
        <div class="product-bit-title text-center"></div>
            <h2> Listado de Eventos </h2>
    </div>


    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>


    <!-- Inicio de listado -->

    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
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


                        <div class="product-option-shop">
                               
                            <asp:Button ID="btnSubmit" class="btn-info" runat="server" Text="Comprar" OnClick="btnSubmit_Click"></asp:Button>
	                                        
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
                        <asp:Button ID="Button2" runat="server" Text="Comprar" />
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
                        <asp:Button ID="Button3" runat="server" Text="Comprar" />
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
