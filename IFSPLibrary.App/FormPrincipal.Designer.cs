namespace IFSPLibrary.App
{
    partial class FormPrincipal
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
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            cadstrosToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            editoraToolStripMenuItem = new ToolStripMenuItem();
            livroToolStripMenuItem = new ToolStripMenuItem();
            emprestimoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadstrosToolStripMenuItem, relatóriosToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            menuStrip1.Renderer = controlRenderer1;
            menuStrip1.Size = new Size(815, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadstrosToolStripMenuItem
            // 
            cadstrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autorToolStripMenuItem, clienteToolStripMenuItem, editoraToolStripMenuItem, livroToolStripMenuItem, emprestimoToolStripMenuItem });
            cadstrosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadstrosToolStripMenuItem.Name = "cadstrosToolStripMenuItem";
            cadstrosToolStripMenuItem.Size = new Size(71, 20);
            cadstrosToolStripMenuItem.Text = "&Cadastros";
            cadstrosToolStripMenuItem.Click += cadstrosToolStripMenuItem_Click;
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(138, 22);
            autorToolStripMenuItem.Text = "&Autor";
            autorToolStripMenuItem.Click += autorToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(138, 22);
            clienteToolStripMenuItem.Text = "&Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // editoraToolStripMenuItem
            // 
            editoraToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            editoraToolStripMenuItem.Name = "editoraToolStripMenuItem";
            editoraToolStripMenuItem.Size = new Size(138, 22);
            editoraToolStripMenuItem.Text = "&Editora";
            editoraToolStripMenuItem.Click += editoraToolStripMenuItem_Click;
            // 
            // livroToolStripMenuItem
            // 
            livroToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            livroToolStripMenuItem.Size = new Size(138, 22);
            livroToolStripMenuItem.Text = "&Livro";
            livroToolStripMenuItem.Click += livroToolStripMenuItem_Click;
            // 
            // emprestimoToolStripMenuItem
            // 
            emprestimoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            emprestimoToolStripMenuItem.Name = "emprestimoToolStripMenuItem";
            emprestimoToolStripMenuItem.Size = new Size(138, 22);
            emprestimoToolStripMenuItem.Text = "&Emprestimo";
            emprestimoToolStripMenuItem.Click += emprestimoToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(821, 492);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "IFSP Library";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip menuStrip1;
        private ToolStripMenuItem cadstrosToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem editoraToolStripMenuItem;
        private ToolStripMenuItem livroToolStripMenuItem;
        private ToolStripMenuItem emprestimoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}