using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lotto : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        ddLottoTypes.Items.Add("Lotto");
        ddLottoTypes.Items.Add("Viking Lotto");
    }

    protected void btnGetLottoNumbers_Click(object sender, EventArgs e) {
        try {
            lblDrawnLottoNumbers.Text = String.Empty;
            BLLotto lotto = new BLLotto();
            for (int i = 0; i < int.Parse(txtRowAmount.Text); i++) {
                lblDrawnLottoNumbers.Text = lotto.drawGame(ddLottoTypes.Text);
            }
        } catch (Exception ex) {
            lblMessage.Text = ex.Message;
        }
    }
}