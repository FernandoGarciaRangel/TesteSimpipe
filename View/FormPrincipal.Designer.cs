namespace TesteSimpipe
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NavBar = new System.Windows.Forms.MenuStrip();
            this.BtnBombaStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.válvulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.Ajuda = new System.Windows.Forms.ToolTip(this.components);
            this.panelForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ajudaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(65, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.AutoSize = false;
            this.sairToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.BackgroundImage")));
            this.sairToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sairToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(20, 20);
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.AutoSize = false;
            this.ajudaToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem1.BackgroundImage")));
            this.ajudaToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ajudaToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(20, 20);
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // NavBar
            // 
            this.NavBar.Dock = System.Windows.Forms.DockStyle.None;
            this.NavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBombaStripMenu,
            this.válvulaToolStripMenuItem});
            this.NavBar.Location = new System.Drawing.Point(9, 48);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(241, 24);
            this.NavBar.TabIndex = 2;
            this.NavBar.Text = "menuStrip3";
            this.NavBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip3_ItemClicked);
            // 
            // BtnBombaStripMenu
            // 
            this.BtnBombaStripMenu.Name = "BtnBombaStripMenu";
            this.BtnBombaStripMenu.Size = new System.Drawing.Size(57, 20);
            this.BtnBombaStripMenu.Text = "Bomba";
            this.BtnBombaStripMenu.Click += new System.EventHandler(this.bombaToolStripMenuItem_Click);
            // 
            // válvulaToolStripMenuItem
            // 
            this.válvulaToolStripMenuItem.Name = "válvulaToolStripMenuItem";
            this.válvulaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.válvulaToolStripMenuItem.Text = "Válvula";
            this.válvulaToolStripMenuItem.Click += new System.EventHandler(this.válvulaToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(730, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ocioso";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Ajuda
            // 
            this.Ajuda.OwnerDraw = true;
            this.Ajuda.StripAmpersands = true;
            this.Ajuda.Popup += new System.Windows.Forms.PopupEventHandler(this.Ajuda_Popup);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(0, 75);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(729, 542);
            this.panelForm.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 641);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.NavBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Calculadora de Equipamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip NavBar;
        private System.Windows.Forms.ToolStripMenuItem BtnBombaStripMenu;
        private System.Windows.Forms.ToolStripMenuItem válvulaToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip Ajuda;
        private System.Windows.Forms.Panel panelForm;
    }
}

