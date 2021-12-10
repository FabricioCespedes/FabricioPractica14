using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FabricioPractica14
{
    public partial class wfrmAbrirSeccionAplicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            idlUser.Text = Session["_user"].ToString();
            idlTotal.Text = Application["_cont"].ToString();

        }
    }
}