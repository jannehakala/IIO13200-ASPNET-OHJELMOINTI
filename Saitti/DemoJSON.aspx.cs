using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using JAMK.IT;
public partial class DemoJSON : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnGet_Click(object sender, EventArgs e) {
        try {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP.txt");
            ltResult.Text = json;
        } catch (Exception ex) {

            ltResult.Text = ex.Message;
        }
    }

    protected string GetJsonFrom(string url) {
        using (WebClient wc = new WebClient()) {
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected void btnGetPerson_Click(object sender, EventArgs e) {
        try {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP.txt");
            JAMK.IT.Person p = JsonConvert.DeserializeObject<Person>(json);
            ltResult.Text = string.Format("Löytyi henkilö {0}, syntynyt {1}", p.Name, p.Birthday);
        } catch (Exception ex) {

            ltResult.Text = ex.Message;
        }
    }

    protected void btnGetPolticis_Click(object sender, EventArgs e) {
        try {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
            List<Politician> government = JsonConvert.DeserializeObject<List<Politician>>(json);
            string ret = "<h2>Suomen vankka hallitus</h2><ul>";
            foreach (var minister in government) {
                ret += "<li>" + minister.Name + " " + minister.Party + "</li>";
            }
            ret += "</ul>";

            ltResult.Text = ret;
        } catch (Exception ex) {

            ltResult.Text = ex.Message;
        }
    }
}