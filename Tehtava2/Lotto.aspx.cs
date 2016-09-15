using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lotto : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnGetLottoNumbers_Click(object sender, EventArgs e) {
        try {
            lblDrawnLottoNumbers.Text = String.Empty;
            BLLotto lotto = new BLLotto();
            if (int.Parse(txtRowAmount.Text) > 0) {
                for (int i = 0; i < int.Parse(txtRowAmount.Text); i++) {
                    lblDrawnLottoNumbers.Text += lotto.drawGame(ddLottoTypes.Text) + "<br/>";
                }
                lblMessage.Text = "Arvonta onnistui!";
            } else {
                lblMessage.Text = "Liian vähän rivejä valittu.";
            }
        } catch (Exception ex) {
            lblMessage.Text = ex.Message;
        }
    }
}