using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QN2
{
    public partial class QN2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errInterest.InnerHtml = string.Empty;
            errTime.InnerHtml = string.Empty;
            errPrincipal.InnerHtml = string.Empty;

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            string principal = txtPrincipal.Text;
            string interest_rate = txtInterest.Text;
            string time = txtTime.Text;

            int error = 0;

            if (string.IsNullOrWhiteSpace(txtPrincipal.Text))
            {
                error++;
                errPrincipal.InnerHtml = "**Enter the valid value";
            }
            if (string.IsNullOrWhiteSpace(txtInterest.Text))
            {
                error++;
                errInterest.InnerHtml = "** Enter the valid rate of interest";
            }
            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                error++;
                errTime.InnerHtml = "**Enter the valid time(in year)";
            }
            if (error == 0)
            {
                double dPrincipal = Convert.ToDouble(txtPrincipal.Text);
                double dInterest_rate = Convert.ToDouble(txtInterest.Text);
                double dTime = Convert.ToDouble(txtTime.Text);

                double result = (dPrincipal * dTime * dInterest_rate) / 100;
                lblInterestAmountTotal.InnerHtml = result.ToString();

                double result_total = dPrincipal + result;
                lbllTotalPlusInterestTotal.InnerHtml = result_total.ToString();
            }


        }
    }
}