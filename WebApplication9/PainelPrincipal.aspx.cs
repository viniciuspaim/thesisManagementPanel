using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace thesisManagementPanel
{
    public partial class PainelPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script language=javascript>alert('Seja bem vindo " + Session["usr"].ToString() + "');</script>");
        }
    }
}