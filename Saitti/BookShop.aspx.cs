using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookShop : System.Web.UI.Page {

    protected static BookShopEntities ctx;
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            ctx = new BookShopEntities();
            FillControls();
        }
    }

    #region METHODS
    
    protected void FillControls() {

        //var customers = from c in ctx.Customers
        //                orderby c.lastname
        //                select c;
        //lambda tyyli

        var customers = ctx.Customers.OrderBy(x => x.lastname);
        ddlCustomers.DataSource = customers.ToList();
        ddlCustomers.DataTextField = "lastname";
        ddlCustomers.DataValueField = "id";
        ddlCustomers.DataBind();
        ddlCustomers.Items.Insert(0, string.Empty);
    }


    protected void ShowCustomers() {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
        int i = ctx.Customers.Count();

        lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
    }

    protected void ShowBooks() {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
        int i = ctx.Books.Count();

        lblMessages.Text += string.Format(" ja haettu {0} kirjan tiedot", i);
    }

    protected void ShowCustomersOrders(Customer customer) {
        ltResult.Text = string.Format("Asiakkaalla {0} {1} on {2} tilausta", customer.firstname, customer.lastname, customer.Orders.Count);
        foreach (var o in customer.Orders) {
            ltResult.Text += string.Format("<br>- tilaus {0} sisältää {1} kirjaa:", o.odate, o.Orderitems.Count);
            foreach (var oi in o.Orderitems) {
                ltResult.Text += string.Format("<br>-- kirjaa {0}, {1} kpl {2}", oi.Book.name, oi.Book.author, oi.count);
            }  
        }
    }

    #endregion


    protected void btnGetCustomers_Click(object sender, EventArgs e) {
        ShowCustomers();
    }

    protected void btnGetBooks_Click(object sender, EventArgs e) {
        ShowBooks();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e) {

        if (ddlCustomers.SelectedIndex > 0) {
            int id = int.Parse(ddlCustomers.SelectedValue);
            var ret = from c in ctx.Customers
                      where c.id == id
                      select c;
            Customer customer = ret.FirstOrDefault();
            ShowCustomersOrders(customer);
        }
    }
}