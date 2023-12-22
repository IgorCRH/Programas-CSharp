
namespace PlayerdeMusica
{
    partial class Player
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.selecionarmusicaButton = new System.Windows.Forms.Button();
            this.nomemusicaPanel = new System.Windows.Forms.Panel();
            this.nomemusicalabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.nomemusicaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 251);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja bem vindo ao Player de Música";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(269, 41);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(642, 354);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // selecionarmusicaButton
            // 
            this.selecionarmusicaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.selecionarmusicaButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionarmusicaButton.ForeColor = System.Drawing.Color.White;
            this.selecionarmusicaButton.Location = new System.Drawing.Point(12, 298);
            this.selecionarmusicaButton.Name = "selecionarmusicaButton";
            this.selecionarmusicaButton.Size = new System.Drawing.Size(226, 69);
            this.selecionarmusicaButton.TabIndex = 4;
            this.selecionarmusicaButton.Text = "Selecionar Música";
            this.selecionarmusicaButton.UseVisualStyleBackColor = false;
            this.selecionarmusicaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomemusicaPanel
            // 
            this.nomemusicaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.nomemusicaPanel.Controls.Add(this.label2);
            this.nomemusicaPanel.Controls.Add(this.nomemusicalabel);
            this.nomemusicaPanel.ForeColor = System.Drawing.Color.White;
            this.nomemusicaPanel.Location = new System.Drawing.Point(6, 412);
            this.nomemusicaPanel.Name = "nomemusicaPanel";
            this.nomemusicaPanel.Size = new System.Drawing.Size(890, 88);
            this.nomemusicaPanel.TabIndex = 5;
            // 
            // nomemusicalabel
            // 
            this.nomemusicalabel.AutoSize = true;
            this.nomemusicalabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomemusicalabel.Location = new System.Drawing.Point(156, 32);
            this.nomemusicalabel.Name = "nomemusicalabel";
            this.nomemusicalabel.Size = new System.Drawing.Size(168, 23);
            this.nomemusicalabel.TabIndex = 0;
            this.nomemusicalabel.Text = "Nome da Música";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo \r\nSelecionado";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 523);
            this.Controls.Add(this.nomemusicaPanel);
            this.Controls.Add(this.selecionarmusicaButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Name = "Player";
            this.Text = "PlayerdeMusica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.nomemusicaPanel.ResumeLayout(false);
            this.nomemusicaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button selecionarmusicaButton;
        private System.Windows.Forms.Panel nomemusicaPanel;
        private System.Windows.Forms.Label nomemusicalabel;
        private System.Windows.Forms.Label label2;
    }
}

