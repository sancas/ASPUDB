using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string texto = "SELECT * FROM marca";
        Master abc = new Master();
        abc.ini();
        abc.recibe(texto);
        gridMarcas.DataSource = abc.reg;
        gridMarcas.DataBind();    }
}