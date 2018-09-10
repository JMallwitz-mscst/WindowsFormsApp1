using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brazilTextChanged(object sender, EventArgs e)
        {
            txtUSBrazil.Text = (
                Convert.ToDecimal(txtAmountBrazil.Text) * Convert.ToDecimal(txtRateBrazil.Text)
                ).ToString("0.00");
        }

        private void japanTextChanged(object sender, EventArgs e)
        {
            txtUSJapan.Text = (
               Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateYen.Text)
               ).ToString("0.00");
        }

        private void koreaTextChanged(object sender, EventArgs e)
        {
            txtUSKorea.Text = (
               Convert.ToDecimal(txtAmountKorea.Text) * Convert.ToDecimal(txtRateWon.Text)
               ).ToString("0.00");
        }

        private void aussieTextChanged(object sender, EventArgs e)
        {
            txtUSAussie.Text = (
               Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAussie.Text)
               ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSAussie.Text) +
                Convert.ToDecimal(txtUSBrazil.Text) +
                Convert.ToDecimal(txtUSJapan.Text) +
                Convert.ToDecimal(txtUSKorea.Text)).ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAussie.Text = "0.712027";
            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.246250";
            txtAmountJapan.Text = "0.00";
            txtRateYen.Text = "0.00900080";
            txtAmountKorea.Text = "0.00";
            txtRateWon.Text = "0.000885723";
            txtUSDTotal.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
