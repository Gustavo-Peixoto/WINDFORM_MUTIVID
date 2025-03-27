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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(542, 240);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Location = new Point(542, 290);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Location = new Point(542, 265);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.Location = new Point(542, 314);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 240);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 265);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 4;
            label2.Text = "Telefone";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(500, 290);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(469, 314);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 6;
            label4.Text = "Confirmação";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(531, 179);
            label5.Name = "label5";
            label5.Size = new Size(123, 29);
            label5.TabIndex = 7;
            label5.Text = "Cadastro";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(551, 352);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar ";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(656, 294);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Ver Senha";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(656, 319);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(86, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Ver Senha ";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 541);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}