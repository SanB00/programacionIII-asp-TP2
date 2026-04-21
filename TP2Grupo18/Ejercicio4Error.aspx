<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4Error.aspx.cs" Inherits="TP2Grupo18.Ejercicio4Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
                <asp:Label ID="lblMensajeUsuario" runat="server" Text="Usuario inválido - Ingreso no permitido"></asp:Label>
            </h2>
        </div>
        <br />
        <asp:LinkButton ID="linkbtnVolver" runat="server" OnClick="linkbtnVolver_Click">Volver</asp:LinkButton>
    </form>
</body>
</html>
