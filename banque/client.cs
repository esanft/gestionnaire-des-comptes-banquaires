using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class client
    {
        static int cNumeroUser = 1;     // variable de classe pour les numéros des users
        private string oNumeroUser;  // variable d'instance pour le numéro de chaque user
        private int oNumeroPiece;
        private string oTypePiece;
        private string oNomUser;
        private string oPrenomUser;
        private string oTelephoneUser;
        private string oAdresseUser;

        // Constructeur par défaut

        public client()
        {
        }

        // Constructeur surchargé d'initialisation

        public client(int pNumeroPiece, string pTypePiece, string pNomUser, string pPrenomUser, string pTelephoneUser, string pAdresseUser)
        {

            cNumeroUser = cNumeroUser + 1;

            this.oNumeroUser = cNumeroUser++.ToString();
            this.oNumeroPiece = pNumeroPiece;
            this.oTypePiece = pTypePiece;
            this.oNomUser = pNomUser;
            this.oPrenomUser = pPrenomUser;
            this.oTelephoneUser = pTelephoneUser;
            this.oAdresseUser = pAdresseUser;
        }

        // Création des propriétés

        public string NumeroUser
        {
            get { return this.oNumeroUser; }
            set { this.oNumeroUser = value; }
        }

        public int NumeroPiece
        {
            get { return this.oNumeroPiece; }
            set { this.oNumeroPiece = value; }
        }

        public string TypePiece
        {
            get { return this.oTypePiece; }
            set { this.oTypePiece = value; }
        }

        public string NomUser
        {
            get { return this.oNomUser; }
            set { this.oNomUser = value; }
        }

        public string PrenomUser
        {
            get { return this.oPrenomUser; }
            set { this.oPrenomUser = value; }
        }

        public string TelephoneUser
        {
            get { return this.oTelephoneUser; }
            set { this.oTelephoneUser = value; }
        }

        public string AdresseUser
        {
            get { return this.oAdresseUser; }
            set { this.oAdresseUser = value; }
        }
    }
}

