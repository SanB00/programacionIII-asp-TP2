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
        .auto-style3 {
            width: 139px;
        }
        .auto-style4 {
            width: 111px;
        }
        .auto-style5 {
            width: 191px;
        }
        .auto-style6 {
            width: 130px;
            height: 23px;
        }
        .auto-style7 {
            width: 139px;
            height: 23px;
        }
        .auto-style8 {
            width: 111px;
            height: 23px;
        }
        .auto-style9 {
            width: 191px;
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">
                    <asp:LinkButton ID="lbtnVerde" runat="server" OnClick="lbtnVerde_Click">Verde</asp:LinkButton>
                </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:LinkButton ID="lbtnAzul" runat="server" OnClick="lbtnAzul_Click">Azul</asp:LinkButton>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
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
                <td class="auto-style3">
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
                <td class="auto-style3">
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
                <td class="auto-style3">
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
        <br /><br />
        <div style="text-align:center; margin-top:20px;">
    <asp:Button ID="btnVolver" runat="server" 
        Text="← Volver al menú" 
        OnClick="btnVolver_Click"
        Style="padding:10px 20px; background-color:#4CAF50; color:white; border:none; border-radius:5px;" />
</div>
        <div>
        </div>
    </form>
</body>
</html>
