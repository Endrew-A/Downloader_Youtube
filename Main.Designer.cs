namespace Downloader_Youtube
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menu = new MenuStrip();
            baixarVídeoToolStripMenuItem = new ToolStripMenuItem();
            baixarÁudioToolStripMenuItem = new ToolStripMenuItem();
            dúvidasToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Arial", 9F);
            menu.Items.AddRange(new ToolStripItem[] { baixarVídeoToolStripMenuItem, baixarÁudioToolStripMenuItem, dúvidasToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(659, 24);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // baixarVídeoToolStripMenuItem
            // 
            baixarVídeoToolStripMenuItem.Name = "baixarVídeoToolStripMenuItem";
            baixarVídeoToolStripMenuItem.Size = new Size(85, 20);
            baixarVídeoToolStripMenuItem.Text = "Baixar vídeo";
            baixarVídeoToolStripMenuItem.Click += baixarVídeoToolStripMenuItem_Click;
            // 
            // baixarÁudioToolStripMenuItem
            // 
            baixarÁudioToolStripMenuItem.Name = "baixarÁudioToolStripMenuItem";
            baixarÁudioToolStripMenuItem.Size = new Size(87, 20);
            baixarÁudioToolStripMenuItem.Text = "Baixar áudio";
            baixarÁudioToolStripMenuItem.Click += baixarÁudioToolStripMenuItem_Click;
            // 
            // dúvidasToolStripMenuItem
            // 
            dúvidasToolStripMenuItem.Name = "dúvidasToolStripMenuItem";
            dúvidasToolStripMenuItem.Size = new Size(64, 20);
            dúvidasToolStripMenuItem.Text = "Dúvidas";
            dúvidasToolStripMenuItem.Click += dúvidasToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 360);
            Controls.Add(menu);
            Font = new Font("Arial", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Downloader de vídeos (sem áudio) e áudios do YouTube";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private ToolStripMenuItem baixarVídeoToolStripMenuItem;
        private ToolStripMenuItem baixarÁudioToolStripMenuItem;
        private ToolStripMenuItem dúvidasToolStripMenuItem;
    }
}
