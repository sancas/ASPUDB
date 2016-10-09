<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Consumidor.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora Basica</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" type="text/css" />
</head>
<body>
    <div class="container">
        <div class="header clearfix">
            <h3 class="text-muted">Calculadora Basica</h3>
        </div>
        <form id="form1" runat="server">
            <div class="jumbotron">
                <p>
                    <asp:TextBox ID="txtNumber1" runat="server" placeholder="Numero 1"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="txtNumber2" runat="server" placeholder="Numero 2"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" CssClass="btn btn-danger" /> 
                    <asp:Button ID="btnRestar" runat="server" Text="Restar" OnClick="btnRestar_Click" CssClass="btn btn-success" /> 
                    <asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicar" OnClick="btnMultiplicar_Click" CssClass="btn btn-primary" /> 
                    <asp:Button ID="btnDividir" runat="server" Text="Dividir" OnClick="btnDividir_Click" CssClass="btn btn-info" />
                </p>
                <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
            </div>
        </form>
    </div>
    <script src="http://code.jquery.com/jquery-3.1.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
