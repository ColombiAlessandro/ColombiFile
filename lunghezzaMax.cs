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
    public partial class lunghezzaMax : Form
    {
        public lunghezzaMax()
        {
            InitializeComponent();
        }

        private void lunghezzaMax_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader(@"dati.csv");
            string record = f.ReadLine();
            lunghezzaBox.Text = record.ToCharArray().Length.ToString();
        }
    }
}
