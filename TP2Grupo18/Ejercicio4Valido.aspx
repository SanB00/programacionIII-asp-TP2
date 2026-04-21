<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4Valido.aspx.cs" Inherits="TP2Grupo18.Ejercicio4Valido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <h2>
                        <asp:Label ID="lblBienvenida" runat="server"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:LinkButton ID="linkbtnCerrarSesion" runat="server" OnClick="linkbtnCerrarSesion_Click">Cerrar Sesión</asp:LinkButton>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
