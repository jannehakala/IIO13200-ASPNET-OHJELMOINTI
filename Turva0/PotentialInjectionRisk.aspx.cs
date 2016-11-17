using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


public partial class PotentialInjectionRisk : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
        if (!IsPostBack) {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
  }

    protected void btnCommit_Click(object sender, EventArgs e) {
        string name = txtName.Text;
        string comment = txtComment.Text;
        string date = txtDate.Text;

        //string sql = string.Format("INSERT INTO comment (name, comment, date) VALUES ('{0}', '{1}', '{2}');", name, comment, date);

        string sql = string.Format("INSERT INTO comment (name, comment, date) VALUES (@name, @comment, @date)");


        try {

            MySqlConnection conn = new MySqlConnection(myComments.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@comment", comment);
            cmd.Parameters.AddWithValue("@date", date);
            int count = cmd.ExecuteNonQuery();
            lblMessages.Text = string.Format("Lisätty {0} onnistuneesti tietokantaan", count);
            gvComments.DataBind();
        } catch (Exception ex) {
            lblMessages.Text = ex.Message;
        }
    }
}