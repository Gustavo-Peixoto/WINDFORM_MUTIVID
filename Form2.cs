using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class Form2 : Form
    {
        public string Arquivo { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            mediaInicialize(Arquivo);
        }
        private void mediaInicialize(string Arquivo)
        {
            axWindowsMediaPlayer1.URL = Arquivo;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Videos vid = new Videos();
            vid.Show();
            this.Hide();
        }
    }
}
