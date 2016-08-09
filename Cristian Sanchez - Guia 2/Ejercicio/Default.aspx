<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="jumbotron">
        <h1>Gamers El Salvador</h1>
        <p class="lead">Estamos aqui para ayudarnos y solucionar tus dudas.</p>
        <p><a class="btn btn-lg btn-success" href="#" role="button">Unete ahora</a></p>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="menu" runat="server">
    <li role="presentation" class="active"><a href="#">Home</a></li>
    <li role="presentation"><a href="Default2.aspx">Sobre Nosotros</a></li>
    <li role="presentation"><a href="Default3.aspx">Contactanos</a></li>
</asp:Content>