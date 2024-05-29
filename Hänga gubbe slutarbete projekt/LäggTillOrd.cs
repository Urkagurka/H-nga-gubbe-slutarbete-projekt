using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hänga_gubbe_slutarbete_projekt
{
    public partial class LäggTillOrd : Form
    {
        public LäggTillOrd()
        {
            InitializeComponent();
        }

        private void buttonLägtillord_Click(object sender, EventArgs e)
        {
            string Nyord = textBoxNyttOrd.Text;
            if (Nyord.Length > 0)
            {
                this.Close();
            }
        }

        public string getNyttOrd()
        {
            return textBoxNyttOrd.Text;
        }
    }
}
