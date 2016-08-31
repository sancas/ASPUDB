<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <div class="jumbotron">
        <h1>Talleres El Salvador</h1>
        <p class="lead">Estamos aqui para ayudarte a solucionar los problemas de tu auto.</p>
        <p><a class="btn btn-lg btn-success" href="Marcas.aspx" role="button">Marcas</a></p>
        <p><a class="btn btn-lg btn-success" href="Modelos.aspx" role="button">Modelos</a></p>
        <p><a class="btn btn-lg btn-success" href="Repuestos.aspx" role="button">Repuestos</a></p>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="menu" runat="server">
    <li role="presentation" class="active"><a href="#">Home</a></li>
    <li role="presentation"><a href="Marcas.aspx">Marcas</a></li>
    <li role="presentation"><a href="Modelos.aspx">Modelos</a></li>
    <li role="presentation"><a href="Repuestos.aspx">Repuestos</a></li>
</asp:Content>