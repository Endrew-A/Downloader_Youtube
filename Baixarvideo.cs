using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using System.Diagnostics;

namespace Downloader_Youtube
{
    public partial class Baixarvideo : Form
    {
        private string caminho = "";
        public Baixarvideo()
        {
            InitializeComponent();
            cmboxQualidade.SelectedIndex = 0;
        }

        private async void Download()
        {
            var youtube = new YoutubeClient();

            string url = txtLink.Text;

            // Pega os streams (Chatgpt)
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            // seleciona o vídeo e a qualidade
            if (cmboxQualidade.SelectedIndex != 0)
            {
                var videoStreamInfo = streamManifest
                .GetVideoOnlyStreams()
                .Where(s => s.VideoQuality.Label == cmboxQualidade.Text)
                .FirstOrDefault();
                var audioStreamInfo = streamManifest
                .GetAudioOnlyStreams()
                .GetWithHighestBitrate();

                if (videoStreamInfo != null && audioStreamInfo != null)
                {
                    string videotemp = txtNomevideo.Text +"_temp" + ".mp4";
                    string audiotemp = txtNomevideo.Text + "_temp" + ".mp3";
                    string localvidtemp = Path.Combine(caminho, videotemp);
                    string localaudtemp = Path.Combine(caminho, audiotemp);

                    await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, localvidtemp);
                    await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, localaudtemp);

                    string videoFinal = Path.Combine(caminho, txtNomevideo.Text + ".mp4");

                    var ffmpeg = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "ffmpeg",
                            Arguments = $"-i \"{localvidtemp}\" -i \"{localaudtemp}\" -c:v copy -c:a aac -strict experimental \"{videoFinal}\" -y",
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };

                    ffmpeg.Start();
                    ffmpeg.WaitForExit();

                    File.Delete(localvidtemp);
                    File.Delete(localaudtemp);

                    MessageBox.Show("Download do vídeo concluído com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar o vídeo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var videoStreamInfo = streamManifest.GetVideoOnlyStreams().GetWithHighestVideoQuality();
                var audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                if (videoStreamInfo != null && audioStreamInfo!=null)
                {
                    string videotemp = txtNomevideo.Text + "_temp" + ".mp4";
                    string audiotemp = txtNomevideo.Text + "_temp" + ".mp3";
                    string localvidtemp = Path.Combine(caminho, videotemp);
                    string localaudtemp = Path.Combine(caminho, audiotemp);

                    await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, localvidtemp);
                    await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, localaudtemp);

                    string videoFinal = Path.Combine(caminho, txtNomevideo.Text + ".mp4");

                    var ffmpeg = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "ffmpeg",
                            Arguments = $"-i \"{localvidtemp}\" -i \"{localaudtemp}\" -c:v copy -c:a aac -strict experimental \"{videoFinal}\" -y",
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };
                    ffmpeg.Start();
                    ffmpeg.WaitForExit();

                    File.Delete(localvidtemp);
                    File.Delete(localaudtemp);

                    MessageBox.Show("Download do vídeo concluído com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Não foi possível baixar o vídeo, verifique se a qualidade selecionada existe no vídeo original.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Limpar()
        {
            txtLink.Text = "";
            cmboxQualidade.SelectedIndex = 0;
            txtCaminho.Text = ""; caminho = "";
            txtNomevideo.Text = "";
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bttBaixarvideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (caminho != "")
                {
                    Download();
                }
                else
                {
                    MessageBox.Show("Selecione um caminho válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (VideoUnavailableException ex)
            {
                Console.WriteLine("Erro: O vídeo está indisponível ou o link está errado.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: O link informado é inválido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
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
                MessageBox.Show("Seleção cancelada!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("O link digitado não é válido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("O link digitado não é válido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Digite apenas letras, números e '_'!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
