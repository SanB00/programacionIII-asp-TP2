<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2Form2.aspx.cs" Inherits="TP2Grupo18.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTituloResumen" runat="server" Text="Resumen"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblZona" runat="server" Text="Zona:"></asp:Label>
        </p>
        <asp:Label ID="lblTemasElegidos" runat="server"></asp:Label>
        <p> 
           <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblFechaHora" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
