using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FabricioPractica14
{
    public partial class wfrmConteoSeccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Session["_user"] = txtUsuario.Text;
            Response.Redirect("wfrmAbrirSeccionAplicacion.aspx");
        }

    }
}