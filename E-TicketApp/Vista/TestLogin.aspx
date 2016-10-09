<%@ Page Title="" Language="C#" MasterPageFile="~/Basico.Master" AutoEventWireup="true" CodeBehind="TestLogin.aspx.cs" Inherits="Vista.TestLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextUsuario" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextContraseña" runat="server"></asp:TextBox>
    <asp:Button ID="BotonLogin" runat="server" onclick="BotonLogin_Click" Text="Button" />
    <br />
    <asp:Label ID="LabelNotificacion" runat="server" Text=""></asp:Label>
    <br />
    Nombre: <asp:Label ID="LabelUsuarioNombre" runat="server" Text=""></asp:Label>
    <br />
    Fono: <asp:Label ID="LabelUsuarioFono" runat="server"></asp:Label>
    <br />
    Email: <asp:Label ID="LabelUsuarioEmail" runat="server"></asp:Label>
</asp:Content>
