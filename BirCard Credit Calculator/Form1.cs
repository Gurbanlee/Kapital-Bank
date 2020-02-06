using System;
using System.Windows.Forms;

namespace BirCard_Credit_Calculator
{
    public partial class BirCard : Form
    {
        public BirCard()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var cash = nudCash.Value;
            var startDate = dpCashDate.Value;
            var endDate = dtPayDate.Value;
            double diffDate = Convert.ToInt32(-1 * (startDate - endDate).TotalDays);
            lblDateDiff.Text = diffDate.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudCash.Value = 2;
        }
    }
}
