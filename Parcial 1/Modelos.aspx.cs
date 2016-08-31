using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string texto = "SELECT * FROM modelos";
        Master abc = new Master();
        abc.ini();
        abc.recibe(texto);
        gridModelos.DataSource = abc.reg;
        gridModelos.DataBind();
    }
}