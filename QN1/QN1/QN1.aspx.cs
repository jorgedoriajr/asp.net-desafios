using System;

namespace QN1
{
    public partial class QN1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errNum1.InnerHtml = String.Empty;
            errNum2.InnerHtml = String.Empty;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int addNumber1 = Convert.ToInt32(txtNum1.Text);
                int addNumber2 = Convert.ToInt32(txtNum2.Text);
                int addResult = addNumber1 + addNumber2;
                lblResult.InnerText = "The SUM: " + addResult;
            }
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int subNumber1 = Convert.ToInt32(txtNum1.Text);
                int subNumber2 = Convert.ToInt32(txtNum2.Text);
                int subResult = subNumber1 - subNumber2;
                lblResult.InnerText = "Subtract from Num1 - Num2: " + subResult;
            }
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int divNumber1 = Convert.ToInt32(txtNum1.Text);
                int divNumber2 = Convert.ToInt32(txtNum2.Text);
                float divResult = divNumber1 / divNumber2;
                lblResult.InnerText = "Division Num1 / Num2: " + divResult;
            }
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int mulNumber1 = Convert.ToInt32(txtNum1.Text);
                int mulNumber2 = Convert.ToInt32(txtNum2.Text);
                int mulResult = mulNumber1 * mulNumber2;
                lblResult.InnerText = "Multiplication: " + mulResult;
            }
        }

        private bool ValidateInput()
        {
            int error = 0;

            if (String.IsNullOrWhiteSpace(txtNum1.Text))
            {
                error++;
                errNum1.InnerHtml = "Enter Valid First Number";
            }
            else
            {
                errNum1.InnerHtml = "";
            }

            if (String.IsNullOrWhiteSpace(txtNum2.Text))
            {
                error++;
                errNum2.InnerHtml = "Enter Valid Second Number";
            }
            else
            {
                errNum2.InnerHtml = "";
            }

            return error == 0;
        }
    }
}
