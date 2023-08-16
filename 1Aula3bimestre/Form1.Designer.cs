namespace _1Aula3bimestre
{
    partial class Form1
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
            this.btnmessage = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmessage
            // 
            this.btnmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnmessage.Location = new System.Drawing.Point(187, 278);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(159, 61);
            this.btnmessage.TabIndex = 0;
            this.btnmessage.Text = "Pronto!";
            this.btnmessage.UseVisualStyleBackColor = false;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(46, 92);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(432, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProntuario.Location = new System.Drawing.Point(43, 149);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(82, 16);
            this.lblProntuario.TabIndex = 3;
            this.lblProntuario.Text = "Prontuário:";
            // 
            // txbPront
            // 
            this.txbPront.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPront.Location = new System.Drawing.Point(46, 195);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(429, 20);
            this.txbPront.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 399);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnmessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.TextBox txbPront;
    }
}

