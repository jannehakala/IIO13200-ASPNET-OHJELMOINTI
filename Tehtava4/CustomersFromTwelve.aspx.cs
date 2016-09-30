using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

public partial class CustomersFromTwelve : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        try {
            DataTable dt = JAMK.IT.DBDemoxOy.GetDataReal();
            gvCustomers2.DataSource = dt;
            gvCustomers2.DataBind();
        } catch (Exception ex) {
            
        }
    }
}