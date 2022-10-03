namespace ReadeLanguages.Palavras
{
    partial class FormPalavra
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
            this.lblPalavraTrad = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTraducao = new System.Windows.Forms.TextBox();
            this.lblPalavraTraduzir = new System.Windows.Forms.Label();
            this.lblPalavraTraducao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPalavraTrad
            // 
            this.lblPalavraTrad.AutoSize = true;
            this.lblPalavraTrad.Location = new System.Drawing.Point(131, 22);
            this.lblPalavraTrad.Name = "lblPalavraTrad";
            this.lblPalavraTrad.Size = new System.Drawing.Size(0, 15);
            this.lblPalavraTrad.TabIndex = 0;
            this.lblPalavraTrad.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(89, 136);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTraducao
            // 
            this.txtTraducao.Location = new System.Drawing.Point(131, 72);
            this.txtTraducao.Name = "txtTraducao";
            this.txtTraducao.Size = new System.Drawing.Size(162, 23);
            this.txtTraducao.TabIndex = 2;
            // 
            // lblPalavraTraduzir
            // 
            this.lblPalavraTraduzir.AutoSize = true;
            this.lblPalavraTraduzir.Location = new System.Drawing.Point(20, 22);
            this.lblPalavraTraduzir.Name = "lblPalavraTraduzir";
            this.lblPalavraTraduzir.Size = new System.Drawing.Size(89, 15);
            this.lblPalavraTraduzir.TabIndex = 3;
            this.lblPalavraTraduzir.Text = "Palavra Traduzir";
            // 
            // lblPalavraTraducao
            // 
            this.lblPalavraTraducao.AutoSize = true;
            this.lblPalavraTraducao.Location = new System.Drawing.Point(20, 75);
            this.lblPalavraTraducao.Name = "lblPalavraTraducao";
            this.lblPalavraTraducao.Size = new System.Drawing.Size(96, 15);
            this.lblPalavraTraducao.TabIndex = 4;
            this.lblPalavraTraducao.Text = "Palavra Tradução";
            // 
            // FormPalavra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 199);
            this.Controls.Add(this.lblPalavraTraducao);
            this.Controls.Add(this.lblPalavraTraduzir);
            this.Controls.Add(this.txtTraducao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPalavraTrad);
            this.Name = "FormPalavra";
            this.Text = "FormPalavra";
            this.Load += new System.EventHandler(this.FormPalavra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPalavraTrad;
        private Button btnSalvar;
        private TextBox txtTraducao;
        private Label lblPalavraTraduzir;
        private Label lblPalavraTraducao;
    }
}