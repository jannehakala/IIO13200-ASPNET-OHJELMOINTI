using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestMySql : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnGetArtists_Click(object sender, EventArgs e) {
        try {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["Mysli"].ConnectionString;
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetArtists(cs);
            gvArtists.DataSource = dt;
            gvArtists.DataBind();
        } catch (Exception ex) {
            lblMessages.Text = ex.ToString();
        }
    }
}