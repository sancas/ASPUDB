using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.convertidorSoapClient servi = new ServiceReference1.convertidorSoapClient();
        Double Importe = servi.DollarToYenes(double.Parse(TextBox1.Text));
        Label1.Text = Importe.ToString();
    }
}