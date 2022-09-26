using System.IO;

namespace ColombiFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void controlloLunghezza_Click(object sender, EventArgs e)
        {
            ControlloLunghezza ctrl = new ControlloLunghezza();
            this.Hide();
            ctrl.ShowDialog();
            this.Close();
        }

        private void impostaLunghezza_Click(object sender, EventArgs e)
        {
            ImpostaLunghezza imp = new ImpostaLunghezza();
            this.Hide();
            imp.ShowDialog();
            this.Close();
        }

        private void lunghezzaMax_Click(object sender, EventArgs e)
        {
            lunghezzaMax lngt = new lunghezzaMax();
            this.Hide();
            lngt.ShowDialog();
            this.Close();
        }
    }
}