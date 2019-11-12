namespace tmpBinOctHexDec
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblDec = new System.Windows.Forms.Label();
            this.txtBin_1 = new System.Windows.Forms.TextBox();
            this.txtOct_1 = new System.Windows.Forms.TextBox();
            this.txtHex_1 = new System.Windows.Forms.TextBox();
            this.txtDec_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBin_2 = new System.Windows.Forms.TextBox();
            this.txtOct_2 = new System.Windows.Forms.TextBox();
            this.txtHex_2 = new System.Windows.Forms.TextBox();
            this.txtDec_2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtBinRes = new System.Windows.Forms.TextBox();
            this.txtOctRes = new System.Windows.Forms.TextBox();
            this.txtHexDec = new System.Windows.Forms.TextBox();
            this.txtDecRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnDelen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDec.Location = new System.Drawing.Point(226, 294);
            this.lblDec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(251, 29);
            this.lblDec.TabIndex = 3;
            this.lblDec.Text = "Decimal/Десятичное";
            // 
            // txtBin_1
            // 
            this.txtBin_1.Location = new System.Drawing.Point(50, 86);
            this.txtBin_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBin_1.Name = "txtBin_1";
            this.txtBin_1.Size = new System.Drawing.Size(249, 22);
            this.txtBin_1.TabIndex = 4;
            this.txtBin_1.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtBin_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin_KeyPress);
            // 
            // txtOct_1
            // 
            this.txtOct_1.Location = new System.Drawing.Point(50, 157);
            this.txtOct_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtOct_1.Name = "txtOct_1";
            this.txtOct_1.Size = new System.Drawing.Size(249, 22);
            this.txtOct_1.TabIndex = 5;
            this.txtOct_1.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtOct_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOct_KeyPress);
            // 
            // txtHex_1
            // 
            this.txtHex_1.Location = new System.Drawing.Point(50, 257);
            this.txtHex_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtHex_1.Name = "txtHex_1";
            this.txtHex_1.Size = new System.Drawing.Size(249, 22);
            this.txtHex_1.TabIndex = 6;
            this.txtHex_1.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtHex_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
            // 
            // txtDec_1
            // 
            this.txtDec_1.Location = new System.Drawing.Point(50, 339);
            this.txtDec_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDec_1.Name = "txtDec_1";
            this.txtDec_1.Size = new System.Drawing.Size(249, 22);
            this.txtDec_1.TabIndex = 7;
            this.txtDec_1.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtDec_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDec_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "HexaDecimal/Шестнадцатиричное";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(219, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Octal/Восьмеричное";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(226, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Binary/Двоичный";
            // 
            // txtBin_2
            // 
            this.txtBin_2.Location = new System.Drawing.Point(339, 86);
            this.txtBin_2.Name = "txtBin_2";
            this.txtBin_2.Size = new System.Drawing.Size(215, 22);
            this.txtBin_2.TabIndex = 11;
            this.txtBin_2.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtBin_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin_KeyPress);
            // 
            // txtOct_2
            // 
            this.txtOct_2.Location = new System.Drawing.Point(339, 157);
            this.txtOct_2.Name = "txtOct_2";
            this.txtOct_2.Size = new System.Drawing.Size(215, 22);
            this.txtOct_2.TabIndex = 12;
            this.txtOct_2.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtOct_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOct_KeyPress);
            // 
            // txtHex_2
            // 
            this.txtHex_2.Location = new System.Drawing.Point(339, 257);
            this.txtHex_2.Name = "txtHex_2";
            this.txtHex_2.Size = new System.Drawing.Size(215, 22);
            this.txtHex_2.TabIndex = 13;
            this.txtHex_2.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtHex_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
            // 
            // txtDec_2
            // 
            this.txtDec_2.Location = new System.Drawing.Point(339, 339);
            this.txtDec_2.Name = "txtDec_2";
            this.txtDec_2.Size = new System.Drawing.Size(215, 22);
            this.txtDec_2.TabIndex = 14;
            this.txtDec_2.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtDec_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDec_KeyPress);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(13, 13);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 27);
            this.btnSum.TabIndex = 15;
            this.btnSum.Text = "Сумма";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // txtBinRes
            // 
            this.txtBinRes.Location = new System.Drawing.Point(618, 86);
            this.txtBinRes.Name = "txtBinRes";
            this.txtBinRes.ReadOnly = true;
            this.txtBinRes.Size = new System.Drawing.Size(100, 22);
            this.txtBinRes.TabIndex = 16;
            // 
            // txtOctRes
            // 
            this.txtOctRes.Location = new System.Drawing.Point(618, 157);
            this.txtOctRes.Name = "txtOctRes";
            this.txtOctRes.ReadOnly = true;
            this.txtOctRes.Size = new System.Drawing.Size(100, 22);
            this.txtOctRes.TabIndex = 17;
            // 
            // txtHexDec
            // 
            this.txtHexDec.Location = new System.Drawing.Point(618, 257);
            this.txtHexDec.Name = "txtHexDec";
            this.txtHexDec.ReadOnly = true;
            this.txtHexDec.Size = new System.Drawing.Size(100, 22);
            this.txtHexDec.TabIndex = 18;
            // 
            // txtDecRes
            // 
            this.txtDecRes.Location = new System.Drawing.Point(618, 339);
            this.txtDecRes.Name = "txtDecRes";
            this.txtDecRes.ReadOnly = true;
            this.txtDecRes.Size = new System.Drawing.Size(100, 22);
            this.txtDecRes.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(607, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Результат";
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(94, 13);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(82, 27);
            this.btnDiv.TabIndex = 21;
            this.btnDiv.Text = "Разность";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(182, 12);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(92, 27);
            this.btnExp.TabIndex = 22;
            this.btnExp.Text = "Умножение";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.BtnExp_Click);
            // 
            // btnDelen
            // 
            this.btnDelen.Location = new System.Drawing.Point(284, 12);
            this.btnDelen.Name = "btnDelen";
            this.btnDelen.Size = new System.Drawing.Size(85, 26);
            this.btnDelen.TabIndex = 23;
            this.btnDelen.Text = "Деление";
            this.btnDelen.UseVisualStyleBackColor = true;
            this.btnDelen.Click += new System.EventHandler(this.BtnDelen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(748, 390);
            this.Controls.Add(this.btnDelen);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDecRes);
            this.Controls.Add(this.txtHexDec);
            this.Controls.Add(this.txtOctRes);
            this.Controls.Add(this.txtBinRes);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtDec_2);
            this.Controls.Add(this.txtHex_2);
            this.Controls.Add(this.txtOct_2);
            this.Controls.Add(this.txtBin_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDec_1);
            this.Controls.Add(this.txtHex_1);
            this.Controls.Add(this.txtOct_1);
            this.Controls.Add(this.txtBin_1);
            this.Controls.Add(this.lblDec);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.TextBox txtBin_1;
        private System.Windows.Forms.TextBox txtOct_1;
        private System.Windows.Forms.TextBox txtHex_1;
        private System.Windows.Forms.TextBox txtDec_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBin_2;
        private System.Windows.Forms.TextBox txtOct_2;
        private System.Windows.Forms.TextBox txtHex_2;
        private System.Windows.Forms.TextBox txtDec_2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtBinRes;
        private System.Windows.Forms.TextBox txtOctRes;
        private System.Windows.Forms.TextBox txtHexDec;
        private System.Windows.Forms.TextBox txtDecRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnDelen;
    }
}

