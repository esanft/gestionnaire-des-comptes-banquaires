using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    public class CompteBloque : comptecourant
    {
        private string oDateDeblocage;

        // Constructeur par défaut

        public CompteBloque() : base()
        {
        }

        // Constructeur surchargé pour initialiser la durée de blocage

        public CompteBloque(string pNumeroUser, string pTypeCompte, string pNumeroGuichet, double pSolde, string pCodeSecret, string pDateDeblocage)
            : base(pNumeroUser, pTypeCompte, pNumeroGuichet, pSolde, pCodeSecret)
        {
            this.oDateDeblocage = pDateDeblocage;
        }

        // Création des propriétés

        public string DateDeblocage
        {
            get { return this.oDateDeblocage; }
            set { this.oDateDeblocage = value; }
        }

        // Réécriture de la methode de débit

        public override bool Debiter(double pMontant)
        {
            base.Debiter(pMontant);
            if (DateTime.Today >= DateTime.Parse(this.oDateDeblocage))
            {
                this.oSolde -= pMontant;
                return true;
            }
            else
                return false;
        }
    }
}
