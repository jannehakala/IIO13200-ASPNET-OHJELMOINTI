using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class AlbumPage : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string album = Request.QueryString["value"];

        albumImage.Attributes["src"] = "images/" + album + ".jpg";

        XmlDocument xml = new XmlDocument();
        xml.Load(Server.MapPath("~/App_Data/LevykauppaX.xml"));

        string albumInfo = string.Format("/Records/genre[@name = 'Pop']/record[@ISBN = '{0}']", album);
        string songNode = string.Format("/Records/genre[@name = 'Pop']/record[@ISBN = '{0}']/song", album);

        XmlNodeList xnlist1 = xml.SelectNodes(albumInfo);
        XmlNodeList xnlist2 = xml.SelectNodes(songNode);

        foreach (XmlNode xn in xnlist1) {
            albumInfos.InnerHtml += " " + xn.Attributes["Artist"].Value;
            albumInfos.InnerHtml += " - " + xn.Attributes["Title"].Value + "<br><br> ";
            albumInfos.InnerHtml += "ISBN: " + xn.Attributes["ISBN"].Value + "<br><br>";
            albumInfos.InnerHtml += "Hinta: " + xn.Attributes["Price"].Value;
        }

        foreach (XmlNode xn in xnlist2) {
            albumSongs.InnerHtml += xn.Attributes["name"].Value +"<br>";
        } 
    }
}