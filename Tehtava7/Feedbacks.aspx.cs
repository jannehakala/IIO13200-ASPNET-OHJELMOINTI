using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Feedbacks : System.Web.UI.Page {
    private static string connStr = ConfigurationManager.ConnectionStrings["mysli"].ConnectionString;
    private string xmlFile = "";

    protected void Page_Load(object sender, EventArgs e) {
        xmlFile = ConfigurationManager.AppSettings["file"];
    }

    protected void btnGetFeedbacksFromXML_Click(object sender, EventArgs e) {

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlFile));
        dt = ds.Tables[0];
        dv = dt.DefaultView;

        gvFeedbacks.DataSource = dv;
        gvFeedbacks.DataBind();
        lblMessage.Text = string.Format("Haettu {0} palautetta", dt.Rows.Count);
    }

    protected void btnGiveFeedback_Click(object sender, EventArgs e) {
        Response.Redirect("CourseFeedback.aspx");
    }

    protected void btnGetFeedbacksFromMySQL_Click(object sender, EventArgs e) {
        try {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM palaute;", conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dataTable);
            
            gvFeedbacksMySQL.DataSource = dataTable;
            gvFeedbacksMySQL.DataBind();
            lblMessage2.Text = string.Format("Haettu {0} palautetta", dataTable.Rows.Count);
        } catch (Exception ex) {
            lblMessage.Text = ex.Message;
        }
    }
}