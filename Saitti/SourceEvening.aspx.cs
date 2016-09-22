using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SourceEvening : System.Web.UI.Page {

    public string SecretMessage {
        get { return txtMessage.Text; }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ddlMessages.Items.Add("Hello");
            ddlMessages.Items.Add("Ping?");
            ddlMessages.Items.Add("Handshake?");
            ddlMessages.Items.Add("Goodbye!");
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e) {
        Response.Redirect("TargetEvening.aspx?User=Esa&Message=" + txtMessage.Text);
    }

    protected void bntSession_Click(object sender, EventArgs e) {
        Session["Message"] = txtMessage.Text;
        Response.Redirect("TargetEvening.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e) {
        HttpCookie cookie = new HttpCookie("Message", txtMessage.Text);
        cookie.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(cookie);
    }

    protected void btnPublicProperty_Click(object sender, EventArgs e) {
        Server.Transfer("TargetEvening.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e) {
        txtMessage.Text = ddlMessages.SelectedItem.ToString();
    }
}