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
            lblCash.Text = cash.ToString();
            lblDateDiff.Text = diffDate.ToString();
            var cashBorc = cash * 1.5M / 100 + cash;
            var esasBorc = cashBorc * 0.05M;
            var faizBorc = (cashBorc * 25 / 100) / 360 * Convert.ToInt32(diffDate);
            var finalBorc = esasBorc + faizBorc;
            lblPay.Text = finalBorc.ToString().ToUpper();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudCash.Value = 2;
        }

        private void lblDateDiff_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nudCash_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dpCashDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtPayDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPay_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCash_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
