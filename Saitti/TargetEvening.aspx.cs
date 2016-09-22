using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TargetEvening : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string msg = "";

        msg += "<h3>QueryString</h3>";
        msg += "URLissa välitetty viesti: " + Request.QueryString["Message"];
        msg += "<br/>";

        foreach (string key in Request.QueryString) {
            msg += "URLista löytyy avain: " + key + " ja sen arvo on " +
                Request.QueryString[key] + "<br/>";
        }
        msg += "<h3>Session</h3>";
        msg += "Sessionista haettu viesti: " + Session["Message"];

        msg += "<h3>Cookie<h3>";
        foreach (string kex in Request.Cookies) {
            if (kex == "Message")
                msg += "Keksissä lukee " + Request.Cookies[kex].Value;
        }
        msg += "<h3>Propertyn lukeminen</h3>";
        var previouspage = PreviousPage;
        if (previouspage != null) {
            msg += "Ed. sivun Property on " + previouspage.SecretMessage;
        }

        mytext.InnerHtml = msg;
    }
}