namespace projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            versenha = new CheckBox();
            txtuser = new TextBox();
            txtsenha = new TextBox();
            linkcadastro = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // versenha
            // 
            versenha.AutoSize = true;
            versenha.BackColor = Color.Transparent;
            versenha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            versenha.Location = new Point(744, 390);
            versenha.Margin = new Padding(3, 2, 3, 2);
            versenha.Name = "versenha";
            versenha.Size = new Size(98, 22);
            versenha.TabIndex = 0;
            versenha.Text = "Ver Senha";
            versenha.UseVisualStyleBackColor = false;
            versenha.CheckedChanged += versenha_CheckedChanged;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.WhiteSmoke;
            txtuser.Location = new Point(613, 332);
            txtuser.Margin = new Padding(3, 2, 3, 2);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(125, 23);
            txtuser.TabIndex = 2;
            // 
            // txtsenha
            // 
            txtsenha.BackColor = Color.White;
            txtsenha.Location = new Point(613, 387);
            txtsenha.Margin = new Padding(3, 2, 3, 2);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(125, 23);
            txtsenha.TabIndex = 3;
            txtsenha.UseSystemPasswordChar = true;
            // 
            // linkcadastro
            // 
            linkcadastro.ActiveLinkColor = Color.White;
            linkcadastro.AutoSize = true;
            linkcadastro.BackColor = Color.Transparent;
            linkcadastro.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkcadastro.ForeColor = Color.Black;
            linkcadastro.LinkBehavior = LinkBehavior.NeverUnderline;
            linkcadastro.LinkColor = SystemColors.Highlight;
            linkcadastro.Location = new Point(623, 475);
            linkcadastro.Name = "linkcadastro";
            linkcadastro.Size = new Size(108, 18);
            linkcadastro.TabIndex = 4;
            linkcadastro.TabStop = true;
            linkcadastro.Text = "Cadastra-se";
            linkcadastro.LinkClicked += linkcadastro_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(553, 332);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(553, 387);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 6;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(629, 427);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 242);
            label3.Name = "label3";
            label3.Size = new Size(104, 35);
            label3.TabIndex = 7;
            label3.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 719);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkcadastro);
            Controls.Add(txtsenha);
            Controls.Add(txtuser);
            Controls.Add(button1);
            Controls.Add(versenha);
            Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "ca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox versenha;
        private TextBox txtuser;
        private TextBox txtsenha;
        private LinkLabel linkcadastro;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}
