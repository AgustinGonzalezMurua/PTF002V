<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="portalPago.aspx.cs" Inherits="Vista.web.pagar.portalPago" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Portal de Pago</title>
    <!-- CSS -->
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="~/css/responsive.css" rel="stylesheet" type="text/css" />
    <link href="~/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- Fuentes Google -->
    <link href="~/css/google-fonts-raleway.css" rel="stylesheet" type="text/css" />
    <link href="~/css/google-fonts-roboto.css" rel="stylesheet" type="text/css" />
    <link href="~/css/google-fonts-titillium.css" rel="stylesheet" type="text/css" />
    <!-- CSS -->
    <link href="~/css/owl.carousel.css" rel="stylesheet" type="text/css" />
    <link href="~/style.css" rel="stylesheet" type="text/css" />

    <style>
        #gridViewEntradas {
            width: 100%; 
            word-wrap:break-word;
            table-layout: fixed;
        }
       #gridViewEntradas th{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <asp:gridview runat="server" id="gridViewEntradas">
                </asp:gridview>
                <hr />
                <center>
                    <asp:button style="float-right" runat="server" text="Confirmar Compra" 
                        id="btnConfimarCompra" onclick="btnConfimarCompra_Click" />
                </center>
                        <br />
                <center>
                    <asp:button style="float-right" runat="server" text="Volver" 
                    id="btnVolver" onclick="btnVolver_Click" />
                </center>
            </div>
        </div>
    </form>
</body>
</html>
