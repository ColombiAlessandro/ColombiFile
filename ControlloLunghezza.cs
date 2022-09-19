using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ColombiFile
{
    public partial class ControlloLunghezza : Form
    {
        public ControlloLunghezza()
        {
            InitializeComponent();
        }

        private void ControlloLunghezza_Load(object sender, EventArgs e)
        {
            textBox1.Text = leggi(@"dati.csv").ToString();
        }
        public static bool leggi(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            int tmp=0;
            int cont = 0;
            while ((line = sr.ReadLine()) != null)
            {
                char[] controllo = line.ToCharArray();
                if (cont == 0)
                {
                    tmp = controllo.Length;
                }
                if (tmp == controllo.Length)
                {
                    tmp = controllo.Length;
                } else
                {
                    return false;
                }
                cont++;
            }
            return true;
            sr.Close();
        }
    }
}
