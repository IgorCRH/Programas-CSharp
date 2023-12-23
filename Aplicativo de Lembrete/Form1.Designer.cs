
namespace AplicativodeNotasdeLembrete
{
    partial class formlembrete
    {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitulo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textoCorpoMensagem = new System.Windows.Forms.TextBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.lembreteButton = new System.Windows.Forms.Button();
            this.deletarButton = new System.Windows.Forms.Button();
            this.dgvlembretes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlembretes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja bem vindo ao Aplicativo de Lembretes e Notas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(63, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 29);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // textoTitulo
            // 
            this.textoTitulo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoTitulo.Location = new System.Drawing.Point(13, 104);
            this.textoTitulo.Multiline = true;
            this.textoTitulo.Name = "textoTitulo";
            this.textoTitulo.Size = new System.Drawing.Size(300, 41);
            this.textoTitulo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(63, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 28);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Corpo da Mensagem";
            // 
            // textoCorpoMensagem
            // 
            this.textoCorpoMensagem.Location = new System.Drawing.Point(13, 212);
            this.textoCorpoMensagem.Multiline = true;
            this.textoCorpoMensagem.Name = "textoCorpoMensagem";
            this.textoCorpoMensagem.Size = new System.Drawing.Size(300, 196);
            this.textoCorpoMensagem.TabIndex = 4;
            // 
            // adicionarButton
            // 
            this.adicionarButton.BackColor = System.Drawing.Color.Maroon;
            this.adicionarButton.Location = new System.Drawing.Point(26, 430);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(156, 41);
            this.adicionarButton.TabIndex = 5;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = false;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.BackColor = System.Drawing.Color.Maroon;
            this.salvarButton.Location = new System.Drawing.Point(237, 430);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(156, 41);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = false;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // lembreteButton
            // 
            this.lembreteButton.BackColor = System.Drawing.Color.Maroon;
            this.lembreteButton.Location = new System.Drawing.Point(446, 430);
            this.lembreteButton.Name = "lembreteButton";
            this.lembreteButton.Size = new System.Drawing.Size(156, 41);
            this.lembreteButton.TabIndex = 7;
            this.lembreteButton.Text = "Ler Lembrete";
            this.lembreteButton.UseVisualStyleBackColor = false;
            this.lembreteButton.Click += new System.EventHandler(this.lembreteButton_Click);
            // 
            // deletarButton
            // 
            this.deletarButton.BackColor = System.Drawing.Color.Maroon;
            this.deletarButton.Location = new System.Drawing.Point(655, 430);
            this.deletarButton.Name = "deletarButton";
            this.deletarButton.Size = new System.Drawing.Size(156, 41);
            this.deletarButton.TabIndex = 8;
            this.deletarButton.Text = "Deletar";
            this.deletarButton.UseVisualStyleBackColor = false;
            this.deletarButton.Click += new System.EventHandler(this.deletarButton_Click);
            // 
            // dgvlembretes
            // 
            this.dgvlembretes.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvlembretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlembretes.GridColor = System.Drawing.Color.DarkRed;
            this.dgvlembretes.Location = new System.Drawing.Point(412, 73);
            this.dgvlembretes.Name = "dgvlembretes";
            this.dgvlembretes.ReadOnly = true;
            this.dgvlembretes.RowHeadersWidth = 60;
            this.dgvlembretes.Size = new System.Drawing.Size(383, 319);
            this.dgvlembretes.TabIndex = 9;

            // 
            // formlembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(7)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(843, 497);
            this.Controls.Add(this.dgvlembretes);
            this.Controls.Add(this.deletarButton);
            this.Controls.Add(this.lembreteButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.textoCorpoMensagem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textoTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "formlembrete";
            this.Text = "Aplicativo de Lembretes";
            this.Load += new System.EventHandler(this.formlembrete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlembretes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textoTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoCorpoMensagem;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button lembreteButton;
        private System.Windows.Forms.Button deletarButton;
        private System.Windows.Forms.DataGridView dgvlembretes;
    }
}

