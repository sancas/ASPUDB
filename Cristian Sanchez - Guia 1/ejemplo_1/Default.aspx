<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guia 1 - Ejemplo 1</title>
    <link href="forma.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="caja_superior">
            <h2>Sumar 2 numeros</h2>
        </div>
        <div id="caja_basica">
    
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSumar" CssClass="boton" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            <br />
            <asp:Label ID="Label1" CssClass="resultado" runat="server" Text="Label"></asp:Label>
    
        </div>
    </form>
</body>
</html>
