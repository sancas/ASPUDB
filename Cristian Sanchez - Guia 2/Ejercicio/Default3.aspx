<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" Runat="Server">
    <li role="presentation"><a href="Default.aspx">Home</a></li>
    <li role="presentation"><a href="Default2.aspx">Sobre Nosotros</a></li>
    <li role="presentation"  class="active"><a href="#">Contactanos</a></li>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <div class="jumbotron">
        <h1>Contactanos</h1>
        <p class="lead">Para ponerte en contacto con nosotros puedes enviarnos un correo.</p>
        <p><a class="btn btn-lg btn-success" href="#" role="button">Email</a></p>
    </div>
</asp:Content>

