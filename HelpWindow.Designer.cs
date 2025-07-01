namespace Downloader_Youtube
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 15);
            label1.TabIndex = 0;
            label1.Text = "*Vídeos só podem ser baixados com link e nome do vídeo preenchidos corretamente.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(479, 15);
            label2.TabIndex = 1;
            label2.Text = "*Áudios só podem ser baixados com link e nome do áudio preenchidos corretamente.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(475, 15);
            label3.TabIndex = 2;
            label3.Text = "*Quando um vídeo é baixado, apenas a imagem está no arquivo, ou seja, o vídeo não";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "possui som.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(481, 15);
            label5.TabIndex = 4;
            label5.Text = "*Caso a qualidade selecionada não existe no vídeo original o programa retornará erro.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(12, 124);
            label6.Name = "label6";
            label6.Size = new Size(351, 15);
            label6.TabIndex = 5;
            label6.Text = "*Inconveniências serão solucionadas em futuras atualizações.";
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 153);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(534, 192);
            MinimumSize = new Size(534, 192);
            Name = "HelpWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dúvidas recorrentes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}