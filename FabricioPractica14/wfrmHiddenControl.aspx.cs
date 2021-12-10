using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FabricioPractica14
{
    public partial class wfrmHiddenControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            hfValor.Value = txtNombre.Text;

            lblMostrar.Text = "";
            txtNombre.Text = "";
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {           
            lblMostrar.Text = hfValor.Value;
            lblMostrar.Visible = true;
        }
    }
}