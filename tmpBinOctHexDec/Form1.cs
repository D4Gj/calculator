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
                txtBinRes.Text = Sum(txtBin_1.Text, txtBin_2.Text);
                txtDecRes.Text = Conv(2, 10, txtBinRes.Text);
                txtHexDec.Text = Conv(2, 16, txtBinRes.Text);
                txtOctRes.Text = Conv(2, 8, txtBinRes.Text);

            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                txtBinRes.Text = Subtract(txtBin_1.Text,txtBin_2.Text);
                txtDecRes.Text = Conv(2, 10, txtBinRes.Text);
                txtHexDec.Text = Conv(2, 16, txtBinRes.Text);
                txtOctRes.Text = Conv(2, 8, txtBinRes.Text);

            }
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                txtBinRes.Text =  Exp(txtBin_1.Text,txtBin_2.Text);
                txtDecRes.Text = Conv(2, 10, txtBinRes.Text);
                txtHexDec.Text = Conv(2, 16, txtBinRes.Text);
                txtOctRes.Text = Conv(2, 8, txtBinRes.Text);
            }
        }

        private void BtnDelen_Click(object sender, EventArgs e)
        {
            if (txtBin_1.Text != string.Empty && txtBin_2.Text != string.Empty)
            {
                txtBinRes.Text = Division(txtBin_1.Text, txtBin_2.Text);
                txtDecRes.Text = Conv(2, 10, txtBinRes.Text);
                txtHexDec.Text = Conv(2, 16, txtBinRes.Text);
                txtOctRes.Text = Conv(2, 8, txtBinRes.Text);
            }
        }
        string[] Normalize(string val0, string val1)
        {
            while (val0.Length > val1.Length)
                val1 = "0" + val1;
            while (val1.Length > val0.Length)
                val0 = "0" + val0;
            return new string[] { val0, val1 };
        }


        string Sum(string val0, string val1)
        {
            val0 = Normalize(val0, val1)[0];
            val1 = Normalize(val0, val1)[1];

            string result = "";
            string next_bonus = "0";
            for (int i = val0.Length; i > 0; i--)
            {
                int n = i - 1;
                if (next_bonus == "1")
                {
                    if (val0[n] != val1[n])
                    {
                        result = "0" + result;
                        next_bonus = "1";
                    }
                    else
                    {
                        if (val0[n] == '0')
                            next_bonus = "0";
                        else
                            next_bonus = "1";
                        result = "1" + result;
                    }
                }
                else
                {
                    if (val0[n] != val1[n])
                    {
                        result = "1" + result;
                        next_bonus = "0";
                    }
                    else
                    {
                        result = "0" + result;
                        if (val0[n] == '0')
                            next_bonus = "0";
                        else
                            next_bonus = "1";
                    }
                }
            }
            if (next_bonus == "1")
                result = "1" + result;
            return result;
        }
        
        string Exp(string val, string total)
        {
            string result = "0";
            for (string i = "0"; i != total; i = Sum(i, "1"))
                result = Sum(result, val);
            return result;
        }
        

        string Subtract(string val0, string val1)
        {
            val0 = Normalize(val0, val1)[0];
            val1 = Normalize(val0, val1)[1];

            string result = "";
            val1 = val1.Replace('0', 'z');
            val1 = val1.Replace('1', '0');
            val1 = val1.Replace('z', '1');
            val1 = Sum(val1, "1");
            result = Sum(val0, val1);
            result = result.Substring(1, result.Length - 1);
            return TrimZeros(result);
        }

        string TrimZeros(string val)
        {
            if (val.Length > 1)
            {
                bool found = false;
                for (int i = 0; i < val.Length; i++)
                {
                    if (!found)
                    {
                        if (val[i] != '0')
                            found = true;
                    }
                    if (found)
                        return val.Substring(i, val.Length - i);
                }
                if (Normalize(val, "0")[0] == Normalize(val, "0")[1])
                    return "0";
                return val;
            }
            else
                return val;
        }

        
        string Division(string val0, string val1)
        {
            val0 = Normalize(val0, val1)[0];
            val1 = Normalize(val0, val1)[1];
            string result = "0";
            while (true)
            {
                if (IsGreater(val0, "0"))
                {
                    val0 = Subtract(val0, val1);
                    result = Sum(result, "1");
                }
                else
                    break;
                if (IsGreater(val1, val0))
                    break;
            }
            return result;
        }
        
        bool IsGreater(string val0, string val1)
        {
            val0 = Normalize(val0, val1)[0];
            val1 = Normalize(val0, val1)[1];

            for (int i = 0; i < val0.Length; i++)
            {
                if (val1[i] == '1' && val0[i] == '0')
                    break;
                if (val0[i] == '1' && val1[i] == '0')
                    return true;
            }
            return false;
        }
    }

}