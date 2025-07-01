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
            panelButtons = new Panel();
            bttLimpar = new Button();
            bttBaixaraudio = new Button();
            bttBaixarvideo = new Button();
            panelHelp = new Panel();
            bttHelp = new Button();
            panelTxts = new Panel();
            bttSelecionar = new Button();
            lblCaminho = new Label();
            txtCaminho = new TextBox();
            lblaudionome = new Label();
            txtNomeaudio = new TextBox();
            lblnomevideo = new Label();
            txtNomevideo = new TextBox();
            cmboxQualidade = new ComboBox();
            lblqualidade = new Label();
            lblLink = new Label();
            txtLink = new TextBox();
            panelButtons.SuspendLayout();
            panelHelp.SuspendLayout();
            panelTxts.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(bttLimpar);
            panelButtons.Controls.Add(bttBaixaraudio);
            panelButtons.Controls.Add(bttBaixarvideo);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 286);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(659, 74);
            panelButtons.TabIndex = 0;
            // 
            // bttLimpar
            // 
            bttLimpar.Font = new Font("Arial", 9F);
            bttLimpar.Location = new Point(164, 37);
            bttLimpar.Name = "bttLimpar";
            bttLimpar.Size = new Size(70, 25);
            bttLimpar.TabIndex = 2;
            bttLimpar.Text = "Limpar";
            bttLimpar.UseVisualStyleBackColor = true;
            bttLimpar.Click += bttLimpar_Click;
            // 
            // bttBaixaraudio
            // 
            bttBaixaraudio.Font = new Font("Arial", 9F);
            bttBaixaraudio.Location = new Point(88, 15);
            bttBaixaraudio.Name = "bttBaixaraudio";
            bttBaixaraudio.Size = new Size(70, 47);
            bttBaixaraudio.TabIndex = 1;
            bttBaixaraudio.Text = "Baixar áudio";
            bttBaixaraudio.UseVisualStyleBackColor = true;
            bttBaixaraudio.Click += bttBaixaraudio_Click;
            // 
            // bttBaixarvideo
            // 
            bttBaixarvideo.Font = new Font("Arial", 9F);
            bttBaixarvideo.Location = new Point(12, 15);
            bttBaixarvideo.Name = "bttBaixarvideo";
            bttBaixarvideo.Size = new Size(70, 47);
            bttBaixarvideo.TabIndex = 0;
            bttBaixarvideo.Text = "Baixar vídeo";
            bttBaixarvideo.UseVisualStyleBackColor = true;
            bttBaixarvideo.Click += bttBaixarvideo_Click;
            // 
            // panelHelp
            // 
            panelHelp.Controls.Add(bttHelp);
            panelHelp.Dock = DockStyle.Right;
            panelHelp.Location = new Point(503, 0);
            panelHelp.Name = "panelHelp";
            panelHelp.Size = new Size(156, 286);
            panelHelp.TabIndex = 1;
            // 
            // bttHelp
            // 
            bttHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bttHelp.BackgroundImage = (Image)resources.GetObject("bttHelp.BackgroundImage");
            bttHelp.BackgroundImageLayout = ImageLayout.Stretch;
            bttHelp.Location = new Point(104, 12);
            bttHelp.Name = "bttHelp";
            bttHelp.Size = new Size(40, 40);
            bttHelp.TabIndex = 0;
            bttHelp.UseVisualStyleBackColor = true;
            bttHelp.Click += bttHelp_Click;
            // 
            // panelTxts
            // 
            panelTxts.Controls.Add(bttSelecionar);
            panelTxts.Controls.Add(lblCaminho);
            panelTxts.Controls.Add(txtCaminho);
            panelTxts.Controls.Add(lblaudionome);
            panelTxts.Controls.Add(txtNomeaudio);
            panelTxts.Controls.Add(lblnomevideo);
            panelTxts.Controls.Add(txtNomevideo);
            panelTxts.Controls.Add(cmboxQualidade);
            panelTxts.Controls.Add(lblqualidade);
            panelTxts.Controls.Add(lblLink);
            panelTxts.Controls.Add(txtLink);
            panelTxts.Dock = DockStyle.Left;
            panelTxts.Location = new Point(0, 0);
            panelTxts.Name = "panelTxts";
            panelTxts.Size = new Size(497, 286);
            panelTxts.TabIndex = 2;
            panelTxts.Paint += panelTxts_Paint;
            // 
            // bttSelecionar
            // 
            bttSelecionar.Location = new Point(200, 130);
            bttSelecionar.Name = "bttSelecionar";
            bttSelecionar.Size = new Size(75, 32);
            bttSelecionar.TabIndex = 11;
            bttSelecionar.Text = "Selecionar";
            bttSelecionar.UseVisualStyleBackColor = true;
            bttSelecionar.Click += bttSelecionar_Click;
            // 
            // lblCaminho
            // 
            lblCaminho.AutoSize = true;
            lblCaminho.Location = new Point(12, 118);
            lblCaminho.Name = "lblCaminho";
            lblCaminho.Size = new Size(126, 15);
            lblCaminho.TabIndex = 10;
            lblCaminho.Text = "Selecione o caminho:";
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(12, 136);
            txtCaminho.MaxLength = 30;
            txtCaminho.Name = "txtCaminho";
            txtCaminho.ReadOnly = true;
            txtCaminho.Size = new Size(182, 21);
            txtCaminho.TabIndex = 9;
            // 
            // lblaudionome
            // 
            lblaudionome.AutoSize = true;
            lblaudionome.Location = new Point(12, 224);
            lblaudionome.Name = "lblaudionome";
            lblaudionome.Size = new Size(135, 15);
            lblaudionome.TabIndex = 8;
            lblaudionome.Text = "Nome do arquivo .mp3:";
            // 
            // txtNomeaudio
            // 
            txtNomeaudio.Location = new Point(12, 242);
            txtNomeaudio.MaxLength = 30;
            txtNomeaudio.Name = "txtNomeaudio";
            txtNomeaudio.Size = new Size(182, 21);
            txtNomeaudio.TabIndex = 7;
            txtNomeaudio.KeyPress += txtNomeaudio_KeyPress;
            // 
            // lblnomevideo
            // 
            lblnomevideo.AutoSize = true;
            lblnomevideo.Location = new Point(12, 170);
            lblnomevideo.Name = "lblnomevideo";
            lblnomevideo.Size = new Size(135, 15);
            lblnomevideo.TabIndex = 6;
            lblnomevideo.Text = "Nome do arquivo .mp4:";
            // 
            // txtNomevideo
            // 
            txtNomevideo.Location = new Point(12, 188);
            txtNomevideo.MaxLength = 30;
            txtNomevideo.Name = "txtNomevideo";
            txtNomevideo.Size = new Size(182, 21);
            txtNomevideo.TabIndex = 5;
            txtNomevideo.KeyPress += txtNomevideo_KeyPress;
            // 
            // cmboxQualidade
            // 
            cmboxQualidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxQualidade.FormattingEnabled = true;
            cmboxQualidade.Items.AddRange(new object[] { "Melhor qualidade", "720p", "1080p" });
            cmboxQualidade.Location = new Point(12, 82);
            cmboxQualidade.Name = "cmboxQualidade";
            cmboxQualidade.Size = new Size(121, 23);
            cmboxQualidade.TabIndex = 4;
            // 
            // lblqualidade
            // 
            lblqualidade.AutoSize = true;
            lblqualidade.Location = new Point(12, 64);
            lblqualidade.Name = "lblqualidade";
            lblqualidade.Size = new Size(182, 15);
            lblqualidade.TabIndex = 3;
            lblqualidade.Text = "Selecione a qualidade do vídeo:";
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(12, 13);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(82, 15);
            lblLink.TabIndex = 1;
            lblLink.Text = "Link do vídeo:";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(12, 31);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(345, 21);
            txtLink.TabIndex = 0;
            txtLink.KeyPress += txtLink_KeyPress;
            txtLink.Leave += txtLink_Leave;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 360);
            Controls.Add(panelTxts);
            Controls.Add(panelHelp);
            Controls.Add(panelButtons);
            Font = new Font("Arial", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Downloader de vídeos (sem áudio) e áudios do YouTube";
            panelButtons.ResumeLayout(false);
            panelHelp.ResumeLayout(false);
            panelTxts.ResumeLayout(false);
            panelTxts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Panel panelHelp;
        private Panel panelTxts;
        private Button bttHelp;
        private ComboBox cmboxQualidade;
        private Label lblqualidade;
        private Label lblLink;
        private TextBox txtLink;
        private Label lblnomevideo;
        private TextBox txtNomevideo;
        private Label lblaudionome;
        private TextBox txtNomeaudio;
        private Button bttBaixaraudio;
        private Button bttBaixarvideo;
        private Label lblCaminho;
        private TextBox txtCaminho;
        private Button bttSelecionar;
        private Button bttLimpar;
    }
}
