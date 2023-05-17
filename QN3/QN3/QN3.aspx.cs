using System;

namespace QN3
{
    public partial class QN3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errMsg1.InnerHtml = String.Empty;
            errMsg2.InnerHtml = String.Empty;
            errMsg3.InnerHtml = String.Empty;
            errMsg4.InnerHtml = String.Empty;
            lblAnnualCalculated.InnerHtml = String.Empty;
            lblResult.InnerHtml = String.Empty;
        }

        protected void btnClearInput_Click(object sender, EventArgs e)
        {
            drlGender.SelectedIndex = 0;
            drlStatus.SelectedIndex = 0;
            txtMonthlySalary.Text = string.Empty;
            txtGrossSalary.Text = string.Empty;
            errMsg1.InnerHtml = String.Empty;
            errMsg2.InnerHtml = String.Empty;
            errMsg3.InnerHtml = String.Empty;
            errMsg4.InnerHtml = String.Empty;
            lblAnnualCalculated.InnerHtml = String.Empty;
            lblResult.InnerHtml = String.Empty;
        }

        protected void btnCalculateTax_Click(object sender, EventArgs e)
        {
            string selectedGender = drlGender.SelectedValue;
            string selectedStatus = drlStatus.SelectedValue;
            string monthlySalary = txtMonthlySalary.Text;
            string annualIncome = txtGrossSalary.Text;

            int error = 0;

            double annualIncomeCalculated = 0;
            double yearlyInncomeConverted = 0;
            double finalIncomeCalc = 0;
            double calculatedTax = 0;

            if (drlGender.SelectedIndex == 0)
            {
                error++;
                errMsg1.InnerHtml = "**Please select a gender.";
            }
            if(drlStatus.SelectedIndex == 0)
            {
                error++;
                errMsg2.InnerHtml = "**Please select merried status.";
            }
            if (string.IsNullOrWhiteSpace(txtMonthlySalary.Text) && string.IsNullOrWhiteSpace(txtGrossSalary.Text))
            {
                error++;
                errMsg3.InnerHtml = "**Please insert valid value in any one box.";
            }

            if (!string.IsNullOrWhiteSpace(txtMonthlySalary.Text)) 
            { 
                double monthlySalaryConverted = Convert.ToDouble(txtMonthlySalary.Text);
                annualIncomeCalculated = monthlySalaryConverted * 12;
                lblAnnualCalculated.InnerHtml = "as Calculated: " + annualIncomeCalculated;
            }
            if (!string.IsNullOrWhiteSpace(txtGrossSalary.Text))
            {
                yearlyInncomeConverted = Convert.ToDouble(txtGrossSalary.Text);
            }
            if(!string.IsNullOrWhiteSpace(txtMonthlySalary.Text) && !string.IsNullOrWhiteSpace(txtGrossSalary.Text))
            {
                if(annualIncomeCalculated != yearlyInncomeConverted)
                {
                    error++;
                    errMsg4.InnerHtml = "**Annual income calculated and Gross salary should be same";
                }
                else if(annualIncomeCalculated == yearlyInncomeConverted)
                {
                    finalIncomeCalc = annualIncomeCalculated;
                }
            }
            else if(!string.IsNullOrWhiteSpace(txtMonthlySalary.Text) && string.IsNullOrWhiteSpace(txtGrossSalary.Text))
            {
                finalIncomeCalc = annualIncomeCalculated;
            }
            else if(string.IsNullOrWhiteSpace(txtMonthlySalary.Text) && !string.IsNullOrWhiteSpace(txtGrossSalary.Text))
            {
                finalIncomeCalc = yearlyInncomeConverted;
            }
            if (error == 0)
            {

                if (selectedStatus== "married")
                {
                    if (finalIncomeCalc <= 450000)
                    {
                        calculatedTax = (finalIncomeCalc * 1) / 100;
                    }
                    else if (finalIncomeCalc <= 550000)
                    {
                        double remAmt = finalIncomeCalc-450000;
                        double for450 = (450000 * 1) / 100;
                        double forRemTax = (remAmt * 10) / 100;
                        calculatedTax = for450 + forRemTax;
                    }
                    else if (finalIncomeCalc <= 750000)
                    {
                        double remAmt = finalIncomeCalc - 450000;
                        double for450 = (450000 * 1) / 100;
                        double remAmt2 = remAmt - 100000;
                        double for550 = (100000 * 10) / 100;
                        double forRemTax = (remAmt2 * 20) / 100;
                        calculatedTax = for450 + for550 + forRemTax;
                    }
                    else if (finalIncomeCalc <= 1300000)
                    {
                        double remAmt = finalIncomeCalc - 450000;
                        double for450 = (450000 * 1) / 100;
                        double remAmt2 = remAmt - 100000;
                        double for550 = (100000 * 10) / 100;
                        double remAmt3 = remAmt2 - 200000;
                        double for750 = (200000 * 20) / 100;
                        double forRemTax = (remAmt3 * 30) / 100;
                        calculatedTax = for450 + for550 + for750 + forRemTax;
                    }
                    else if (finalIncomeCalc > 1300000)
                    {
                        double remAmt = finalIncomeCalc - 450000;
                        double for450 = (450000 * 1) / 100;
                        double remAmt2 = remAmt - 100000;
                        double for550 = (100000 * 10) / 100;
                        double remAmt3 = remAmt2 - 200000;
                        double for750 = (200000 * 20) / 100;
                        double remAmt4 = remAmt3 - 550000;
                        double for1300 = (550000 * 30) / 100;
                        double forRemTax = (remAmt4 * 35) / 100;
                        calculatedTax = for450 + for550 + for750 + for1300 + forRemTax;
                    }
                }
                else if(selectedStatus == "unmarried")
                {
                    if (finalIncomeCalc <= 400000)
                    {
                        calculatedTax = (finalIncomeCalc * 1) / 100;
                    }
                    else if (finalIncomeCalc <= 500000)
                    {
                        double remAmt = finalIncomeCalc - 400000;
                        double for400 = (400000 * 1) / 100;
                        double forRemTax = (remAmt * 10) / 100;
                        calculatedTax = for400 + forRemTax;
                    }
                    else if (finalIncomeCalc <= 750000)
                    {
                        double remAmt = finalIncomeCalc - 400000;
                        double for400 = (400000 * 1) / 100;
                        double remAmt2 = remAmt - 100000;
                        double for500 = (100000 * 10) / 100;
                        double forRemTax = (remAmt2 * 20) / 100;
                        calculatedTax = for400 + for500 + forRemTax;
                    }
                    else if (finalIncomeCalc <= 1300000)
                    {
                        double remAmt = finalIncomeCalc - 400000;
                        double for400 = (400000 * 1) / 100;
                        double remAmt2 = remAmt - 100000;
                        double for500 = (100000 * 10) / 100;
                        double remAmt3 = remAmt2 - 250000;
                        double for750 = (250000 * 20) / 100;
                        double forRemTax = (remAmt3 * 30) / 100;
                        calculatedTax = for400 + for500 + for750 + forRemTax;
                    }
                    else if (finalIncomeCalc > 1300000)
                    {
                        double remAmt = finalIncomeCalc - 400000;
                        double for400 = (400000 * 1) / 100;
                        double remAmt2 = remAmt - 100000;
                        double for500 = (100000 * 10) / 100;
                        double remAmt3 = remAmt2 - 250000;
                        double for750 = (250000 * 20) / 100;
                        double remAmt4 = remAmt3 - 550000;
                        double for1300 = (550000 * 30) / 100;
                        double forRemTax = (remAmt4 * 35) / 100;
                        calculatedTax = for400 + for500 + for750 + for1300 + forRemTax;
                    }
                }
                if(selectedGender == "female")
                {
                    double lessTax = (calculatedTax * 10) / 100;
                    calculatedTax = calculatedTax - lessTax ;
                }
                else if (selectedGender == "others")
                {
                    double lessTax = (calculatedTax * 15) / 100;
                    calculatedTax = calculatedTax - lessTax;
                }
                lblResult.InnerHtml = calculatedTax.ToString();
            }
        }
    }
}