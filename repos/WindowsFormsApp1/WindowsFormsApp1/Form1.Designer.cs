namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarComOBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarPróximaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.substituirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.novaJanelaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.configurarPáginaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar Página...";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editaToolStripMenuItem
            // 
            this.editaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.toolStripSeparator3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.toolStripSeparator4,
            this.buscarComOBingToolStripMenuItem,
            this.localizarToolStripMenuItem,
            this.localizarPróximaToolStripMenuItem,
            this.localizarToolStripMenuItem1,
            this.substituirToolStripMenuItem});
            this.editaToolStripMenuItem.Name = "editaToolStripMenuItem";
            this.editaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editaToolStripMenuItem.Text = "Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.recortarToolStripMenuItem.Text = "Recortar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // buscarComOBingToolStripMenuItem
            // 
            this.buscarComOBingToolStripMenuItem.Name = "buscarComOBingToolStripMenuItem";
            this.buscarComOBingToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.buscarComOBingToolStripMenuItem.Text = "Buscar com o Bing...";
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.localizarToolStripMenuItem.Text = "Localizar...";
            this.localizarToolStripMenuItem.Click += new System.EventHandler(this.localizarToolStripMenuItem_Click);
            // 
            // localizarPróximaToolStripMenuItem
            // 
            this.localizarPróximaToolStripMenuItem.Name = "localizarPróximaToolStripMenuItem";
            this.localizarPróximaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.localizarPróximaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.localizarPróximaToolStripMenuItem.Text = "Localizar próxima";
            this.localizarPróximaToolStripMenuItem.Click += new System.EventHandler(this.localizarPróximaToolStripMenuItem_Click);
            // 
            // localizarToolStripMenuItem1
            // 
            this.localizarToolStripMenuItem1.Name = "localizarToolStripMenuItem1";
            this.localizarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.localizarToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.localizarToolStripMenuItem1.Text = "Localizar Anterior";
            // 
            // substituirToolStripMenuItem
            // 
            this.substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            this.substituirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.substituirToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.substituirToolStripMenuItem.Text = "Substituir...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem buscarComOBingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarPróximaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem substituirToolStripMenuItem;
    }
}

