<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2Grupo18.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style4 {
            width: 111px;
        }
        .auto-style5 {
            width: 191px;
        }
        .auto-style6 {
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:LinkButton ID="lbtnVerde" runat="server" OnClick="lbtnVerde_Click">Verde</asp:LinkButton>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:LinkButton ID="lbtnAzul" runat="server" OnClick="lbtnAzul_Click">Azul</asp:LinkButton>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:LinkButton ID="lbtnAmarillo" runat="server" OnClick="lbtnAmarillo_Click">Amarillo</asp:LinkButton>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:LinkButton ID="lbtnRojo" runat="server" OnClick="lbtnRojo_Click">Rojo</asp:LinkButton>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:LinkButton ID="lbtnRandom" runat="server" OnClick="lbtnRandom_Click">Random</asp:LinkButton>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr><td class="auto-style2">&nbsp;</td></tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="lblTexto" runat="server" Font-Bold="True" Text="Texto Coloreado"></asp:Label>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtNuevoTexto" runat="server" Width="152px" Height="22px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnCambiarTexto" runat="server" OnClick="btnCambiarTexto_Click" Text="Seleccionar" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
