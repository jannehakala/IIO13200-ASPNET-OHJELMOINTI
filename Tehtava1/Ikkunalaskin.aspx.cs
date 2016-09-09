using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ikkunalaskin : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnCalculatePrice_Click(object sender, EventArgs e) {
        double WindowWidth;
        double WindowHeight;
        double FrameWidth;
        double area;
        double perimeter;
        double price;
        double margin;
        double windowsquareprice;
        double frameprice;
        double workcost;

        try {
            WindowWidth = double.Parse(txtWindowWidth.Text);
            WindowHeight = double.Parse(txtWindowHeight.Text);
            FrameWidth = double.Parse(txtFrameWidth.Text);

            margin = double.Parse(ConfigurationManager.AppSettings["margin"]);
            windowsquareprice = double.Parse(ConfigurationManager.AppSettings["windowsquareprice"]);
            frameprice = double.Parse(ConfigurationManager.AppSettings["frameprice"]);
            workcost = double.Parse(ConfigurationManager.AppSettings["workcost"]);

            area = WindowWidth * WindowHeight / 1000000;
            lblResultWindowArea.Text = area.ToString("0.##") + " m^2";

            perimeter = (((WindowWidth * 2) + (WindowHeight * 2) + FrameWidth * 4) / 1000);
            lblResultFrameCircuit.Text = perimeter.ToString("0.##") + " m";

            price = ((1 + (margin / 100)) * (area * windowsquareprice) + (perimeter * frameprice) + (workcost));
            lblResultPrice.Text = price.ToString("0.##") + " €";

            lblMessage.Text = "Laskenta onnistui!";
            lblMessage.ForeColor = System.Drawing.Color.Black;

        } catch (Exception) {
            lblMessage.Text = "Käytit vääriä merkkejä tai jokin kenttä jäi tyhjäksi.";
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }
}