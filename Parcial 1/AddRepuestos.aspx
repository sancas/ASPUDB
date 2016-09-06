<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddRepuestos.aspx.cs" Inherits="AddRepuestos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="menu" Runat="Server">
    <li role="presentation"><a href="Default.aspx">Home</a></li>
    <li role="presentation"><a href="Marcas.aspx">Marcas</a></li>
    <li role="presentation"><a href="Modelos.aspx">Modelos</a></li>
    <li role="presentation" class="active"><a href="#">Repuestos</a></li>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <div class="jumbotron">
        <form runat="server">
          <div class="form-group">
            <label for="InputNombre">Nombre</label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="InputPrecio">Precio</label>
              <div class="input-group">
                <div class="input-group-addon">$</div>
                <asp:TextBox ID="txtPrecio" CssClass="form-control" ValidationGroup="Form" placeholder="Precio" runat="server"></asp:TextBox>
              </div>
          </div>
          <div class="form-group">
            <label for="InputDescuento">Descuento</label>
            <div class="input-group">
              <asp:TextBox ID="txtDescuento" CssClass="form-control" placeholder="Descuento" runat="server"></asp:TextBox>
              <div class="input-group-addon">%</div>
            </div>
          </div>
          <div class="form-group">
            <label for="InputIdModelo">ID Modelo</label>
            <asp:TextBox ID="txtIDModelo" CssClass="form-control" placeholder="ID Modelo" runat="server"></asp:TextBox>
          </div>
          <asp:Button ID="btnAgregar" CssClass="btn btn-success" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
          <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </form>
    </div>
</asp:Content>

