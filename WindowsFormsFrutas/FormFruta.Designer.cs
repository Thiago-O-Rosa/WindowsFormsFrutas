namespace WindowsFormsFrutas
{
    partial class FormFruta
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblNomeFruta = new System.Windows.Forms.Label();
            this.lbxListaFruta = new System.Windows.Forms.ListBox();
            this.tbxFruta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(215, 53);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 51);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(215, 151);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 51);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblNomeFruta
            // 
            this.lblNomeFruta.AutoSize = true;
            this.lblNomeFruta.Location = new System.Drawing.Point(62, 27);
            this.lblNomeFruta.Name = "lblNomeFruta";
            this.lblNomeFruta.Size = new System.Drawing.Size(140, 13);
            this.lblNomeFruta.TabIndex = 2;
            this.lblNomeFruta.Text = "Digite o nome de uma Fruta:";
            // 
            // lbxListaFruta
            // 
            this.lbxListaFruta.FormattingEnabled = true;
            this.lbxListaFruta.Location = new System.Drawing.Point(65, 151);
            this.lbxListaFruta.Name = "lbxListaFruta";
            this.lbxListaFruta.Size = new System.Drawing.Size(120, 95);
            this.lbxListaFruta.TabIndex = 3;
            // 
            // tbxFruta
            // 
            this.tbxFruta.Location = new System.Drawing.Point(65, 53);
            this.tbxFruta.Name = "tbxFruta";
            this.tbxFruta.Size = new System.Drawing.Size(120, 20);
            this.tbxFruta.TabIndex = 4;
            // 
            // FormFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 352);
            this.Controls.Add(this.tbxFruta);
            this.Controls.Add(this.lbxListaFruta);
            this.Controls.Add(this.lblNomeFruta);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FormFruta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFruta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblNomeFruta;
        private System.Windows.Forms.ListBox lbxListaFruta;
        private System.Windows.Forms.TextBox tbxFruta;
    }
}

