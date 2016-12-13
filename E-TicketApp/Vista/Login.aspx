<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vista.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
            <div class="form-group">
            <label> Login </label>
            </div>


              <div class="form-group">
                <label for="Rut">Rut:</label>
                <asp:TextBox class="form-control"  id="txtUsuario" type="text" name="txtCorreo" 
                      runat="server"/> 
            </div>
            <div class="form-group">
                <label for="txtClave">Clave:</label>
                <asp:TextBox class="form-control"  id="txtClave" type="text" TextMode="Password" name="txtClave" runat="server"/> </asp:TextBox>
            </div>
            <div class="form-group">
                 <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
                     Text="Enviar" />
            </div>









</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JavasScriptContent" runat="server">
</asp:Content>
