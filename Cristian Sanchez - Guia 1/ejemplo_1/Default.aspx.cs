using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void btnSumar_Click(object sender, EventArgs e)
    {
        int valor = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
        Label1.Text = valor.ToString();
    }
}