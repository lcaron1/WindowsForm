using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFenetre_MereFille
{
    public partial class FFille : Form
    {
        int id;
        private string monNom;
        private FMere maMere;

        public FFille(FMere maMere, int id)
        {
            InitializeComponent();
            this.Load += new EventHandler(FFille_Load);
            this.id = id;
            this.Text = String.Format("Je suis la fille n° {0}",this.id);
            this.monNom = this.Text;
            this.maMere = maMere;
            this.FormClosing += new FormClosingEventHandler(FFille_FormClosing);


        }
        void FFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            this.Text = tbNom.Text;
            string nom = this.Text;
            maMere.MaFilleChangeDeNom(this, nom);
        }

        private void btnMaMere_Click(object sender, EventArgs e)
        {
            string nom = this.Mere.NomMere;
            MessageBox.Show(nom);
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }
        public FMere Mere
        {
            get
            {
                return this.maMere;
            }
        }
        void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement load sur " + this.monNom);
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            this.Text = tbNom.Text;
            string nom = this.Text;
            maMere.MaFilleChangeDeNom(this, nom);
        }
    }
}
