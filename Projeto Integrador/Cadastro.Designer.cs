namespace Projeto_Integrador
{
    partial class Cadastro
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(300, 441);
            button1.Name = "button1";
            button1.Size = new Size(135, 35);
            button1.TabIndex = 15;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(388, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 282);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(187, 161);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 9;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 111);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(187, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(387, 23);
            textBox4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 264);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 17;
            label3.Text = "Crie uma senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(186, 213);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 16;
            label4.Text = "E-mail";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(187, 345);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(387, 23);
            textBox5.TabIndex = 21;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(186, 327);
            label5.Name = "label5";
            label5.Size = new Size(108, 17);
            label5.TabIndex = 20;
            label5.Text = "Confirmar senha";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(165, 34);
            label6.Name = "label6";
            label6.Size = new Size(428, 25);
            label6.TabIndex = 22;
            label6.Text = "Preencha o formulário e torne-se um membro!";
            label6.Click += label6_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 566);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro Novo Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
    }
}