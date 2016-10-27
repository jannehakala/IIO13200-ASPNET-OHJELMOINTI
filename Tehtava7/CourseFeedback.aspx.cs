using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CourseFeedback : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    

    

    protected void btnSendXML_Click(object sender, EventArgs e) {

    }

    protected void btnSendMySQL_Click(object sender, EventArgs e) {

    }

    protected void btnCheckFeedbacks_Click(object sender, EventArgs e) {
        Response.Redirect("Feedbacks.aspx");
    }
}