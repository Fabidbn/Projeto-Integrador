namespace Projeto_Integrador
{
    partial class FormNossosPlanos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 50);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 0;
            label1.Text = "CONHEÇA NOSSOS PLANOS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(154, 140);
            label2.Name = "label2";
            label2.Size = new Size(159, 21);
            label2.TabIndex = 1;
            label2.Text = "PLANO INDIVIDUAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(154, 257);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 2;
            label3.Text = "PLANO FAMILIAR :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(154, 373);
            label4.Name = "label4";
            label4.Size = new Size(247, 21);
            label4.TabIndex = 3;
            label4.Text = "PLANO FAMÍLIA ENDORFINADA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 171);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "R$ 180,00 / Mês";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 283);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "R$320,00 / Mês";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 413);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "R$459,00 / Mês";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Direito ao uso de toda a estrutura do clube.", "Direito a cônjuje e filhos até 28 anos." });
            listBox1.Location = new Point(342, 283);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 49);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Direito ao uso de toda a estrutura do clube." });
            listBox2.Location = new Point(342, 171);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(259, 34);
            listBox2.TabIndex = 11;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "Direito ao uso de toda a estrutura do clube.", "Direito a cônjuje e filhos até 28 anos.", "Isento de taxas de inscrição em nossos eventos." });
            listBox3.Location = new Point(342, 413);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(259, 49);
            listBox3.TabIndex = 12;
            // 
            // FormNossosPlanos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 566);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNossosPlanos";
            Text = "Nossos Planos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}