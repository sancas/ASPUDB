<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guia 1 - Calculadora basica</title>
    <link rel="stylesheet" href="forma.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="caja_superior">
        <marquee><h2>Calculadora basica</h2></marquee>
    </div>
    <div id="caja_basica">
    
        <asp:TextBox ID="txtNum1" placeholder="Numero 1" CssClass="txt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOperacion" CssClass="resultado" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="txtNum2" placeholder="Numero 2" CssClass="txt" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" CssClass="resultado" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Sumar</asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Multiplicar</asp:ListItem>
            <asp:ListItem>Dividir</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnOperar" CssClass="boton" runat="server" Text="Operar" OnClick="btnOperar_Click" />
        <br />
        <br />
        <asp:Label ID="lblResultado" CssClass="boton" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
