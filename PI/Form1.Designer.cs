namespace PI
{
    partial class FormGERAL
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSENHA = new System.Windows.Forms.Label();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.labelEMPRESA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUSUARIO.Location = new System.Drawing.Point(128, 267);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(188, 26);
            this.textBoxUSUARIO.TabIndex = 2;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSENHA.Location = new System.Drawing.Point(128, 299);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(188, 26);
            this.textBoxSENHA.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI.Properties.Resources.icon_ESTACIONAMENTO;
            this.pictureBox1.Location = new System.Drawing.Point(128, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelSENHA
            // 
            this.labelSENHA.ForeColor = System.Drawing.Color.Maroon;
            this.labelSENHA.Image = global::PI.Properties.Resources.img_SENHA;
            this.labelSENHA.Location = new System.Drawing.Point(77, 299);
            this.labelSENHA.Name = "labelSENHA";
            this.labelSENHA.Size = new System.Drawing.Size(61, 26);
            this.labelSENHA.TabIndex = 1;
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.ForeColor = System.Drawing.Color.Maroon;
            this.labelUSUARIO.Image = global::PI.Properties.Resources.img_USUARIO;
            this.labelUSUARIO.Location = new System.Drawing.Point(49, 267);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(119, 26);
            this.labelUSUARIO.TabIndex = 0;
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.Location = new System.Drawing.Point(332, 267);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(64, 58);
            this.buttonLOGIN.TabIndex = 5;
            this.buttonLOGIN.Text = "LOGIN";
            this.buttonLOGIN.UseVisualStyleBackColor = true;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            // 
            // labelEMPRESA
            // 
            this.labelEMPRESA.AutoSize = true;
            this.labelEMPRESA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMPRESA.Location = new System.Drawing.Point(12, 352);
            this.labelEMPRESA.Name = "labelEMPRESA";
            this.labelEMPRESA.Size = new System.Drawing.Size(96, 23);
            this.labelEMPRESA.TabIndex = 6;
            this.labelEMPRESA.Text = "PI_CAMLAU";
            // 
            // FormGERAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(435, 386);
            this.Controls.Add(this.labelEMPRESA);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.labelSENHA);
            this.Controls.Add(this.labelUSUARIO);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGERAL";
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.Label labelSENHA;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.Label labelEMPRESA;
    }
}

