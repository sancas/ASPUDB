<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Repuestos.aspx.cs" Inherits="Repuestos" %>

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
        <div id="success" class="alert alert-success collapse">
            <strong>Success!</strong> El registro se agrego satisfactoriamente.
        </div>
        <div id="error" class="alert alert-danger collapse">
            <strong>Error!</strong> El registro no se pudo agregar.
        </div>
        <form id="Form1" runat="server">
            <asp:GridView ID="gridRepuestos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id_rep" DataSourceID="SqlDataSource1">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="id_rep" HeaderText="ID Repuesto" InsertVisible="False" ReadOnly="True" SortExpression="id_rep" Visible="False" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" SortExpression="precio" />
                    <asp:BoundField DataField="descuento" HeaderText="Descuento" SortExpression="descuento" />
                    <asp:BoundField DataField="id_modelos" HeaderText="ID Modelos" SortExpression="id_modelos" />
                    <asp:CommandField CancelText="Cancelar" DeleteText="Eliminar" EditText="Editar" HeaderText="Acción" InsertText="Insertar" NewText="Nuevo" SelectText="Seleccionar" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Actualizar" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:autosConnectionString %>" DeleteCommand="DELETE FROM [repuestos] WHERE [id_rep] = @original_id_rep AND (([nombre] = @original_nombre) OR ([nombre] IS NULL AND @original_nombre IS NULL)) AND (([precio] = @original_precio) OR ([precio] IS NULL AND @original_precio IS NULL)) AND (([descuento] = @original_descuento) OR ([descuento] IS NULL AND @original_descuento IS NULL)) AND (([id_modelos] = @original_id_modelos) OR ([id_modelos] IS NULL AND @original_id_modelos IS NULL))" InsertCommand="INSERT INTO [repuestos] ([nombre], [precio], [descuento], [id_modelos]) VALUES (@nombre, @precio, @descuento, @id_modelos)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [nombre], [precio], [descuento], [id_rep], [id_modelos] FROM [repuestos]" UpdateCommand="UPDATE [repuestos] SET [nombre] = @nombre, [precio] = @precio, [descuento] = @descuento, [id_modelos] = @id_modelos WHERE [id_rep] = @original_id_rep AND (([nombre] = @original_nombre) OR ([nombre] IS NULL AND @original_nombre IS NULL)) AND (([precio] = @original_precio) OR ([precio] IS NULL AND @original_precio IS NULL)) AND (([descuento] = @original_descuento) OR ([descuento] IS NULL AND @original_descuento IS NULL)) AND (([id_modelos] = @original_id_modelos) OR ([id_modelos] IS NULL AND @original_id_modelos IS NULL))">
                <DeleteParameters>
                    <asp:Parameter Name="original_id_rep" Type="Int32" />
                    <asp:Parameter Name="original_nombre" Type="String" />
                    <asp:Parameter Name="original_precio" Type="Decimal" />
                    <asp:Parameter Name="original_descuento" Type="Int32" />
                    <asp:Parameter Name="original_id_modelos" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="precio" Type="Decimal" />
                    <asp:Parameter Name="descuento" Type="Int32" />
                    <asp:Parameter Name="id_modelos" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="precio" Type="Decimal" />
                    <asp:Parameter Name="descuento" Type="Int32" />
                    <asp:Parameter Name="id_modelos" Type="Int32" />
                    <asp:Parameter Name="original_id_rep" Type="Int32" />
                    <asp:Parameter Name="original_nombre" Type="String" />
                    <asp:Parameter Name="original_precio" Type="Decimal" />
                    <asp:Parameter Name="original_descuento" Type="Int32" />
                    <asp:Parameter Name="original_id_modelos" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target=".bs-example-modal-lg">Agregar</button>
            <div class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel">
                <div class="modal-dialog modal-lg" role="document">
                    <div class="modal-content">
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
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>

