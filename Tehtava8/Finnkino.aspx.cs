using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Finnkino : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

        if (!IsPostBack) {
            XmlDocument xml = new XmlDocument();
            xml.Load("http://www.finnkino.fi/xml/TheatreAreas/");

            string theatres = "/TheatreAreas/TheatreArea/Name";

            XmlNodeList xnlist1 = xml.SelectNodes(theatres);

            foreach (XmlNode xn in xnlist1) {
                lbTheatres.Items.Add(xn.InnerText);
            }
        }
    }

    protected void lbTheatres_SelectedIndexChanged(object sender, EventArgs e) {
        lblInfo.Text = "Elokuvateatteri " + lbTheatres.SelectedItem.Text + " valittu"; 
    }
}