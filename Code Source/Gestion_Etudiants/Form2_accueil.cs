using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Etudiants
{
    public partial class Form2_accueil : Form
    {
        public Form2_accueil()
        {
            InitializeComponent();
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gestion_notes ma = new Gestion_notes();
            ma.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultation ma = new Consultation();
            ma.Show();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_Etudiant ma = new Form3_Etudiant();
            ma.Show();
        }

        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            module ma = new module();
            ma.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
