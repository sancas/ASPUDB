<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" Runat="Server">
    <li role="presentation"><a href="Default.aspx">Home</a></li>
    <li role="presentation" class="active"><a href="#">Sobre Nosotros</a></li>
    <li role="presentation"><a href="Default3.aspx">Contactanos</a></li>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <div class="jumbotron">
        <h1>Sobre nosotros</h1>
        <div class="row marketing">
        <div class="col-md-4">
          <h4>Pide ayuda</h4>
          <p>Estamos aqui para ayudarte con el juego que necesites.</p>
        </div>
        <div class="col-md-4">
          <h4>24/7</h4>
          <p>Siempre tendras a alguien dispuesto a ayudarte.</p>
        </div>
        <div class="col-md-4">
          <h4>De todo tipo</h4>
          <p>Jugamos todo tipo de juegos asi que no se apene!.</p>
        </div>
        </div>
    </div>
</asp:Content>

