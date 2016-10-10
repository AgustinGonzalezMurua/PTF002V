<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="Vista.AgregarCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<head runat="server">
    <title>
    <!-- Form Name -->
        <legend>Registro cliente</legend>
    </title>
<link href="<?=bower_url()?>bootstrap-select/dist/css/bootstrap-select.min.css" rel="stylesheet" type="text/css">

</head>
<p>
    <asp:Label ID="label" runat="server" Text="Formulario de registro"></asp:Label>
</p>
<body style="height: 261px">
    <form id="form1" runat="server">

    <!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="txtNombre">Nombre:</label>  
                <div class="col-md-4">
                &nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </div>
        </div>

<!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="txtRut">Rut:</label>  
            <div class="col-md-4">
            &nbsp;<asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </div>
        </div>

<!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="txtTelefono">Télefono:</label>  
            <div class="col-md-4">
            &nbsp;<asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </div>
        </div>

<!-- Text input-->
        <div class="form-group">
            <label class="col-md-4 control-label" for="txtCorreo">Correo:</label>  
            <div class="col-md-4">
            &nbsp;<asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
        </div>

<!-- Password input-->
        <div class="form-group">
             <label class="col-md-4 control-label" for="txtClave">Clave:</label>
                <div class="col-md-4">
                    &nbsp;<asp:TextBox 
                        ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                    <br />
                    <br />
                <asp:Button ID="btnRegistrar" runat="server" Text="Guardar" 
                        onclick="btnRegistrar_Click" />
    
                </div>
        </div>

</form>
</body>



