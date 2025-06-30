using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using YoutubeExplode.Exceptions;
namespace Downloader_Youtube
{
    public partial class Main : Form
    {
        string caminho = "";

        public Main()
        {
            InitializeComponent();
            cmboxQualidade.SelectedIndex = 0;
        }

        private void bttHelp_Click(object sender, EventArgs e)
        {
            HelpWindow nova_janela = Application.OpenForms["HelpWindow"] as HelpWindow;
            if (nova_janela != null)
            {
                if (nova_janela.WindowState == FormWindowState.Minimized)
                {
                    nova_janela.WindowState = FormWindowState.Normal;
                }
                nova_janela.BringToFront();
            }
            else
            {
                nova_janela = new HelpWindow();
                nova_janela.Show();
            }
        }

        private void txtLink_Leave(object sender, EventArgs e)
        {
            //verifica o link
            if (txtLink.Text != "")
            {
                bool valido = Uri.TryCreate(txtLink.Text, UriKind.Absolute, out var result) && result.Host.Contains("youtube.com");
                if (!valido)
                {
                    MessageBox.Show("O link digitado n�o � v�lido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLink.Text = "";
                }
            }
        }

        private void txtLink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtLink.Text != "")
            {
                e.Handled = true;
                //verifica o link
                bool valido = Uri.TryCreate(txtLink.Text, UriKind.Absolute, out var result) && result.Host.Contains("youtube.com");
                if (!valido)
                {
                    MessageBox.Show("O link digitado n�o � v�lido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLink.Text = "";
                }
                else
                {
                    cmboxQualidade.Focus();
                }
            }
        }

        private void txtNomevideo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 && e.KeyChar != 08 && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_')
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras, n�meros e '_'!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomeaudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 && e.KeyChar != 08 && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_')
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras, n�meros e '_'!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttBaixarvideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (caminho != "")
                {
                    Baixarvideo();
                }
                else
                {
                    MessageBox.Show("Selecione um caminho v�lido.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (VideoUnavailableException ex)
            {
                Console.WriteLine("Erro: O v�deo est� indispon�vel ou o link est� errado.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: O link informado � inv�lido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        private async void Baixarvideo()
        {
            var youtube = new YoutubeClient();

            string url = txtLink.Text;

            // Pega os streams (Chatgpt)
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            // seleciona o v�deo e a qualidade
            var videoStreamInfo = streamManifest
            .GetVideoOnlyStreams()
            .Where(s => s.VideoQuality.Label == cmboxQualidade.Text)
            .FirstOrDefault();

            if (videoStreamInfo != null)
            {
                string nome = txtNomevideo.Text + ".mp4";
                string local = Path.Combine(caminho, nome);

                await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, local);
                MessageBox.Show("Download do v�deo conclu�do com sucesso!", "Conclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("N�o foi poss�vel encontrar o v�deo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttSelecionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar_caminho = new FolderBrowserDialog();
            if (buscar_caminho.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = buscar_caminho.SelectedPath;
                caminho = buscar_caminho.SelectedPath + "\\";
            }
            else
            {
                MessageBox.Show("Sele��o cancelada!", "Aten��o!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtLink.Text = "";
            cmboxQualidade.SelectedIndex = 0;
            txtCaminho.Text = ""; caminho = "";
            txtNomevideo.Text = "";
            txtNomeaudio.Text = "";
        }

        private async void bttBaixaraudio_Click(object sender, EventArgs e)
        {
            var youtube = new YoutubeClient();

            string url = txtLink.Text;

            // Pega os streams (Chatgpt)
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            // seleciona o �udio na melhor qualidade poss�vel
            var audioStreamInfo = streamManifest
            .GetAudioOnlyStreams()
            .GetWithHighestBitrate();

            if (audioStreamInfo != null)
            {
                string nome = txtNomeaudio.Text + ".mp3";
                string local = Path.Combine(caminho, nome);

                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, local);
                MessageBox.Show("Download do �udio conclu�do com sucesso!", "Conclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("N�o foi poss�vel encontrar o v�deo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelTxts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
