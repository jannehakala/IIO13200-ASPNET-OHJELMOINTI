using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;
using JAMK.IT;
using System.Data;
using System.Text;

public partial class VRTrains : System.Web.UI.Page {

    DateTime thisDay = DateTime.Today;
    protected void Page_Load(object sender, EventArgs e) {

        if (!IsPostBack) {
            try {
                
                string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/metadata/stations");
                List<VR> vr = JsonConvert.DeserializeObject<List<VR>>(json);
                string result = "";
                var list = new List<string>();
                foreach (var city in vr) {
                    list.Add(city.stationShortCode);
                }

                list.Sort();

                ddListCities.DataSource = list;
                ddListCities.DataBind();

                lblText.Text = result;
            } catch (Exception ex) {
                lblText.Text = ex.Message;
            }
        }
    }

    protected string GetJsonFrom(string url) {
        using (WebClient wc = new WebClient()) {
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected void btnGetLeavingTrains_Click(object sender, EventArgs e) {
 
        try {
            
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Junan numero", typeof(int)),
                        new DataColumn("Peruutettu", typeof(string)),
                        new DataColumn("Pvm",typeof(string)) });

            string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/live-trains?station=" + ddListCities.Text);
            List <VR> vr = JsonConvert.DeserializeObject<List<VR>>(json);
            string result = "";
            if (vr.Count == 0) {
                lblText.Text = "Ei lähteviä junia tänään";
            } else { 
                foreach (var item in vr) {
                    dt.Rows.Add(item.trainNumber, item.cancelled, DateTime.Now.ToString("MM.dd.yyyy"));
                }

                lblText.Text = "Lähteviä junia löytyi: " + dt.Rows.Count + " junaa";
            }
            gvTrains.DataSource = dt;
            gvTrains.DataBind();

        } catch (Exception ex) {
            lblText.Text = ex.Message;
        }
    }
}