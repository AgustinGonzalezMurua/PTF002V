<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Vista.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
            <label for="nombre">Nombre:</label>
            <asp:TextBox class="form-control"  id="txtNombre" type="text" name="txtNombre" runat="server"/> 
    </div>
    <div class="form-group">
        <label for="Rut">Rut:</label>
        <asp:TextBox class="form-control"  id="txtRut" type="text" name="txtRut" runat="server"/> 
    </div>
    <div class="form-group">
        <label for="txtTelefono">Télefono:</label>
        <asp:TextBox class="form-control"  id="txtTelefono" type="text" name="txtTelefono" runat="server"/> 
    </div>
        <div class="form-group">
        <label for="Rut">Correo:</label>
        <asp:TextBox class="form-control"  id="txtCorreo" type="text" name="txtCorreo" runat="server"/> 
    </div>
    <div class="form-group">
        <label for="txtClave">Clave:</label>
        <asp:TextBox class="form-control"  id="txtClave" type="text" TextMode="Password" name="txtClave" runat="server"/> 
    </div>
    <div class="form-group">                                
            <asp:Button ID="btnEnviar" runat="server" onclick="btnEnviar_Click" Text="Enviar" />
    </div>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
