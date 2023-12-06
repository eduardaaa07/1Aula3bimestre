namespace _1Aula3bimestre
{
    partial class FormLivro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txblivro = new System.Windows.Forms.TextBox();
            this.txbautor = new System.Windows.Forms.TextBox();
            this.txbgenero = new System.Windows.Forms.TextBox();
            this.btncadrasto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexclu = new System.Windows.Forms.Button();
            this.btnedts = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_1Aula3bimestre.Properties.Resources.esboce_o_teste_padrao_ou_o_fundo_sem_emenda_dos_livros_do_vintage_esboco_livro_sem_emenda_de_educacao_para_escola_literatura_e_apple_ilustracao_700_149614705;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txblivro
            // 
            this.txblivro.Location = new System.Drawing.Point(48, 55);
            this.txblivro.Name = "txblivro";
            this.txblivro.Size = new System.Drawing.Size(335, 20);
            this.txblivro.TabIndex = 4;
            // 
            // txbautor
            // 
            this.txbautor.Location = new System.Drawing.Point(55, 161);
            this.txbautor.Name = "txbautor";
            this.txbautor.Size = new System.Drawing.Size(328, 20);
            this.txbautor.TabIndex = 5;
            // 
            // txbgenero
            // 
            this.txbgenero.Location = new System.Drawing.Point(55, 266);
            this.txbgenero.Name = "txbgenero";
            this.txbgenero.Size = new System.Drawing.Size(324, 20);
            this.txbgenero.TabIndex = 6;
            // 
            // btncadrasto
            // 
            this.btncadrasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncadrasto.Font = new System.Drawing.Font("Linux Libertine G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadrasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncadrasto.Location = new System.Drawing.Point(51, 352);
            this.btncadrasto.Name = "btncadrasto";
            this.btncadrasto.Size = new System.Drawing.Size(142, 40);
            this.btncadrasto.TabIndex = 7;
            this.btncadrasto.Text = "Cadastro";
            this.btncadrasto.UseVisualStyleBackColor = false;
            this.btncadrasto.Click += new System.EventHandler(this.btncadrasto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Linux Libertine G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Linux Libertine G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Linux Libertine G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(54, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Genero";
            // 
            // btnexclu
            // 
            this.btnexclu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexclu.Font = new System.Drawing.Font("Linux Libertine G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexclu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnexclu.Location = new System.Drawing.Point(256, 352);
            this.btnexclu.Name = "btnexclu";
            this.btnexclu.Size = new System.Drawing.Size(127, 40);
            this.btnexclu.TabIndex = 11;
            this.btnexclu.Text = "Excluir";
            this.btnexclu.UseVisualStyleBackColor = false;
            this.btnexclu.Click += new System.EventHandler(this.btnexclu_Click);
            // 
            // btnedts
            // 
            this.btnedts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnedts.Font = new System.Drawing.Font("Linux Libertine G", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnedts.Location = new System.Drawing.Point(473, 352);
            this.btnedts.Name = "btnedts";
            this.btnedts.Size = new System.Drawing.Size(121, 40);
            this.btnedts.TabIndex = 12;
            this.btnedts.Text = "Editar";
            this.btnedts.UseVisualStyleBackColor = false;
            this.btnedts.Click += new System.EventHandler(this.btnedts_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(436, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 117);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Livro";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Genero";
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnedts);
            this.Controls.Add(this.btnexclu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadrasto);
            this.Controls.Add(this.txbgenero);
            this.Controls.Add(this.txbautor);
            this.Controls.Add(this.txblivro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLivro";
            this.Text = "Livro";
            this.Load += new System.EventHandler(this.Livro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txblivro;
        private System.Windows.Forms.TextBox txbautor;
        private System.Windows.Forms.TextBox txbgenero;
        private System.Windows.Forms.Button btncadrasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexclu;
        private System.Windows.Forms.Button btnedts;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}