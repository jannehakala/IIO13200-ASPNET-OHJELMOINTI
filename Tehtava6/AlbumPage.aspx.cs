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
        xml.Load("D:\\H3298\\REPOS\\IIO13200-ASPNET-OHJELMOINTI\\Tehtava6\\App_Data\\LevykauppaX.xml");

        string albumInfo = string.Format("/Record/genre[@name = 'Pop']/record[@ISBN = '{0}']", album);
        string songNode = string.Format("/Records/genre[@name = 'Pop']/record[@ISBN = '{0}']/song", album);


        XmlNodeList xnlist1 = xml.SelectNodes(albumInfo);
        XmlNodeList xnlist2 = xml.SelectNodes(songNode);
        albumInfos.InnerHtml = "dsf";
        foreach (XmlNode xn in xnlist1) {
            albumInfos.InnerHtml += xn.Attributes["Artist"].Value;
            albumInfos.InnerHtml += " : " + xn.Attributes["Title"].Value;
        }

        foreach (XmlNode xn in xnlist2) {
            albumSongs.InnerHtml += xn.Attributes["name"].Value +"<br>";
        }
        
    }
}