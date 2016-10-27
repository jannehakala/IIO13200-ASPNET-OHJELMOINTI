using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class CourseFeedback : System.Web.UI.Page {

    private string connString = ConfigurationManager.ConnectionStrings["mysli"].ConnectionString;
    private string xmlFile = "";

    protected void Page_Load(object sender, EventArgs e) {
        xmlFile = ConfigurationManager.AppSettings["file"];

        if (!IsPostBack) {
            DateTime today = DateTime.Today;

            txtDate.Text = today.ToString("dd.MM.yyyy");
        }
    }


    protected void btnSendXML_Click(object sender, EventArgs e) {
        if (txtDate.Text != "" && txtName.Text != "" && txtCourseID.Text != "" && txtLearned.Text != ""
           && txtWantLearn.Text != "" && txtGood.Text != "" && txtToMakeBetter.Text != "") {
            SaveToXML();
        } 
    }

    protected void btnSendMySQL_Click(object sender, EventArgs e) {
        if (txtDate.Text != "" && txtName.Text != "" && txtCourseID.Text != "" && txtLearned.Text != ""
           && txtWantLearn.Text != "" && txtGood.Text != "" && txtToMakeBetter.Text != "") {
            SaveToMySQL();
        } 
    }


    protected void SaveToXML() {

        try {
            XmlDocument XmlDocObj = new XmlDocument();
            XmlDocObj.Load(Server.MapPath(xmlFile));
            XmlNode RootNode = XmlDocObj.SelectSingleNode("palautteet");
            XmlNode feedbackNode = RootNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "palaute", ""));

            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Pvm", "")).InnerText = txtDate.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Nimi", "")).InnerText = txtName.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Kurssi", "")).InnerText = txtCourseID.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Opittu", "")).InnerText = txtLearned.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Haluan_oppia", "")).InnerText = txtWantLearn.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Hyvää", "")).InnerText = txtGood.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Parannettavaa", "")).InnerText = txtToMakeBetter.Text;
            feedbackNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Muuta", "")).InnerText = txtElse.Text;

            XmlDocObj.Save(Server.MapPath(xmlFile));

            txtName.Text = ""; txtCourseID.Text = ""; txtLearned.Text = ""; txtWantLearn.Text = ""; txtGood.Text = ""; txtToMakeBetter.Text = "";
            txtElse.Text = "";
        } catch (Exception ex) {

            lblMessage.Text = ex.Message;
        }
        
    }

    protected void SaveToMySQL() {
        try {
            MySqlConnection conn = new MySqlConnection(connString);        
            MySqlCommand comm = conn.CreateCommand();
            conn.Open();
            comm.CommandText = "INSERT INTO palaute(pvm, tekija, opintojakso, opittu, haluanoppia, hyvaa, parannettavaa, muuta) VALUES(@pvm, @tekija, @opintojakso, @opittu, @haluanoppia, @hyvaa, @parannettavaa, @muuta)";
            comm.Parameters.AddWithValue("@pvm", txtDate.Text);
            comm.Parameters.AddWithValue("@tekija", txtName.Text);
            comm.Parameters.AddWithValue("@opintojakso", txtCourseID.Text);
            comm.Parameters.AddWithValue("@opittu", txtLearned.Text);
            comm.Parameters.AddWithValue("@haluanoppia", txtWantLearn.Text);
            comm.Parameters.AddWithValue("@hyvaa", txtGood.Text);
            comm.Parameters.AddWithValue("@parannettavaa", txtToMakeBetter.Text);
            comm.Parameters.AddWithValue("@muuta", txtElse.Text);
            comm.ExecuteNonQuery();
            conn.Close();

            txtName.Text = ""; txtCourseID.Text = ""; txtLearned.Text = ""; txtWantLearn.Text = ""; txtGood.Text = ""; txtToMakeBetter.Text = "";
            txtElse.Text = "";
        } catch (Exception ex) {

            lblMessage.Text = ex.Message;
        }
    }

    

    protected void btnCheckFeedbacks_Click(object sender, EventArgs e) {
        Response.Redirect("Feedbacks.aspx");
    }

    public void CustomValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args) {
        args.IsValid = true;

        if (txtDate.Text == "" || txtName.Text == "" || txtCourseID.Text == "" || txtLearned.Text == ""
            || txtWantLearn.Text == "" || txtGood.Text == "" || txtToMakeBetter.Text == "") {
            CustomValidator1.ErrorMessage = "Täytä kaikki kentät, paitsi 'Muuta'!";
            args.IsValid = false;
        }else {
           
            lblMessage.Text = "Palautteen anto onnistui!";
        }
    }
}