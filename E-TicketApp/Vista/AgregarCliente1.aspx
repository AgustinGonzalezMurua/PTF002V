<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCliente1.aspx.cs" Inherits="Vista.AgregarCliente1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
            <div class="form-group">
                 <label for="nombre">Nombre:</label>
                 <asp:TextBox class="form-control" id="txtNombre" type="text" name="txtNombre" runat="server"/> </asp:textBox>
            </div>
            <div class="form-group">
                <label for="Rut">Rut:</label>
                <asp:TextBox class="form-control"  id="txtRut" type="text" name="txtRut" runat="server"/> </asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtTelefono">Télefono:</label>
                <asp:TextBox class="form-control"  id="txtTelefono" type="text" name="txtTelefono" runat="server"/> </asp:TextBox>
            </div>
             <div class="form-group">
                <label for="Rut">Correo:</label>
                <asp:TextBox class="form-control"  id="txtCorreo" type="text" name="txtCorreo" runat="server"/> </asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtClave">Clave:</label>
                <asp:TextBox class="form-control"  id="txtClave" type="text" TextMode="Password" name="txtClave" runat="server"/> </asp:TextBox>
            </div>
            <div class="form-group">
                                </asp:Button>
                                <asp:Button ID="btnEnviar" runat="server" onclick="btnEnviar_Click" 
                                    Text="Enviar" />
            </div>
 
</form>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
