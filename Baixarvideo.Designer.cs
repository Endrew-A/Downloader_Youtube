namespace Downloader_Youtube
{
    partial class Baixarvideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baixarvideo));
            panelTxts = new Panel();
            bttLimpar = new Button();
            bttBaixarvideo = new Button();
            bttSelecionar = new Button();
            lblCaminho = new Label();
            txtCaminho = new TextBox();
            lblnomevideo = new Label();
            txtNomevideo = new TextBox();
            cmboxQualidade = new ComboBox();
            lblqualidade = new Label();
            lblLink = new Label();
            txtLink = new TextBox();
            panelDesc = new Panel();
            panelTxts.SuspendLayout();
            SuspendLayout();
            // 
            // panelTxts
            // 
            panelTxts.Controls.Add(bttLimpar);
            panelTxts.Controls.Add(bttBaixarvideo);
            panelTxts.Controls.Add(bttSelecionar);
            panelTxts.Controls.Add(lblCaminho);
            panelTxts.Controls.Add(txtCaminho);
            panelTxts.Controls.Add(lblnomevideo);
            panelTxts.Controls.Add(txtNomevideo);
            panelTxts.Controls.Add(cmboxQualidade);
            panelTxts.Controls.Add(lblqualidade);
            panelTxts.Controls.Add(lblLink);
            panelTxts.Controls.Add(txtLink);
            panelTxts.Dock = DockStyle.Left;
            panelTxts.Location = new Point(0, 0);
            panelTxts.Name = "panelTxts";
            panelTxts.Size = new Size(369, 287);
            panelTxts.TabIndex = 3;
            // 
            // bttLimpar
            // 
            bttLimpar.Font = new Font("Arial", 9F);
            bttLimpar.Location = new Point(100, 250);
            bttLimpar.Name = "bttLimpar";
            bttLimpar.Size = new Size(70, 25);
            bttLimpar.TabIndex = 13;
            bttLimpar.Text = "Limpar";
            bttLimpar.UseVisualStyleBackColor = true;
            bttLimpar.Click += bttLimpar_Click;
            // 
            // bttBaixarvideo
            // 
            bttBaixarvideo.Font = new Font("Arial", 9F);
            bttBaixarvideo.Location = new Point(12, 250);
            bttBaixarvideo.Name = "bttBaixarvideo";
            bttBaixarvideo.Size = new Size(82, 25);
            bttBaixarvideo.TabIndex = 12;
            bttBaixarvideo.Text = "Baixar vídeo";
            bttBaixarvideo.UseVisualStyleBackColor = true;
            bttBaixarvideo.Click += bttBaixarvideo_Click;
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
            cmboxQualidade.Items.AddRange(new object[] { "Melhor qualidade", "144p", "240p", "360p", "480p", "720p", "1080p", "1440p" });
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
            // panelDesc
            // 
            panelDesc.Dock = DockStyle.Right;
            panelDesc.Location = new Point(365, 0);
            panelDesc.Name = "panelDesc";
            panelDesc.Size = new Size(155, 287);
            panelDesc.TabIndex = 4;
            // 
            // Baixarvideo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 287);
            Controls.Add(panelDesc);
            Controls.Add(panelTxts);
            Font = new Font("Arial", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(536, 326);
            MinimumSize = new Size(536, 326);
            Name = "Baixarvideo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Janela para baixar vídeos";
            panelTxts.ResumeLayout(false);
            panelTxts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTxts;
        private Button bttSelecionar;
        private Label lblCaminho;
        private TextBox txtCaminho;
        private Label lblnomevideo;
        private TextBox txtNomevideo;
        private ComboBox cmboxQualidade;
        private Label lblqualidade;
        private Label lblLink;
        private TextBox txtLink;
        private Panel panelDesc;
        private Button bttBaixarvideo;
        private Button bttLimpar;
    }
}