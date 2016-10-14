using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Finnkino : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

        if (!IsPostBack) {
            Init();
        }
    }

    private void Init() {
        XmlDocument xml = new XmlDocument();
        xml.Load("http://www.finnkino.fi/xml/TheatreAreas/");

        string theatres = "/TheatreAreas/TheatreArea";
        XmlNodeList xnlist1 = xml.SelectNodes(theatres);

        Dictionary<int, string> dTheatre = new Dictionary<int, string>();

        int theatreID = 0;

        string theatreName = "";

        foreach (XmlNode xn in xnlist1) {
            theatreID = int.Parse(xn["ID"].InnerText);
            theatreName = xn["Name"].InnerText;
            dTheatre.Add(theatreID, theatreName);
        }

        lbTheatres.DataTextField = "Value";
        lbTheatres.DataValueField = "Key";
        lbTheatres.DataSource = dTheatre;
        lbTheatres.DataBind();
    }

    protected void lbTheatres_SelectedIndexChanged(object sender, EventArgs e) {
        Repeater1.DataSource = "test";
        Repeater1.DataBind();
        lblInfo.Text = "Elokuvateatteri " + lbTheatres.SelectedItem.Text + " valittu";
    }

    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e) {

        int area = int.Parse(lbTheatres.SelectedValue);
        DateTime today = DateTime.Today;

        string url = "http://www.finnkino.fi/xml/Schedule/?area=" + area + "&dt=" + today.ToString("dd.MM.yyyy");

        XmlDocument xml2 = new XmlDocument();
        xml2.Load(url);

        string movieImages = "/Schedule/Shows/Show/Images/EventLargeImagePortrait";
        XmlNodeList xnlist2 = xml2.SelectNodes(movieImages);
        foreach (XmlNode xn in xnlist2) {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {
                HtmlGenericControl myDiv = (HtmlGenericControl)e.Item.FindControl("myDiv");
                HtmlGenericControl img = new HtmlGenericControl("img");
                img.Attributes["src"] = xn.InnerText;
                myDiv.Controls.Add(img);
            }
        }
    }
}