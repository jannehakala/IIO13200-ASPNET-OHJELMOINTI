using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaeOppilaatIlta : Page {
    private static string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["oppilaat"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnGet3_Click(object sender, EventArgs e) {
        //haetaan valmiilta luokan metodilta dataa ja kiinnitetään se kontrolliin
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();
    }

    protected void btnGetAll_Click(object sender, EventArgs e) {
        string message = "";
        try {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(connStr, "oppilaat", out message);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
            lblMessage.Text = message;
        } catch (Exception ex) { 
            lblMessage.Text = ex.Message;
        }
    }

    protected void btnGet3oppilas_Click(object sender, EventArgs e) {
        //haetaan valmiista bisneslogiikasta oppilas-olioita ja kiinnitetään ne kontrollin datasourceksi
        var oppilaat = new JAMK.ICT.BL.Oppilaat().Hae3TestiOppilasta();
        gvStudents.DataSource = oppilaat;
        gvStudents.DataBind();
    }
}