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
    public partial class Videos : Form
    {
        public Videos()
        {
            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {

        }

        private void btn_vid1_Click(object sender, EventArgs e)
        {
            Form2 vid = new Form2();
            vid.Arquivo = @"";//colocar o video que quer aqui.
            vid.Show();
            this.Hide();
        }
    }
}
