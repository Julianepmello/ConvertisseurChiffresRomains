using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertisseurChiffresRomains.Class
{
    //Résumé:
    //     Classe pour réaliser la conversion de nombres (nombres arabes) en chiffres romains
    //Attributs: 
    //     Valeurs correspondant aux chiffres romains, chiffres romains et resultat de la conversion
    //Méthodes:
    //     Constructeur par défaut et méthode pour la conversion

    public class Convertisseur
    {
        //Déclaration d'attributs de classe
        private int[] Valeurs; // Variable contenant les valeurs correspondant aux chiffres romains
        private char[] ChiffresRomains; //Variable contenant chiffres romains
        public string Resultat; //Résultat de la conversion

        public Convertisseur() // Constructeur par défaut
        {
            //Instanciation d'attributs
            Valeurs = new int[7];
            ChiffresRomains = new char[7];

            //Assignation de valeurs correspondant aux chiffres romains
            Valeurs[0] = 1;
            Valeurs[1] = 5;
            Valeurs[2] = 10;
            Valeurs[3] = 50;
            Valeurs[4] = 100;
            Valeurs[5] = 500;
            Valeurs[6] = 1000;

            //Assignation des chiffres romains
            ChiffresRomains[0] = 'I';
            ChiffresRomains[1] = 'V';
            ChiffresRomains[2] = 'X';
            ChiffresRomains[3] = 'L';
            ChiffresRomains[4] = 'C';
            ChiffresRomains[5] = 'D';
            ChiffresRomains[6] = 'M';
        }



        //Cette méthode vise à effectuer la conversion de nombres en chiffres romains, 
        //en analysant le quotient et le résidu de divisions du nombre souhaité 
        //par les valeurs correspondant aux chiffres romains.
        //Input: Numéro à convertir
        //Output: Chiffre romain correspondant au numér
        public string ConvertirNumero (int Numero) //Méthode de conversion de numéro
        {

            //Déclaration de variables auxiliaires
            int ResteDivision = 1; //Pour commencer le while
            int Quotient = 0;
            int i = 6; // Pour commencer la division de la plus haute valeur
            Resultat = ""; // Effacement de la variable de résultat

            //Tant que le reste de la division est non nul (il y a un nombre à diviser)
            while (ResteDivision != 0)
            {
                Quotient = Numero / Valeurs[i]; //Effectue la division
                ResteDivision = Numero % Valeurs[i]; //Obtenez le reste de la division

                if (i == 1 | i == 3 | i == 5) //Pour les valeurs 5, 50 et 500
                {
                    if (Quotient >= 1 & Quotient <= 3 & ResteDivision >= Valeurs[i - 1] * 4)
                    {
                        Resultat = Resultat + ChiffresRomains[i - 1].ToString() + ChiffresRomains[i + 1].ToString();
                        ResteDivision = ResteDivision - Valeurs[i - 1] * 4;
                    }

                    else
                    {
                        if (Quotient >= 1 & Quotient <= 3 & ResteDivision < Valeurs[i - 1] * 4)
                        {
                            Resultat = Resultat + ChiffresRomains[i].ToString();
                        }
                    }
                }

                else //Pour les valeurs 1, 10, 100 et 1000
                {
                    if (Quotient >= 1 & Quotient <= 3)
                    {
                        while (Quotient >= 1)
                        {
                            Resultat = Resultat + ChiffresRomains[i].ToString();
                            Quotient = Quotient - 1;
                        }
                    }
                    else
                    {
                        if (Quotient > 3)
                        {
                            Resultat = Resultat + ChiffresRomains[i].ToString() + ChiffresRomains[i + 1].ToString();
                        }
                    }
                }

                Numero = ResteDivision;
                i--;
            } // fin while

            return Resultat;
        }

    }
}
