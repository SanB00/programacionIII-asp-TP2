<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2Grupo18.WebForm1" %>

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
            width: 240px;
        }
        .auto-style3 {
            width: 244px;
        }
        .auto-style4 {
            width: 71px;
        }
        .auto-style5 {
            width: 240px;
            height: 26px;
        }
        .auto-style6 {
            width: 244px;
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
                        <asp:Label ID="lblProductos" runat="server" style="font-weight: 700" Text="Ingrese el nombre del producto 1: "></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtProducto1" runat="server" Width="155px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="lblCantidad1" runat="server" style="font-weight: 700" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtCantidad1" runat="server" Width="65px"></asp:TextBox>
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
                        <asp:Label ID="lblProducto2" runat="server" style="font-weight: 700" Text="Ingrese el nombre del producto 2: "></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtProducto2" runat="server" Width="155px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblCantidad2" runat="server" style="font-weight: 700" Text="Cantidad: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCantidad2" runat="server" Width="65px"></asp:TextBox>
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
                        <asp:Button ID="btnGenerarTabla" runat="server" style="font-weight: 700" Text="Generar Tabla" OnClick="btnGenerarTabla_Click" Font-Bold="False" ToolTip="Mostrar tabla con datos del producto :)" />
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
        <asp:GridView ID="gvListadoProductos" runat="server" BorderStyle="Double" BorderWidth="5px" CellPadding="5" CellSpacing="1">
        </asp:GridView>
    </form>
</body>
</html>
