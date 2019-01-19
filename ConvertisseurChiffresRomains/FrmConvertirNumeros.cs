using ConvertisseurChiffresRomains.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Auteur: Júlia Nepomuceno Mello
//Date: 19/01/2019
//Résumé: logiciel de conversion de nombres (nombres arabes) en chiffres romains

namespace ConvertisseurChiffresRomains
{
    public partial class FrmConvertirNumeros : Form
    {
     
        public FrmConvertirNumeros()
        {
            InitializeComponent();
        }

        //Evénement lié au clic sur le bouton pour effectuer la conversion
        private void btnConvertir_Click(object sender, EventArgs e)
        {

            if(textBoxNumero.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez entrer un nombre compris entre 1 et 3999");
                textBoxNumero.Focus();
                return;
            }

            int numero = Convert.ToInt32(textBoxNumero.Text);
            if ((numero < 1) || (numero > 3999))
            {
                MessageBox.Show("Le nombre doit être compris entre 1 et 3999");
                textBoxNumero.Focus();
                return;
            }

            textBoxChiffreRomain.Text = Conversion(numero);
        }


        //Méthode pour la réalisation de la conversion
        private string Conversion(int num)
        {
            string retour = "";
            Convertisseur ConvChiffres = new Convertisseur(); //Déclarer et instancier une variable de classe Convertisseur
            ConvChiffres.ConvertirNumero(num); //Conversion 
            retour = ConvChiffres.Resultat;

            return retour;
        }


        //Evénement pour n'autoriser que les nombres (entre 0 et 9) et la touche backspace
        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (Convert.ToInt32(e.KeyChar) != 8)
                    e.Handled = true;
            }
        }

        //Conversion de tous les nombres entre 1 et 3999.
        private void btnConvertirGeneral_Click(object sender, EventArgs e)
        {
            for(int i = 1; i<= 3999; i++)
            {
                textBoxListeNumeros.AppendText("Numéro : " + i.ToString() + " - Chiffre romain : " + Conversion(i) + "\r\n");
            }
        }
    }
}
