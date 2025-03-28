namespace projeto
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            txtnome = new TextBox();
            txtsenha = new TextBox();
            txttelefone = new TextBox();
            txtconfirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btdcadastrar = new Button();
            versenha = new CheckBox();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.BackColor = Color.WhiteSmoke;
            txtnome.Location = new Point(619, 320);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(125, 27);
            txtnome.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.BackColor = Color.WhiteSmoke;
            txtsenha.Location = new Point(619, 387);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(125, 27);
            txtsenha.TabIndex = 1;
            txtsenha.UseSystemPasswordChar = true;
            // 
            // txttelefone
            // 
            txttelefone.BackColor = Color.WhiteSmoke;
            txttelefone.Location = new Point(619, 353);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(125, 27);
            txttelefone.TabIndex = 1;
            // 
            // txtconfirm
            // 
            txtconfirm.BackColor = Color.WhiteSmoke;
            txtconfirm.Location = new Point(619, 419);
            txtconfirm.Name = "txtconfirm";
            txtconfirm.Size = new Size(125, 27);
            txtconfirm.TabIndex = 2;
            txtconfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(561, 320);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(561, 353);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Telefone";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(571, 387);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(536, 419);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Confirmação";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(607, 239);
            label5.Name = "label5";
            label5.Size = new Size(154, 35);
            label5.TabIndex = 7;
            label5.Text = "Cadastro";
            label5.Click += label5_Click;
            // 
            // btdcadastrar
            // 
            btdcadastrar.BackColor = Color.WhiteSmoke;
            btdcadastrar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdcadastrar.Location = new Point(630, 469);
            btdcadastrar.Name = "btdcadastrar";
            btdcadastrar.Size = new Size(97, 31);
            btdcadastrar.TabIndex = 8;
            btdcadastrar.Text = "Cadastrar ";
            btdcadastrar.UseVisualStyleBackColor = false;
            btdcadastrar.Click += btdcadastrar_Click;
            // 
            // versenha
            // 
            versenha.AutoSize = true;
            versenha.BackColor = Color.Transparent;
            versenha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            versenha.Location = new Point(750, 404);
            versenha.Name = "versenha";
            versenha.Size = new Size(98, 22);
            versenha.TabIndex = 9;
            versenha.Text = "Ver Senha";
            versenha.UseVisualStyleBackColor = false;
            versenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1349, 721);
            Controls.Add(versenha);
            Controls.Add(btdcadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtconfirm);
            Controls.Add(txttelefone);
            Controls.Add(txtsenha);
            Controls.Add(txtnome);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtsenha;
        private TextBox txttelefone;
        private TextBox txtconfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btdcadastrar;
        private CheckBox versenha;
    }
}