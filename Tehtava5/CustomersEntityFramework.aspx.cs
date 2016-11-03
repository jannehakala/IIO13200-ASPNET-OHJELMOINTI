using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomersEntityFramework : System.Web.UI.Page {
    protected static DemoxOyEntities ctx;
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ctx = new DemoxOyEntities();
            Init();
        }
    }

    #region METHODS

    protected void GetAllCustomers() {
        gvCustomers.DataSource = ctx.asiakas.ToList();
        gvCustomers.DataBind();
        int i = ctx.asiakas.Count();

        lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
    }

    protected void Init() {

        //var countryCode = from c in ctx.asiakas
        //                 orderby c.maa
        //                 select c;
        var countryCode = ctx.asiakas.OrderBy(x => x.maa);
        ddList.DataSource = countryCode.ToList();
        ddList.DataTextField = "maa";
        ddList.DataBind();
    }

    #endregion


    protected void btnGetAllCustomers_Click(object sender, EventArgs e) {
        GetAllCustomers();
    }

    protected void btnGetCustomersFromCountry_Click(object sender, EventArgs e) {

        var customer = from c in ctx.asiakas
                       where c.maa == "GBR"
                       select c;
        gvCustomers.DataSource = customer.ToList();
        gvCustomers.DataBind();
        int i = ctx.asiakas.Count();

        lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
    }

    protected void btnGetCustomersBasedOnCountry_Click(object sender, EventArgs e) {

    }
}