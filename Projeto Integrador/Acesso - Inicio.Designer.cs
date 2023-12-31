﻿namespace Projeto_Integrador
{
    partial class Acesso___Inicio
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
            menuStrip1 = new MenuStrip();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            confirmadosToolStripMenuItem = new ToolStripMenuItem();
            minhasFaturasToolStripMenuItem = new ToolStripMenuItem();
            emAbertoToolStripMenuItem = new ToolStripMenuItem();
            pagasToolStripMenuItem = new ToolStripMenuItem();
            emAbertoToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarDependenteToolStripMenuItem = new ToolStripMenuItem();
            novoCadastroToolStripMenuItem = new ToolStripMenuItem();
            verDependentesToolStripMenuItem = new ToolStripMenuItem();
            exameToolStripMenuItem = new ToolStripMenuItem();
            seusExamesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eventosToolStripMenuItem, minhasFaturasToolStripMenuItem, cadastrarDependenteToolStripMenuItem, exameToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(739, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, confirmadosToolStripMenuItem });
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(68, 21);
            eventosToolStripMenuItem.Text = "Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click;
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(153, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // confirmadosToolStripMenuItem
            // 
            confirmadosToolStripMenuItem.Name = "confirmadosToolStripMenuItem";
            confirmadosToolStripMenuItem.Size = new Size(153, 22);
            confirmadosToolStripMenuItem.Text = "Confirmados";
            confirmadosToolStripMenuItem.Click += confirmadosToolStripMenuItem_Click;
            // 
            // minhasFaturasToolStripMenuItem
            // 
            minhasFaturasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emAbertoToolStripMenuItem, pagasToolStripMenuItem, emAbertoToolStripMenuItem1 });
            minhasFaturasToolStripMenuItem.Name = "minhasFaturasToolStripMenuItem";
            minhasFaturasToolStripMenuItem.Size = new Size(117, 21);
            minhasFaturasToolStripMenuItem.Text = "Minhas Faturas ";
            minhasFaturasToolStripMenuItem.Click += minhasFaturasToolStripMenuItem_Click;
            // 
            // emAbertoToolStripMenuItem
            // 
            emAbertoToolStripMenuItem.Name = "emAbertoToolStripMenuItem";
            emAbertoToolStripMenuItem.Size = new Size(180, 22);
            emAbertoToolStripMenuItem.Text = "Ver todas ";
            emAbertoToolStripMenuItem.Click += emAbertoToolStripMenuItem_Click;
            // 
            // pagasToolStripMenuItem
            // 
            pagasToolStripMenuItem.Name = "pagasToolStripMenuItem";
            pagasToolStripMenuItem.Size = new Size(180, 22);
            pagasToolStripMenuItem.Text = "Pagas";
            pagasToolStripMenuItem.Click += pagasToolStripMenuItem_Click;
            // 
            // emAbertoToolStripMenuItem1
            // 
            emAbertoToolStripMenuItem1.Name = "emAbertoToolStripMenuItem1";
            emAbertoToolStripMenuItem1.Size = new Size(180, 22);
            emAbertoToolStripMenuItem1.Text = "Pendentes";
            emAbertoToolStripMenuItem1.Click += emAbertoToolStripMenuItem1_Click;
            // 
            // cadastrarDependenteToolStripMenuItem
            // 
            cadastrarDependenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoCadastroToolStripMenuItem, verDependentesToolStripMenuItem });
            cadastrarDependenteToolStripMenuItem.Name = "cadastrarDependenteToolStripMenuItem";
            cadastrarDependenteToolStripMenuItem.Size = new Size(156, 21);
            cadastrarDependenteToolStripMenuItem.Text = "Cadastrar Dependente";
            cadastrarDependenteToolStripMenuItem.Click += cadastrarDependenteToolStripMenuItem_Click;
            // 
            // novoCadastroToolStripMenuItem
            // 
            novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            novoCadastroToolStripMenuItem.Size = new Size(182, 22);
            novoCadastroToolStripMenuItem.Text = "Novo Cadastro ";
            novoCadastroToolStripMenuItem.Click += novoCadastroToolStripMenuItem_Click;
            // 
            // verDependentesToolStripMenuItem
            // 
            verDependentesToolStripMenuItem.Name = "verDependentesToolStripMenuItem";
            verDependentesToolStripMenuItem.Size = new Size(182, 22);
            verDependentesToolStripMenuItem.Text = "Ver dependentes ";
            verDependentesToolStripMenuItem.Click += verDependentesToolStripMenuItem_Click;
            // 
            // exameToolStripMenuItem
            // 
            exameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seusExamesToolStripMenuItem });
            exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            exameToolStripMenuItem.Size = new Size(60, 21);
            exameToolStripMenuItem.Text = "Exame";
            // 
            // seusExamesToolStripMenuItem
            // 
            seusExamesToolStripMenuItem.Name = "seusExamesToolStripMenuItem";
            seusExamesToolStripMenuItem.Size = new Size(154, 22);
            seusExamesToolStripMenuItem.Text = "Seus Exames";
            seusExamesToolStripMenuItem.Click += exameToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(42, 21);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // Acesso___Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(739, 566);
            Controls.Add(menuStrip1);
            Name = "Acesso___Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso___Inicio";
            Load += Acesso___Inicio_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfirmadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem confirmadosToolStripMenuItem;
        private ToolStripMenuItem minhasFaturasToolStripMenuItem;
        private ToolStripMenuItem emAbertoToolStripMenuItem;
        private ToolStripMenuItem pagasToolStripMenuItem;
        private ToolStripMenuItem emAbertoToolStripMenuItem1;
        private ToolStripMenuItem cadastrarDependenteToolStripMenuItem;
        private ToolStripMenuItem novoCadastroToolStripMenuItem;
        private ToolStripMenuItem verDependentesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem exameToolStripMenuItem;
        private ToolStripMenuItem seusExamesToolStripMenuItem;
    }
}