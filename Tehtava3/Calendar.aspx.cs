using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calendar : System.Web.UI.Page {
    DateTime today;
    protected void Page_Load(object sender, EventArgs e) {   
        string date = "Tänään on: ";
        today = DateTime.Today;
        date += today.ToString("dd.MM.yyyy");
        mytext.InnerHtml = date;
        if (!IsPostBack) {
            cal1.VisibleDate = today;
        }
    }

    protected void cal1_SelectionChanged(object sender, EventArgs e) {
        DateTime selectedDate = cal1.SelectedDate;
        string selectedDateString = selectedDate.ToString("dd.MM.yyyy");
        string selectedDateWhole = selectedDateString;
        selectedDateWhole += " vuosi: ";
        selectedDateWhole += cal1.SelectedDate.Year;
        lblSelectedDate.Text = selectedDateWhole;

        if (selectedDate <= today) {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = today - selectedDate;

            int years = (zeroTime + span).Year - 1;
            int months = (zeroTime + span).Month - 1;
            int days = (zeroTime + span).Day - 1;

            lblDateDifference.Text = years + " vuotta " + months + " kuukautta ja " + days + " päivää.";
        } else {
            lblDateDifference.Text = "Valittu päivä on tulevaisuudessa.";
        }
    }

    protected void btnPreviousYear_Click(object sender, EventArgs e) {
        cal1.VisibleDate = cal1.VisibleDate.AddYears(-1);
    }

    protected void btnNextYear_Click(object sender, EventArgs e) {
        cal1.VisibleDate = cal1.VisibleDate.AddYears(1);
    }
}