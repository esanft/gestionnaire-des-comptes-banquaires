using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    public class compteE : comptecourant
    {
        private string oPeriodeVersement;
        public compteE()
        {
        }

        // Constructeur surchargé qui initialise la période de versement

        public compteE(string pNumeroUser, string pTypeCompte, string pNumeroGuichet, double pSolde, string pCodeSecret, string pPeriodeVersement)
            : base(pNumeroUser, pTypeCompte, pNumeroGuichet, pSolde, pCodeSecret)
        {
            this.oPeriodeVersement = pPeriodeVersement;
        }

        // Création des propriétés

        public string PeriodeVersement
        {
            get { return this.oPeriodeVersement; }
            set { this.oPeriodeVersement = value; }
        }
    }
}
