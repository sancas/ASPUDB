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
        lblOperacion.Text = "";
        lblResultado.Text = "";
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "Sumar")
            lblOperacion.Text = "+";
        else if (RadioButtonList1.SelectedValue == "Restar")
            lblOperacion.Text = "-";
        else if (RadioButtonList1.SelectedValue == "Multiplicar")
            lblOperacion.Text = "*";
        else if (RadioButtonList1.SelectedValue == "Dividir")
            lblOperacion.Text = "/";
    }
    protected void btnOperar_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "Sumar")
            lblResultado.Text = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)).ToString();
        else if (RadioButtonList1.SelectedValue == "Restar")
            lblResultado.Text = (int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text)).ToString();
        else if (RadioButtonList1.SelectedValue == "Multiplicar")
            lblResultado.Text = (int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text)).ToString();
        else if (RadioButtonList1.SelectedValue == "Dividir" && txtNum2.Text != "0")
            lblResultado.Text = (int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text)).ToString();
        else
            lblResultado.Text = "";
    }
}