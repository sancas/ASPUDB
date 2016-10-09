using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumidor
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            Matematica.MatematicasSoapClient servi = new Matematica.MatematicasSoapClient();
            lblResultado.Text = "Suma : " + servi.Sumar(double.Parse(txtNumber1.Text), double.Parse(txtNumber2.Text));
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            Matematica.MatematicasSoapClient servi = new Matematica.MatematicasSoapClient();
            lblResultado.Text = "Resta : " + servi.Restar(double.Parse(txtNumber1.Text), double.Parse(txtNumber2.Text));
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Matematica.MatematicasSoapClient servi = new Matematica.MatematicasSoapClient();
            lblResultado.Text = "Multiplicacion : " + servi.Multiplicar(double.Parse(txtNumber1.Text), double.Parse(txtNumber2.Text));
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            Matematica.MatematicasSoapClient servi = new Matematica.MatematicasSoapClient();
            lblResultado.Text = "Division : " + servi.Dividir(double.Parse(txtNumber1.Text), double.Parse(txtNumber2.Text));
        }
    }
}