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
    public partial class FMere : Form
    {
        List<FFille> lesfilles;
        private int nombreFille;
        private string nomMere;
        public FMere()
        {
            InitializeComponent();
            btnClose.Click += new EventHandler(btnClose_Click);
            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            this.lesfilles = new List<FFille>();
            this.Text = "Mere";
            this.nomMere = "maman";



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nombreFille = nombreFille + 1;
            FFille nouvelleFenetre = new FFille(this,nombreFille);
            lesfilles.Add(nouvelleFenetre);
            lbLesFilles.Items.Add("fille n° " + this.nombreFille);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesfilles[position].Close();
                lesfilles.RemoveAt(position);
                lbLesFilles.Items.RemoveAt(position);
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesfilles[position].Show();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            int position = this.lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                this.lesfilles[position].Hide();
            }

        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesfilles[position].ShowDialog();
            }
        }

        public string NomMere
        {
            get 
            {
                return this.nomMere;
            
            }
        }

        private void lbLesFilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenetre fille a ete instanciee");
        }
        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            int position = lesfilles.IndexOf(ffille);
            if (position != -1)
            {
                lesfilles[position] = ffille;
                lbLesFilles.Items[position] = nouveauNom;
            }
        }
    }
}
