using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitJenkinsWeb
{
    public partial class AccountPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello");

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int c;

            c = Convert.ToInt32(txtNum1.Text)+ Convert.ToInt32(txtNum2.Text);

            Response.Write(c.ToString());
        }
    }
}