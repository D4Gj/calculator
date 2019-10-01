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
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtOct = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblDec.Click += new System.EventHandler(this.LblDec_Click);
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(50, 86);
            this.txtBin.Margin = new System.Windows.Forms.Padding(4);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(601, 22);
            this.txtBin.TabIndex = 4;
            this.txtBin.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin_KeyPress);
            // 
            // txtOct
            // 
            this.txtOct.Location = new System.Drawing.Point(50, 157);
            this.txtOct.Margin = new System.Windows.Forms.Padding(4);
            this.txtOct.Name = "txtOct";
            this.txtOct.Size = new System.Drawing.Size(601, 22);
            this.txtOct.TabIndex = 5;
            this.txtOct.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtOct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOct_KeyPress);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(50, 250);
            this.txtHex.Margin = new System.Windows.Forms.Padding(4);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(601, 22);
            this.txtHex.TabIndex = 6;
            this.txtHex.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(50, 340);
            this.txtDec.Margin = new System.Windows.Forms.Padding(4);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(601, 22);
            this.txtDec.TabIndex = 7;
            this.txtDec.TextChanged += new System.EventHandler(this.All_TextChanged);
            this.txtDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDec_KeyPress);
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
            this.label1.Click += new System.EventHandler(this.Label1_Click);
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
            this.label3.Location = new System.Drawing.Point(235, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Binary/Двоичный";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(677, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtOct);
            this.Controls.Add(this.txtBin);
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
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtOct;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

