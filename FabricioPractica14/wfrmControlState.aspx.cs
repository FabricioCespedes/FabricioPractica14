using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FabricioPractica14
{
    public partial class wfrmControlState : System.Web.UI.Page
    {
        WebCustomControl1 webCustomControl1 = new WebCustomControl1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSummit_Click(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                webCustomControl1.Text = "This is a dummy Text";
                webCustomControl1.Text2 = "This is another dummy Text";
            }
        }
    }
}