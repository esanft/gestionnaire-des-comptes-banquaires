using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    public class virementscomtes
    {
        static int cNumeroVirement = 0;
        private string oNumeroVirement;
        private string oNumeroUser;
        private string oNumeroCompte;
        private double oMontantVirement;
        private string oDateVirement;
        private string oDestinataire;
        private bool oAutomatique;

        // Contructeur par défaut

        public virementscomtes()
        {
        }

        // Constructeur surchargé

        public virementscomtes(string pNumeroUser, string pNumeroCompte, double pMontantVirement, string pDateVirement, string pDestinataire)
        {
            
                cNumeroVirement = cNumeroVirement;

            this.oNumeroUser = pNumeroUser;
            this.oNumeroCompte = pNumeroCompte;
            this.oMontantVirement = pMontantVirement;
            this.oDateVirement = pDateVirement;
            this.oDestinataire = pDestinataire;
            this.oAutomatique = false;
            cNumeroVirement++;
            this.oNumeroVirement = cNumeroVirement.ToString();
        }

        // Création des accesseurs

        public string NumeroVirement
        {
            get { return this.oNumeroVirement; }
            set { this.oNumeroVirement = value; }
        }

        public string NumeroUser
        {
            get { return this.oNumeroUser; }
            set { this.oNumeroUser = value; }
        }

        public string NumeroCompte
        {
            get { return this.oNumeroCompte; }
            set { this.oNumeroCompte = value; }
        }

        public double MontantVirement
        {
            get { return this.oMontantVirement; }
            set { this.oMontantVirement = value; }
        }

        public string DateVirement
        {
            get { return this.oDateVirement; }
            set { this.oDateVirement = value; }
        }

        public string Destinataire
        {
            get { return this.oDestinataire; }
            set { this.oDestinataire = value; }
        }

        public bool Automatique
        {
            get { return this.oAutomatique; }
            set { this.oAutomatique = value; }
        }
    }
}
