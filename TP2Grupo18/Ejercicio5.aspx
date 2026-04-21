<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2Grupo18.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 378px;
        }

        .auto-style2 {
            height: 23px;
        }

        .auto-style3 {
            width: 378px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <h2>Elija su configuración</h2>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="label1" runat="server" Text="Seleccione cantidad de memoria"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlCantMemoria" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">¿Desea comprar 2 memorias para usar dual channel?<asp:CheckBox ID="chbDualChannel" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="lblSeleccion" runat="server" Text="Seleccione un Accesorio"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:CheckBoxList ID="chkAccesorios" runat="server">
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">Seleccione Procesador:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="rblProcesador" runat="server" Height="16px" Width="51px">
                            <asp:ListItem Value="2000">i3</asp:ListItem>
                            <asp:ListItem Value="3500">i5</asp:ListItem>
                            <asp:ListItem Value="5000">i7</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style3">Seleccione Almacenamiento:</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="rblAlmacenamiento" runat="server">
                            <asp:ListItem Value="600">HDD 1TB</asp:ListItem>
                            <asp:ListItem Value="850">SSD 500GB</asp:ListItem>
                            <asp:ListItem Value="1200">SSD 1TB</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="btnCalcularPrecio" runat="server" OnClick="btnCalcularPrecio_Click" Text="Calcular precio" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">
                        <h3>

                        <asp:Label ID="lblResultado" runat="server"></asp:Label>
                        </h3>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
