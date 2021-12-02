namespace AkademikApp
{
    partial class FrmKalkulator
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
            this.lvwKalkulator = new System.Windows.Forms.ListView();
            this.btnHitung = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwKalkulator
            // 
            this.lvwKalkulator.HideSelection = false;
            this.lvwKalkulator.Location = new System.Drawing.Point(6, 19);
            this.lvwKalkulator.Name = "lvwKalkulator";
            this.lvwKalkulator.Size = new System.Drawing.Size(514, 261);
            this.lvwKalkulator.TabIndex = 0;
            this.lvwKalkulator.UseCompatibleStateImageBehavior = false;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 313);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(526, 23);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwKalkulator);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Hasil ]";
            // 
            // FrmKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHitung);
            this.MaximizeBox = false;
            this.Name = "FrmKalkulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwKalkulator;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

