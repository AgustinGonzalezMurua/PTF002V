<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Vista.web.catalogo.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

                          <div class="row">
                            <div class="col-sm-6">
                                <div class="product-images">
                                    <div class="product-main-img">
                                        <div class="product-gallery">
                                            &nbsp;<asp:Image ID="Image1" runat="server" Height="302px" 
                                            ImageUrl="~/im/Captura.jpg" Width="650px" />
                                         </div>
                                    </div>
                                 </div>
                            </div>
                            
                            <div class="col-sm-6">
                                <div class="product-inner">
                                    <h2 class="product-name">
                                        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></h2>
                                    <div class="product-inner-price">
                                        <ins>
                                            <asp:Label ID="lblPrecio" runat="server" Text="Label"></asp:Label></ins>
                                    </div>    
                                    
                                    <form action="" class="cart">
                                        <div class="quantity">
                                            <input size="4" class="input-text qty text" title="Qty" value="1" name="quantity" min="1" step="1" type="number">
                                        </div>
                                        
                                    </form>   
                                    
                                    <div class="product-inner-category">
                                        <p>Category: 
                                            <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
                                    </div> 
                                    
                                    <div role="tabpanel">
                                        <ul class="product-tab" role="tablist">
                                            <li role="presentation" class="active"><a href="#home" aria-controls="home" role="tab" data-toggle="tab">Description</a></li>
                                         
                                        </ul>
                                        <div class="tab-content">
                                            <div role="tabpanel" class="tab-pane fade in active" id="home">
                                                <h2>Descripción</h2>  
                                                <p>
                                                    Recinto: <asp:Label ID="lblRecinto" runat="server" Text="Recinto"></asp:Label>
                                                <p> Organizador: <asp:Label ID="lblOrganizador" runat="server" Text="Organizador"></asp:Label>
                                                    <p>
                                                        <asp:Label ID="Label1" runat="server" Text="Label" Visible=false></asp:Label></p>
                                                    <p>&nbsp;</p>
                                                    <div class="rating-chooser">
                                                        <p>Ranking</p>

                                                        <div class="rating-wrap-post">
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                          <!--  <button class="add_to_cart_button" type="submit" onclick="add_to_cart_button_on">Comprar</button> -->

                                                <asp:Button ID="EnviarAlCarro" runat="server" Text="Comprar" 
                                            OnClientClick="EnviarAlCarro_onClick" onclick="EnviarAlCarro_Click" />
                                        </div>
                                    </div>
                                    
                                </div>
                            </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
