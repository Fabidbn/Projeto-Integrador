namespace Projeto_Integrador
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
            sairToolStripMenuItem = new ToolStripMenuItem();
            exameToolStripMenuItem = new ToolStripMenuItem();
            seusExamesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eventosToolStripMenuItem, minhasFaturasToolStripMenuItem, cadastrarDependenteToolStripMenuItem, exameToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, confirmadosToolStripMenuItem });
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(60, 20);
            eventosToolStripMenuItem.Text = "Eventos";
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(180, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // confirmadosToolStripMenuItem
            // 
            confirmadosToolStripMenuItem.Name = "confirmadosToolStripMenuItem";
            confirmadosToolStripMenuItem.Size = new Size(180, 22);
            confirmadosToolStripMenuItem.Text = "Confirmados";
            // 
            // minhasFaturasToolStripMenuItem
            // 
            minhasFaturasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emAbertoToolStripMenuItem, pagasToolStripMenuItem, emAbertoToolStripMenuItem1 });
            minhasFaturasToolStripMenuItem.Name = "minhasFaturasToolStripMenuItem";
            minhasFaturasToolStripMenuItem.Size = new Size(102, 20);
            minhasFaturasToolStripMenuItem.Text = "Minhas Faturas ";
            // 
            // emAbertoToolStripMenuItem
            // 
            emAbertoToolStripMenuItem.Name = "emAbertoToolStripMenuItem";
            emAbertoToolStripMenuItem.Size = new Size(180, 22);
            emAbertoToolStripMenuItem.Text = "Ver todas ";
            // 
            // pagasToolStripMenuItem
            // 
            pagasToolStripMenuItem.Name = "pagasToolStripMenuItem";
            pagasToolStripMenuItem.Size = new Size(180, 22);
            pagasToolStripMenuItem.Text = "Pagas";
            // 
            // emAbertoToolStripMenuItem1
            // 
            emAbertoToolStripMenuItem1.Name = "emAbertoToolStripMenuItem1";
            emAbertoToolStripMenuItem1.Size = new Size(180, 22);
            emAbertoToolStripMenuItem1.Text = "Pendentes";
            // 
            // cadastrarDependenteToolStripMenuItem
            // 
            cadastrarDependenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoCadastroToolStripMenuItem, verDependentesToolStripMenuItem });
            cadastrarDependenteToolStripMenuItem.Name = "cadastrarDependenteToolStripMenuItem";
            cadastrarDependenteToolStripMenuItem.Size = new Size(136, 20);
            cadastrarDependenteToolStripMenuItem.Text = "Cadastrar Dependente";
            // 
            // novoCadastroToolStripMenuItem
            // 
            novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            novoCadastroToolStripMenuItem.Size = new Size(180, 22);
            novoCadastroToolStripMenuItem.Text = "Novo Cadastro ";
            // 
            // verDependentesToolStripMenuItem
            // 
            verDependentesToolStripMenuItem.Name = "verDependentesToolStripMenuItem";
            verDependentesToolStripMenuItem.Size = new Size(180, 22);
            verDependentesToolStripMenuItem.Text = "Ver dependentes ";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // exameToolStripMenuItem
            // 
            exameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seusExamesToolStripMenuItem });
            exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            exameToolStripMenuItem.Size = new Size(54, 20);
            exameToolStripMenuItem.Text = "Exame";
            // 
            // seusExamesToolStripMenuItem
            // 
            seusExamesToolStripMenuItem.Name = "seusExamesToolStripMenuItem";
            seusExamesToolStripMenuItem.Size = new Size(180, 22);
            seusExamesToolStripMenuItem.Text = "Seus Exames";
            // 
            // Acesso___Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Acesso___Inicio";
            Text = "Acesso___Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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