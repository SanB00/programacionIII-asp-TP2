<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio 1.aspx.cs" Inherits="TP2Grupo18.WebForm1" %>

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
            width: 226px;
        }
        .auto-style3 {
            width: 151px;
        }
        .auto-style4 {
            width: 71px;
        }
        .auto-style5 {
            width: 226px;
            height: 26px;
        }
        .auto-style6 {
            width: 151px;
            height: 26px;
        }
        .auto-style7 {
            width: 71px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="LblProductos" runat="server" style="font-weight: 700" Text="Ingrese el nombre del producto: "></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="LblCantidad1" runat="server" style="font-weight: 700" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="LblProducto2" runat="server" style="font-weight: 700" Text="Ingrese el nombre del producto: "></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtProducto2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="LblCantidad2" runat="server" style="font-weight: 700" Text="Cantidad: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnTabla" runat="server" style="font-weight: 700" Text="Generar Tabla" OnClick="btnTabla_Click" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Table ID="TblProductos" runat="server" Height="80px" Width="101px">
        </asp:Table>
    </form>
</body>
</html>
