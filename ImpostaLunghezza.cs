using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColombiFile
{
    public partial class ImpostaLunghezza : Form
    {
        public ImpostaLunghezza()
        {
            InitializeComponent();
        }

        private void ImpostaLunghezza_Load(object sender, EventArgs e)
        {
            valore.Value = leggi(@"dati.csv");
        }
        public static int leggi(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line= sr.ReadLine();
            char[] record = line.ToCharArray();
            int lunghezzaMax = record.Length;
            while ((line = sr.ReadLine()) != null)
            {
                record = line.ToCharArray();
                if (lunghezzaMax < record.Length) lunghezzaMax = record.Length;
            }
            sr.Close();
            return lunghezzaMax;
        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            if(valore.Value> leggi(@"dati.csv"))
            {

            }
        }
    }
}
