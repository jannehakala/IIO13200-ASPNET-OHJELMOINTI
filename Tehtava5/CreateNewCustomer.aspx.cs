using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateNewCustomer : System.Web.UI.Page {
    protected static DemoxOyEntities ctx;
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ctx = new DemoxOyEntities();
        }
    }


    #region METHODS

    protected void CreateNew() {

        if (txtID.Text != "" && txtCustomerName.Text != "" && txtContactPerson.Text != "" &&
            txtCountryCode.Text != "" && txtPostalCode.Text != "" && txtPostOffice.Text != ""
            && txtPurchases.Text != "" && txtCustomerYear.Text != "") {
            try {
                asiakas asiakas;

                asiakas = new asiakas();

                asiakas.astunnus = txtID.Text;
                asiakas.asnimi = txtCustomerName.Text;
                asiakas.yhteyshlo = txtContactPerson.Text;
                asiakas.maa = txtCountryCode.Text;
                asiakas.postinro = txtPostalCode.Text;
                asiakas.postitmp = txtPostOffice.Text;
                asiakas.ostot = double.Parse(txtPurchases.Text);
                asiakas.asvuosi = (Int16)int.Parse(txtCustomerYear.Text);

                ctx.asiakas.Add(asiakas);
                ctx.SaveChanges();

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Asiakas lisättiin onnistuneesti.";
            } catch (Exception ex) {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
            }
            
        } else {
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = "Täytä kaikki kentät.";
        }
    }

    #endregion

    protected void btnCreateNewCustomer_Click(object sender, EventArgs e) {
        CreateNew();
    }
}