//For this program, I decided to use the currency symbols instead of the dollar symbol.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPound_Click(object sender, EventArgs e)
        {
            picCurrency.Image = Properties.Resources.uk;
            double currency;
            CultureInfo cul = new CultureInfo("en_GB");
            currency = Convert.ToDouble(txtDollars.Text) * .63;
            txtBoxCurrency.Text = currency.ToString("c", cul);
            lblTextCurrency.Text = "Pounds";
        }

        private void btnYen_Click(object sender, EventArgs e)
        {
            picCurrency.Image = Properties.Resources.japan;
            double currency;
            CultureInfo cul = new CultureInfo("ja_JP");
            currency = Convert.ToDouble(txtDollars.Text) * 120.85;
            txtBoxCurrency.Text = currency.ToString("c", cul);
            lblTextCurrency.Text = "Yen";
        }

        private void btnFranc_Click(object sender, EventArgs e)
        {
            picCurrency.Image = Properties.Resources.france;
            double currency;
            CultureInfo cul = new CultureInfo("fr_FR");
            currency = Convert.ToDouble(txtDollars.Text) * 6.12;
            txtBoxCurrency.Text = currency.ToString("c", cul);
            lblTextCurrency.Text = "Francs";
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            picCurrency.Image = Properties.Resources.germany;
            double currency;
            CultureInfo cul = new CultureInfo("de_DE");
            currency = Convert.ToDouble(txtDollars.Text) * 1.82;
            txtBoxCurrency.Text = currency.ToString("c", cul);
            lblTextCurrency.Text = "Marks";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /* I started the program with the second label stating to select currency
             * So it makes sense to revert it back to "Select Currency" when the user
             * selects Clear.
             */

            lblTextCurrency.Text = "Select Currency";
            txtBoxCurrency.Clear();
            txtDollars.Clear();
            picCurrency.Image = null;
        }
    }
}
