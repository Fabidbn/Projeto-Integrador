namespace Projeto_Integrador
{
    partial class FormFaturasTodas
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
            dataGridViewFatura = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFatura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 52);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 1;
            label1.Text = "Verifique aqui suas faturas :";
            // 
            // dataGridViewFatura
            // 
            dataGridViewFatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFatura.Location = new Point(46, 101);
            dataGridViewFatura.Name = "dataGridViewFatura";
            dataGridViewFatura.RowTemplate.Height = 25;
            dataGridViewFatura.Size = new Size(643, 237);
            dataGridViewFatura.TabIndex = 2;
            dataGridViewFatura.CellBeginEdit += dataGridViewFatura_CellBeginEdit;
            dataGridViewFatura.CellContentClick += dataGridView1_CellContentClick_2;
            dataGridViewFatura.CellFormatting += dataGridViewFatura_CellFormatting;
            // 
            // FormFaturasTodas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFatura);
            Controls.Add(label1);
            Name = "FormFaturasTodas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFaturasTodas";
            Load += FormFaturasTodas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewFatura;
    }
}