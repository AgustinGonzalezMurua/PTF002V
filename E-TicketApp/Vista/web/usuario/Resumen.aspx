<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resumen.aspx.cs" Inherits="Vista.Resumen" %>
<asp:Content ID="Header" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">

<div class="product-big-title-area">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="product-bit-title text-center">
                    <h2>Perfil de Cuenta</h2>
                </div>
            </div>
        </div>
    </div>
</div>

<div class="single-product-area">
    <div class="container">
        <div class="row">
            <!-- Menu de Opciones del Usuario -->
            <div class="col-sm-4">
                <div class="single-sidebar">
                    <div class="thubmnail-recent">
                        <div class="product-sidebar-price">
                            <h2>Basic List Group</h2>
                            <ul class="list-group">
                                <li class="list-group-item"><a href="/web/usuario/Resumen.aspx">Resumen de perfil</a></li>
                                <li class="list-group-item"><a href="/web/usuario/HistorialCompras.aspx">Historial de Compras</a></li>
                                <li class="list-group-item"><a href="/web/usuario/Modificar.aspx">Resumen de perfil</a></li>
                            </ul>
                        </div>                             
                    </div>
                </div>
            </div>

            <!-- Resumen del usuario -->
            <div class="col-sm-8">
                Información del usuario
            </div>
        </div>
    </div>
</div>
</asp:Content>
<asp:Content ID="Footer" ContentPlaceHolderID="JavasScriptContent" runat="server">
    </div>
</asp:Content>
