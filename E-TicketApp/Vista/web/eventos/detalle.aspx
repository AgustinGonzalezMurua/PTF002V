<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="detalle.aspx.cs" Inherits="Vista.EventoDetalle" %>
<asp:Content ID="Header" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <div class="product-big-title-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="product-bit-title text-center">
                        <h2>Tienda</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    
    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">                
                <div class="col-md-8 col-md-offset-2">
                    <div class="product-content-right">
                        <!--<div class="product-breadcroumb">
                            <a href="">Home</a>
                            <a href="">Category Name</a>
                            <a href="">Sony Smart TV - 2015</a>
                        </div>-->
                        
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="product-images">
                                    <div class="product-main-img">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                    </div>
                                    
                                    <div class="product-gallery">
                                        <img src="/img/producto-thumb-placeholder.jpg" alt="">
                                        <img src="/img/producto-thumb-placeholder.jpg" alt="">
                                        <img src="/img/producto-thumb-placeholder.jpg" alt="">
                                        <img src="/img/producto-thumb-placeholder.jpg" alt="">
                                    </div>
                                </div>
                            </div>
                            
                            <div class="col-sm-6">
                                <div class="product-inner">
                                    <h2 class="product-name">
                                        <asp:Label ID="LabelEventoNombre" runat="server" Text="Nombre de Evento"></asp:Label>
                                    </h2>
                                    <div class="product-inner-price">
                                        Desde
                                        <ins>
                                            $<asp:Label 
                                            ID="LabelEventoPrecio" runat="server" Text="5.000"></asp:Label>
                                        </ins>
                                    </div>    
                                    <form action="" class="cart" runat="server" >
                                        <div class="quantity">
                                            <input type="number" size="4" class="input-text qty text" title="Qty" value="1" name="quantity" min="1" step="1">
                                        </div>
                                        <asp:Button class="add_to_cart_button" ID="BtnAgregarCarrito" runat="server" Text="Agregar a carrito" />
                                    </form>   
                                    
                                    <div class="product-inner-category">
                                        <p>
                                            Ubicación: 
                                            <asp:Literal ID="LabelEventoUbicacion" runat="server" 
                                                Text="Centro de Evento, Dirección #391, Santiago Centro"></asp:Literal> 
                                        </p>
                                        <p>
                                            Hora: 
                                            <asp:Literal ID="LabelEventoHora" runat="server" Text="20:30 PM"></asp:Literal>
                                        </p>
                                    </div> 
                                    
                                    <div role="tabpanel">
                                        <ul class="product-tab" role="tablist">
                                            <!-- <li role="presentation" class="active"><a href="#home" aria-controls="home" role="tab" data-toggle="tab">
                                                Descripción</a></li> -->
                                            <!-- <li role="presentation"><a href="#profile" aria-controls="profile" role="tab" data-toggle="tab">Reviews</a></li> -->
                                        </ul>
                                        <div class="tab-content">
                                            <div role="tabpanel" class="tab-pane fade in active" id="home">
                                                <h2>DESCRIPCIÓN</h2>  
                                                <asp:Literal ID="LabelEventoDescripcion" runat="server" 
                                                    Text="&lt;p&gt;Descripcion de vento&lt;/p&gt;"></asp:Literal>
                                            </div>
                                            <div role="tabpanel" class="tab-pane fade" id="profile">
                                                <h2>Reviews</h2>
                                                <div class="submit-review">
                                                    <p><label for="name">Name</label> <input name="name" type="text"></p>
                                                    <p><label for="email">Email</label> <input name="email" type="email"></p>
                                                    <div class="rating-chooser">
                                                        <p>Your rating</p>

                                                        <div class="rating-wrap-post">
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                        </div>
                                                    </div>
                                                    <p><label for="review">Your review</label> <textarea name="review" id="" cols="30" rows="10"></textarea></p>
                                                    <p><input type="submit" value="Submit"></p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                        
                        
                        <div class="related-products-wrapper">
                            <h2 class="related-products-title">EVENTOS RELACIONADOS</h2>
                            <div class="related-products-carousel">
                                <div class="single-product">
                                    <div class="product-f-image">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                        <div class="product-hover">
                                            <a href="" class="add-to-cart-link"><i class="fa fa-shopping-cart"></i> Add to cart</a>
                                            <a href="" class="view-details-link"><i class="fa fa-link"></i> See details</a>
                                        </div>
                                    </div>

                                    <h2><a href="">Sony Smart TV - 2015</a></h2>

                                    <div class="product-carousel-price">
                                        <ins>$700.00</ins> <del>$800.00</del>
                                    </div> 
                                </div>
                                <div class="single-product">
                                    <div class="product-f-image">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                        <div class="product-hover">
                                            <a href="" class="add-to-cart-link"><i class="fa fa-shopping-cart"></i> Add to cart</a>
                                            <a href="" class="view-details-link"><i class="fa fa-link"></i> See details</a>
                                        </div>
                                    </div>

                                    <h2><a href="">Apple new mac book 2015 March :P</a></h2>
                                    <div class="product-carousel-price">
                                        <ins>$899.00</ins> <del>$999.00</del>
                                    </div> 
                                </div>
                                <div class="single-product">
                                    <div class="product-f-image">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                        <div class="product-hover">
                                            <a href="" class="add-to-cart-link"><i class="fa fa-shopping-cart"></i> Add to cart</a>
                                            <a href="" class="view-details-link"><i class="fa fa-link"></i> See details</a>
                                        </div>
                                    </div>

                                    <h2><a href="">Apple new i phone 6</a></h2>

                                    <div class="product-carousel-price">
                                        <ins>$400.00</ins> <del>$425.00</del>
                                    </div>                                 
                                </div>
                                <div class="single-product">
                                    <div class="product-f-image">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                        <div class="product-hover">
                                            <a href="" class="add-to-cart-link"><i class="fa fa-shopping-cart"></i> Add to cart</a>
                                            <a href="" class="view-details-link"><i class="fa fa-link"></i> See details</a>
                                        </div>
                                    </div>

                                    <h2><a href="">Sony playstation microsoft</a></h2>

                                    <div class="product-carousel-price">
                                        <ins>$200.00</ins> <del>$225.00</del>
                                    </div>                            
                                </div>
                                <div class="single-product">
                                    <div class="product-f-image">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                        <div class="product-hover">
                                            <a href="" class="add-to-cart-link"><i class="fa fa-shopping-cart"></i> Add to cart</a>
                                            <a href="" class="view-details-link"><i class="fa fa-link"></i> See details</a>
                                        </div>
                                    </div>

                                    <h2><a href="">Sony Smart Air Condtion</a></h2>

                                    <div class="product-carousel-price">
                                        <ins>$1200.00</ins> <del>$1355.00</del>
                                    </div>                                 
                                </div>
                                <div class="single-product">
                                    <div class="product-f-image">
                                        <img src="/img/producto-placeholder.jpg" alt="">
                                        <div class="product-hover">
                                            <a href="" class="add-to-cart-link"><i class="fa fa-shopping-cart"></i> Add to cart</a>
                                            <a href="" class="view-details-link"><i class="fa fa-link"></i> See details</a>
                                        </div>
                                    </div>

                                    <h2><a href="">Samsung gallaxy note 4</a></h2>

                                    <div class="product-carousel-price">
                                        <ins>$400.00</ins>
                                    </div>                            
                                </div>                                    
                            </div>
                        </div>
                    </div>                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Scripts" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
