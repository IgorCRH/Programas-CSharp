using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerdeMusica
{
    public partial class Player : Form
    {
        String[] caminhos, arquivos;
        public Player()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                arquivos = ofd.SafeFileNames;
                caminhos = ofd.FileNames;

                nomemusicalabel.Text = arquivos[0];

                axWindowsMediaPlayer1.URL = caminhos[0];
            }
        }
    }
}
