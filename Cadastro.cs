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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (versenha.Checked == true)
            {
                txtsenha.UseSystemPasswordChar = false;
                txtconfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
                txtconfirm.UseSystemPasswordChar = true;
            }
        }

        private void btdcadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string senha = txtsenha.Text;
            string confirm = txtconfirm.Text;
            string telefone = txttelefone.Text;

            if (nome == " " || senha == " " || confirm == " " || telefone == " ")
            {
                MessageBox.Show("Falta preencher algum campo");
            }
            else if (senha != confirm)
            {
                MessageBox.Show("Confirmar senha está diferente de senha");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"..\\..\\..\\dados.txt"))
                {
                    writer.WriteLine($"{nome};{senha}");
                }
                Videos videos = new Videos();
                videos.Show();
                this.Hide();
            }
        }
    }
}
