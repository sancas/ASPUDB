using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddRepuestos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Master abc = new Master();
        string texto = "INSERT INTO repuestos (nombre,precio,descuento,id_modelos) VALUES ('" + txtNombre.Text + "','" + txtPrecio.Text + "','" + txtDescuento.Text + "','" + txtIDModelo.Text + "')";
        abc.ini();
        abc.envia(texto);
        abc.fin();
        Response.Redirect("Repuestos.aspx?opc=success");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Repuestos.aspx");
    }
}