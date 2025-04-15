namespace PI
{
    partial class menuCADASTRO
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
            this.labelCOD = new System.Windows.Forms.Label();
            this.labelNOME = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelENDERECO = new System.Windows.Forms.Label();
            this.labelRUA = new System.Windows.Forms.Label();
            this.labelNUMERO = new System.Windows.Forms.Label();
            this.labelBAIRRO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCOD
            // 
            this.labelCOD.AutoSize = true;
            this.labelCOD.Location = new System.Drawing.Point(23, 35);
            this.labelCOD.Name = "labelCOD";
            this.labelCOD.Size = new System.Drawing.Size(36, 13);
            this.labelCOD.TabIndex = 0;
            this.labelCOD.Text = "CÓD.:";
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Location = new System.Drawing.Point(23, 71);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(42, 13);
            this.labelNOME.TabIndex = 1;
            this.labelNOME.Text = "NOME:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(23, 99);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF:";
            // 
            // labelENDERECO
            // 
            this.labelENDERECO.AutoSize = true;
            this.labelENDERECO.Location = new System.Drawing.Point(26, 132);
            this.labelENDERECO.Name = "labelENDERECO";
            this.labelENDERECO.Size = new System.Drawing.Size(70, 13);
            this.labelENDERECO.TabIndex = 3;
            this.labelENDERECO.Text = "ENDEREÇO:";
            // 
            // labelRUA
            // 
            this.labelRUA.AutoSize = true;
            this.labelRUA.Location = new System.Drawing.Point(26, 164);
            this.labelRUA.Name = "labelRUA";
            this.labelRUA.Size = new System.Drawing.Size(33, 13);
            this.labelRUA.TabIndex = 4;
            this.labelRUA.Text = "RUA:";
            // 
            // labelNUMERO
            // 
            this.labelNUMERO.AutoSize = true;
            this.labelNUMERO.Location = new System.Drawing.Point(263, 163);
            this.labelNUMERO.Name = "labelNUMERO";
            this.labelNUMERO.Size = new System.Drawing.Size(22, 13);
            this.labelNUMERO.TabIndex = 5;
            this.labelNUMERO.Text = "Nº:";
            // 
            // labelBAIRRO
            // 
            this.labelBAIRRO.AutoSize = true;
            this.labelBAIRRO.Location = new System.Drawing.Point(26, 197);
            this.labelBAIRRO.Name = "labelBAIRRO";
            this.labelBAIRRO.Size = new System.Drawing.Size(51, 13);
            this.labelBAIRRO.TabIndex = 6;
            this.labelBAIRRO.Text = "BAIRRO:";
            // 
            // menuCADASTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBAIRRO);
            this.Controls.Add(this.labelNUMERO);
            this.Controls.Add(this.labelRUA);
            this.Controls.Add(this.labelENDERECO);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.labelCOD);
            this.Name = "menuCADASTRO";
            this.Text = "menuCADASTRO";
            this.Load += new System.EventHandler(this.menuCADASTRO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCOD;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelENDERECO;
        private System.Windows.Forms.Label labelRUA;
        private System.Windows.Forms.Label labelNUMERO;
        private System.Windows.Forms.Label labelBAIRRO;
    }
}