namespace Downloader_Youtube
{
    partial class Baixaraudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baixaraudio));
            panelTxts = new Panel();
            cmboxformato = new ComboBox();
            lblformatoaudio = new Label();
            bttLimpar = new Button();
            bttBaixaraudio = new Button();
            bttSelecionar = new Button();
            lblCaminho = new Label();
            txtCaminho = new TextBox();
            lblnomeaudio = new Label();
            txtNomeaudio = new TextBox();
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
            panelTxts.Controls.Add(cmboxformato);
            panelTxts.Controls.Add(lblformatoaudio);
            panelTxts.Controls.Add(bttLimpar);
            panelTxts.Controls.Add(bttBaixaraudio);
            panelTxts.Controls.Add(bttSelecionar);
            panelTxts.Controls.Add(lblCaminho);
            panelTxts.Controls.Add(txtCaminho);
            panelTxts.Controls.Add(lblnomeaudio);
            panelTxts.Controls.Add(txtNomeaudio);
            panelTxts.Controls.Add(cmboxQualidade);
            panelTxts.Controls.Add(lblqualidade);
            panelTxts.Controls.Add(lblLink);
            panelTxts.Controls.Add(txtLink);
            panelTxts.Dock = DockStyle.Left;
            panelTxts.Location = new Point(0, 0);
            panelTxts.Name = "panelTxts";
            panelTxts.Size = new Size(369, 313);
            panelTxts.TabIndex = 4;
            // 
            // cmboxformato
            // 
            cmboxformato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxformato.FormattingEnabled = true;
            cmboxformato.Items.AddRange(new object[] { ".mp3", ".ogg" });
            cmboxformato.Location = new Point(12, 82);
            cmboxformato.Name = "cmboxformato";
            cmboxformato.Size = new Size(121, 23);
            cmboxformato.TabIndex = 15;
            // 
            // lblformatoaudio
            // 
            lblformatoaudio.AutoSize = true;
            lblformatoaudio.Location = new Point(12, 64);
            lblformatoaudio.Name = "lblformatoaudio";
            lblformatoaudio.Size = new Size(171, 15);
            lblformatoaudio.TabIndex = 14;
            lblformatoaudio.Text = "Selecione o formato do áudio:";
            // 
            // bttLimpar
            // 
            bttLimpar.Font = new Font("Arial", 9F);
            bttLimpar.Location = new Point(107, 276);
            bttLimpar.Name = "bttLimpar";
            bttLimpar.Size = new Size(70, 25);
            bttLimpar.TabIndex = 13;
            bttLimpar.Text = "Limpar";
            bttLimpar.UseVisualStyleBackColor = true;
            bttLimpar.Click += bttLimpar_Click;
            // 
            // bttBaixaraudio
            // 
            bttBaixaraudio.Font = new Font("Arial", 9F);
            bttBaixaraudio.Location = new Point(12, 276);
            bttBaixaraudio.Name = "bttBaixaraudio";
            bttBaixaraudio.Size = new Size(89, 25);
            bttBaixaraudio.TabIndex = 12;
            bttBaixaraudio.Text = "Baixar áudio";
            bttBaixaraudio.UseVisualStyleBackColor = true;
            bttBaixaraudio.Click += bttBaixaraudio_Click;
            // 
            // bttSelecionar
            // 
            bttSelecionar.Location = new Point(202, 181);
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
            lblCaminho.Location = new Point(12, 169);
            lblCaminho.Name = "lblCaminho";
            lblCaminho.Size = new Size(126, 15);
            lblCaminho.TabIndex = 10;
            lblCaminho.Text = "Selecione o caminho:";
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(12, 187);
            txtCaminho.MaxLength = 30;
            txtCaminho.Name = "txtCaminho";
            txtCaminho.ReadOnly = true;
            txtCaminho.Size = new Size(182, 21);
            txtCaminho.TabIndex = 9;
            // 
            // lblnomeaudio
            // 
            lblnomeaudio.AutoSize = true;
            lblnomeaudio.Location = new Point(12, 220);
            lblnomeaudio.Name = "lblnomeaudio";
            lblnomeaudio.Size = new Size(104, 15);
            lblnomeaudio.TabIndex = 6;
            lblnomeaudio.Text = "Nome do arquivo:";
            // 
            // txtNomeaudio
            // 
            txtNomeaudio.Location = new Point(12, 238);
            txtNomeaudio.MaxLength = 30;
            txtNomeaudio.Name = "txtNomeaudio";
            txtNomeaudio.Size = new Size(182, 21);
            txtNomeaudio.TabIndex = 5;
            txtNomeaudio.KeyPress += txtNomeaudio_KeyPress;
            // 
            // cmboxQualidade
            // 
            cmboxQualidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboxQualidade.FormattingEnabled = true;
            cmboxQualidade.Items.AddRange(new object[] { "Melhor qualidade" });
            cmboxQualidade.Location = new Point(12, 135);
            cmboxQualidade.Name = "cmboxQualidade";
            cmboxQualidade.Size = new Size(121, 23);
            cmboxQualidade.TabIndex = 4;
            // 
            // lblqualidade
            // 
            lblqualidade.AutoSize = true;
            lblqualidade.Location = new Point(12, 117);
            lblqualidade.Name = "lblqualidade";
            lblqualidade.Size = new Size(184, 15);
            lblqualidade.TabIndex = 3;
            lblqualidade.Text = "Selecione a qualidade do áudio:";
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
            panelDesc.Size = new Size(155, 313);
            panelDesc.TabIndex = 5;
            // 
            // Baixaraudio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 313);
            Controls.Add(panelDesc);
            Controls.Add(panelTxts);
            Font = new Font("Arial", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(536, 326);
            Name = "Baixaraudio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Janela para baixar áudio";
            panelTxts.ResumeLayout(false);
            panelTxts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTxts;
        private Button bttLimpar;
        private Button bttBaixaraudio;
        private Button bttSelecionar;
        private Label lblCaminho;
        private TextBox txtCaminho;
        private Label lblnomeaudio;
        private TextBox txtNomeaudio;
        private ComboBox cmboxQualidade;
        private Label lblqualidade;
        private Label lblLink;
        private TextBox txtLink;
        private Panel panelDesc;
        private ComboBox cmboxformato;
        private Label lblformatoaudio;
    }
}