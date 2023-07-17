namespace Projeto_Integrador
{
    partial class FormDepVerTodos
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
=======
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(172, 17);
            label1.TabIndex = 0;
            label1.Text = "Dependentes cadastrados :";
>>>>>>> origin/fabi_nova
            // 
            // FormDepVerTodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
<<<<<<< HEAD
            Controls.Add(dataGridView1);
            Name = "FormDepVerTodos";
            Text = "FormDepVerTodos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
=======
            Controls.Add(label1);
            Name = "FormDepVerTodos";
            Text = "FormDepVerTodos";
            ResumeLayout(false);
            PerformLayout();
>>>>>>> origin/fabi_nova
        }

        #endregion

<<<<<<< HEAD
        private DataGridView dataGridView1;
=======
        private Label label1;
>>>>>>> origin/fabi_nova
    }
}