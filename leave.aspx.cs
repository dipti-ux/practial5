using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Practicle_5
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check Session
            if (Session["UserName"] == null)
            {
                Session["UserName"] = "Student";
            }

            lblUser.Text = "Welcome, " +
                           Session["UserName"].ToString();

            if (!IsPostBack)
            {
                CreateLeaveTable();
            }
        }

        protected void Calendar1_SelectionChanged(
            object sender, EventArgs e)
        {
            lblDate.Text = "Selected Leave Date: " +
                Calendar1.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnApply_Click(
            object sender, EventArgs e)
        {
            // Validation
            if (ddlLeaveType.SelectedValue == "")
            {
                lblMessage.Text = "Please select a leave type.";
                lblMessage.ForeColor =
                    System.Drawing.Color.Red;
                return;
            }

            if (txtReason.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter the reason.";
                lblMessage.ForeColor =
                    System.Drawing.Color.Red;
                return;
            }

            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                lblMessage.Text = "Please select a leave date.";
                lblMessage.ForeColor =
                    System.Drawing.Color.Red;
                return;
            }

            // Store leave details in Session
            DataTable dt = Session["LeaveApplications"]
                           as DataTable;

            if (dt == null)
            {
                dt = CreateLeaveTable();
            }

            DataRow row = dt.NewRow();

            row["UserName"] =
                Session["UserName"].ToString();

            row["LeaveType"] =
                ddlLeaveType.SelectedItem.Text;

            row["Reason"] =
                txtReason.Text.Trim();

            row["LeaveDate"] =
                Calendar1.SelectedDate.ToString("dd-MM-yyyy");

            row["Status"] = "Pending";

            dt.Rows.Add(row);

            Session["LeaveApplications"] = dt;

            // Store last leave type in Cookie
            Response.Cookies["LastLeaveType"].Value =
                ddlLeaveType.SelectedValue;

            Response.Cookies["LastLeaveType"].Expires =
                DateTime.Now.AddDays(7);

            lblMessage.Text =
                "Leave application submitted successfully.";

            lblMessage.ForeColor =
                System.Drawing.Color.Green;

            // Clear fields
            ddlLeaveType.SelectedIndex = 0;
            txtReason.Text = "";
            lblDate.Text = "";

            // Display applications
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        private DataTable CreateLeaveTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("UserName");
            dt.Columns.Add("LeaveType");
            dt.Columns.Add("Reason");
            dt.Columns.Add("LeaveDate");
            dt.Columns.Add("Status");

            Session["LeaveApplications"] = dt;

            GridView1.DataSource = dt;
            GridView1.DataBind();

            return dt;
        }
    }
}
