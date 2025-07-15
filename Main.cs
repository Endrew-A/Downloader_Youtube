using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;
using YoutubeExplode.Exceptions;
namespace Downloader_Youtube
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void dúvidasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void baixarVídeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baixarvideo nova_janela = Application.OpenForms["Baixarvideo"] as Baixarvideo;
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
                nova_janela = new Baixarvideo();
                nova_janela.Show();
            }
        }

        private void baixarÁudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baixaraudio nova_janela = Application.OpenForms["Baixaraudio"] as Baixaraudio;
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
                nova_janela = new Baixaraudio();
                nova_janela.Show();
            }
        }
    }
}
