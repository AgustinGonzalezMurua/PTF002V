<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Vista.EventosCatalogo" %>
<asp:Content ID="Header" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Contenido" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Header de la Página -->
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
    <!-- Fin Header -->

    <!-- Contenido -->
    <!-- Barra de búsqueda -->
    <div class="row" style="margin-top: 25px;">
        <form id="FormBusqueda" runat="server">
            <div class="col-sm-3 col-sm-offset-4">
                    <asp:TextBox ID="txtBuscarEventos" runat="server" class="form-control text-right" placeholder="Buscar un Evento..." style="height:42px"></asp:TextBox>
            </div>
            <div class="col-md-1">
                <asp:Button ID="BotonBusquedaEvento" runat="server" Text="Buscar" />
            </div>
        </form>
    </div>
    <!-- Fin barra de búsqueda --->

    <div class="single-product-area">
        <div class="zigzag-bottom"></div>
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                        
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                       
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                      
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>  
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                         
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                     
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                       
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                        
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                       
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                        
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                      
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="single-shop-product">
                        <div class="product-upper">
                            <img src="/img/producto-placeholder.jpg" alt="">
                        </div>
                        <h2><a href="/web/eventos/detalle.aspx?idEvento=1">Nombre de Evento</a></h2>
                        <div class="product-carousel-price">
                            <ins>$899.00</ins> 
                        </div>                       
                    </div>
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-12">
                    <div class="product-pagination text-center">
                        <nav>
                          <ul class="pagination">
                            <li>
                              <a href="#" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                              </a>
                            </li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li>
                              <a href="#" aria-label="Next">
                                <span aria-hidden="true">&raquo;</span>
                              </a>
                            </li>
                          </ul>
                        </nav>                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Fin Contenido -->
</asp:Content>
<asp:Content ID="Footer" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
