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
            double diffDate = -1*(startDate - endDate).TotalDays;
            lblDateDiff.Text = Convert.ToInt32(diffDate).ToString();
        }
    }
}
