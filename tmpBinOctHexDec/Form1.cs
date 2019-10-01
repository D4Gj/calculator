using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmpBinOctHexDec
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string Conv(int From, int To, string Numbers)
        {
            Numbers = Numbers.Trim();
            if (Numbers == string.Empty) return string.Empty;
            string[] buf = Numbers.Split(' ');
            string Out = "";            

            foreach (string s in buf)
            {
                try
                {                    
                    Out = Out + Convert.ToString(Convert.ToInt64(s, From), To) + " ";
                }
                catch
                {
                    Out = Out + Convert.ToString(Int64.MaxValue, To) + " ";
                }
            }

            return Out.Trim();
        }


        private void txtBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '0') && (e.KeyChar != '1') &&
                (e.KeyChar != ' ') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtOct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                }
            }
            else
            {
                int digit = Convert.ToInt32(Convert.ToString(e.KeyChar));
                if (digit > 7)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                {
                    if ((e.KeyChar >= 'A') || (e.KeyChar <= 'F'))
                    {
                        e.KeyChar = e.KeyChar.ToString().ToLower()[0];
                    }

                    if ((e.KeyChar < 'a') || (e.KeyChar > 'f'))                        
                    {                        
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                }
            }
        }
                
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void All_TextChanged(object sender, EventArgs e)
        {
            TextBox tb_1 = (TextBox)sender;
            TextBox tb_2 = (TextBox)sender;
            bool changeBin = txtBin_1.Focused;
            bool changeOct = txtOct_1.Focused;
            bool changeHex = txtHex_1.Focused;
            bool changeDec = txtDec_1.Focused;

            bool changeBin_2 = txtBin_2.Focused;
            bool changeOct_2 = txtOct_2.Focused;
            bool changeHex_2 = txtHex_2.Focused;
            bool changeDec_2 = txtDec_2.Focused;

            switch (tb_1.Name)
            {
                case "txtBin_1":
                    {
                        
                        if (!changeOct) txtOct_1.Text = Conv(2, 8, tb_1.Text);
                        if (!changeHex) txtHex_1.Text = Conv(2, 16, tb_1.Text);
                        if (!changeDec) txtDec_1.Text = Conv(2, 10, tb_1.Text);

                    }; break;
                case "txtOct_1":
                    {
                        
                        if (!changeBin) txtBin_1.Text = Conv(8, 2, tb_1.Text);
                        if (!changeHex) txtHex_1.Text = Conv(8, 16, tb_1.Text);
                        if (!changeDec) txtDec_1.Text = Conv(8, 10, tb_1.Text);

                    }; break;
                case "txtHex_1":
                    {
                        
                        if (!changeBin) txtBin_1.Text = Conv(16, 2, tb_1.Text);
                        if (!changeOct) txtOct_1.Text = Conv(16, 8, tb_1.Text);
                        if (!changeDec) txtDec_1.Text = Conv(16, 10, tb_1.Text);

                    }; break;
                case "txtDec_1":
                    {
         
                        if (!changeBin) txtBin_1.Text = Conv(10, 2, tb_1.Text);
                        if (!changeHex) txtHex_1.Text = Conv(10, 16, tb_1.Text);
                        if (!changeOct) txtOct_1.Text = Conv(10, 8, tb_1.Text);

                    }; break;

            }
            switch (tb_2.Name)
            {
                case "txtBin_2":
                    {

                        if (!changeOct_2) txtOct_2.Text = Conv(2, 8, tb_2.Text);
                        if (!changeHex_2) txtHex_2.Text = Conv(2, 16, tb_2.Text);
                        if (!changeDec_2) txtDec_2.Text = Conv(2, 10, tb_2.Text);

                    }; break;
                case "txtOct_2":
                    {

                        if (!changeBin_2) txtBin_2.Text = Conv(8, 2, tb_2.Text);
                        if (!changeHex_2) txtHex_2.Text = Conv(8, 16, tb_2.Text);
                        if (!changeDec_2) txtDec_2.Text = Conv(8, 10, tb_2.Text);

                    }; break;
                case "txtHex_2":
                    {

                        if (!changeBin_2) txtBin_2.Text = Conv(16, 2, tb_2.Text);
                        if (!changeOct_2) txtOct_2.Text = Conv(16, 8, tb_2.Text);
                        if (!changeDec_2) txtDec_2.Text = Conv(16, 10, tb_2.Text);

                    }; break;
                case "txtDec_2":
                    {

                        if (!changeBin_2) txtBin_2.Text = Conv(10, 2, tb_2.Text);
                        if (!changeHex_2) txtHex_2.Text = Conv(10, 16, tb_2.Text);
                        if (!changeOct_2) txtOct_2.Text = Conv(10, 8, tb_2.Text);

                    }; break;
            }

        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtBin_1.Text, 2);
                n2 = Convert.ToInt32(txtBin_2.Text, 2);
                txtBinRes.Text = Convert.ToString(n1 + n2, 2);
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtBin_1.Text, 2);
                n2 = Convert.ToInt32(txtBin_2.Text, 2);
                txtBinRes.Text = Convert.ToString(n1 - n2, 2);
            }
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtBin_1.Text, 2);
                n2 = Convert.ToInt32(txtBin_2.Text, 2);
                txtBinRes.Text = Convert.ToString(n1 * n2, 2);
            }
        }

        private void BtnDelen_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                int n1, n2;
                n1 = Convert.ToInt32(txtBin_1.Text, 2);
                n2 = Convert.ToInt32(txtBin_2.Text, 2);
                txtBinRes.Text = Convert.ToString(n1 / n2, 2);
            }
        }
    }
}
