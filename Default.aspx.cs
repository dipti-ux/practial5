using System;
using System.Web;

namespace Practicle_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Session
                if (Session["UserName"] == null)
                {
                    Session["UserName"] = "";
                }

                lblWelcome.Text = "Welcome,Dipti, " +
                    Session["UserName"].ToString();

                // Cookie
                if (Request.Cookies["UserName"] == null)
                {
                    HttpCookie cookie = new HttpCookie("UserName");

                    cookie.Value = Session["UserName"].ToString();

                    cookie.Expires = DateTime.Now.AddDays(7);

                    Response.Cookies.Add(cookie);
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text =
                "Selected Date: " +
                Calendar1.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("Default.aspx");
        }
    }
}