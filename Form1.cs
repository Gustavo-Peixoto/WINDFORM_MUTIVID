namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void versenha_CheckedChanged(object sender, EventArgs e)
        {
            if (versenha.Checked == true)
            {
                txtsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
            }

        }

        private void linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }
        private bool Login(string usuario, string senha, string arquivo)
        {

            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] partes = linha.Split(';');
                if (partes[0] == usuario && partes[1] == senha)
                {
                    return true; // Login correto
                }
            }
            return false; // Nenhuma correspond�ncia encontrada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string senha = txtsenha.Text;
            if (senha == " " || usuario == " ")
            {
                MessageBox.Show("Algum campo vazio");
            }
            else
            {
                string arquivo = @"..\\..\\..\\dados.txt";

                bool x = Login(txtuser.Text, txtsenha.Text, arquivo);
                if (x == true)
                {
                    Videos videos = new Videos();
                    videos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usu�rio ou senha errados");
                }



            }
        }
    }
}
