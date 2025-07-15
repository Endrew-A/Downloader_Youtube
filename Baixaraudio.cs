using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Exceptions;
using YoutubeExplode.Videos.Streams;

namespace Downloader_Youtube
{
    public partial class Baixaraudio : Form
    {
        private string caminho = "";

        public Baixaraudio()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtLink.Text = "";
            cmboxQualidade.SelectedIndex = 0;
            cmboxformato.SelectedIndex = 0;
            txtCaminho.Text = ""; caminho = "";
            txtNomeaudio.Text = "";
        }

        private async void Download()
        {
            var youtube = new YoutubeClient();

            string url = txtLink.Text;

            // Pega os streams (Chatgpt)
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            // seleciona o áudio na melhor qualidade possível
            var audioStreamInfo = streamManifest
            .GetAudioOnlyStreams()
            .GetWithHighestBitrate();

            if (audioStreamInfo != null)
            {
                string nometemp = txtNomeaudio.Text+"_temp" + cmboxformato.Text;
                string localtemp = Path.Combine(caminho, nometemp);

                string nome = txtNomeaudio.Text + cmboxformato.Text;
                string local = Path.Combine(caminho, nome);

                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, localtemp);

                if(cmboxformato.SelectedIndex == 0) //mp3
                {
                    var ffmpegAudio = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "ffmpeg",
                            Arguments = $"-i \"{localtemp}\" -c:a libmp3lame -b:a 128k \"{local}\" -y",
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };
                    ffmpegAudio.Start();
                    ffmpegAudio.WaitForExit();
                }
                else //ogg
                {
                    var ffmpegAudio = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "ffmpeg",
                            Arguments = $"-i \"{localtemp}\" -c:a libvorbis -q:a 5 \"{local}\" -y",
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };
                    ffmpegAudio.Start();
                    ffmpegAudio.WaitForExit();
                }

                File.Delete(localtemp); // Remove o arquivo temporario do audio
                MessageBox.Show("Download do áudio concluído com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar o vídeo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bttBaixaraudio_Click(object sender, EventArgs e)
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

        private void txtNomeaudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 && e.KeyChar != 08 && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_')
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras, números e '_'!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
