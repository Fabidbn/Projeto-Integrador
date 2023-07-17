namespace Projeto_Integrador
{
    partial class FormRedefinirSenha
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
<<<<<<< HEAD
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(328, 269);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "REDEFINIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 73);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "CPF";
=======
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 42);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Esqueceu sua senha ?";
>>>>>>> origin/fabi_nova
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(187, 138);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha antiga";
=======
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(99, 78);
            label2.Name = "label2";
            label2.Size = new Size(297, 20);
            label2.TabIndex = 1;
            label2.Text = "Não se preocupe, nós ajudamos a redefinir!";
>>>>>>> origin/fabi_nova
            // 
            // label3
            // 
            label3.AutoSize = true;
<<<<<<< HEAD
            label3.Location = new Point(193, 210);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Senha nova";
=======
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 152);
            label3.Name = "label3";
            label3.Size = new Size(243, 25);
            label3.TabIndex = 2;
            label3.Text = "Cadastre uma nova senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 300);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 353);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(388, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(307, 419);
            button1.Name = "button1";
            button1.Size = new Size(151, 34);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(194, 228);
            label4.Name = "label4";
            label4.Size = new Size(31, 17);
            label4.TabIndex = 6;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(194, 282);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 7;
            label5.Text = "E-mail";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(388, 23);
            textBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(194, 335);
            label6.Name = "label6";
            label6.Size = new Size(84, 17);
            label6.TabIndex = 9;
            label6.Text = "Nova Senha:";
>>>>>>> origin/fabi_nova
            // 
            // FormRedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
=======
            ClientSize = new Size(739, 566);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
>>>>>>> origin/fabi_nova
            Name = "FormRedefinirSenha";
            Text = "FormRedefinirSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< HEAD
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
=======
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
>>>>>>> origin/fabi_nova
    }
}