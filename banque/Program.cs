using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<client> clients = new List<client>();

            comptecourant cc = new comptecourant();
            virementscomtes vc = new virementscomtes();
            compteE ce = new compteE();
            CompteBloque cb = new CompteBloque();
            int choix = 0;
            while (choix == 0)
            {
                Console.WriteLine("1---------ajouter client ");
                Console.WriteLine("2---------information  client ");
                Console.WriteLine("3---------information  du compte client ");
                Console.WriteLine("4---------faire un virement ");
                choix = Convert.ToInt32(Console.ReadLine());
                
                client cl = new client();
                if (choix == 1)
                {

                   
                    Console.WriteLine("1/pour ajouter client/n");
                    Console.WriteLine("----------donner le Numero client/n");
                    cl.NumeroUser = Console.ReadLine();
                    Console.WriteLine("----------donner le Numero Piece/n");
                    cl.NumeroPiece = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------donner le Tipe Piece/n");
                    cl.TypePiece = Console.ReadLine();


                    Console.WriteLine("----------donner le nom/n");
                    cl.NomUser = Console.ReadLine();

                    Console.WriteLine("----------donner le prenom/n");
                    cl.PrenomUser = Console.ReadLine();
                    Console.WriteLine("----------donner telphone/n");
                    cl.TelephoneUser = Console.ReadLine();
                    Console.WriteLine("----------donner adresse/n");
                    cl.AdresseUser = Console.ReadLine();
                    clients.Add(cl);
                 

                    Console.WriteLine("----------information client ajoutee avec succe------------/n");
                    Console.WriteLine("1/compte courant/n");
                    Console.WriteLine("2/compte epargne/n");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.WriteLine("----------ajouter les informations du compte courant------------/n");
                        Console.WriteLine("----------donner numero de compte/n");
                        cc.NumeroCompte = Console.ReadLine();

                        cc.NumeroUser = cl.NumeroUser;
                        Console.WriteLine("----------donner NumeroGuichet/n");
                        cc.NumeroGuichet = Console.ReadLine();
                        Console.WriteLine("----------donner Solde/n");
                        cc.Solde = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------donner CodeSecret/n");
                        cc.CodeSecret = Console.ReadLine();
                        Console.WriteLine("----------donner CodeSecret/n");

                        cc.TypeCompte = "courant";


                    }
                    else
                    {
                        Console.WriteLine("----------ajouter les informations du compte epargne------------/n");
                        Console.WriteLine("----------donner numero de compte/n");
                        ce.NumeroCompte = Console.ReadLine();

                        ce.NumeroUser = cl.NumeroUser;
                        Console.WriteLine("----------donner NumeroGuichet/n");
                        ce.NumeroGuichet = Console.ReadLine();
                        Console.WriteLine("----------donner Solde/n");
                        ce.Solde = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------donner CodeSecret/n");
                        ce.CodeSecret = Console.ReadLine();
                        Console.WriteLine("----------donner CodeSecret/n");

                        ce.TypeCompte = "epargne";
                        Console.WriteLine("----------donner PeriodeVersement/n");
                        ce.PeriodeVersement = Console.ReadLine();
                    }
                }
                else if (choix == 2)
                {
                    Console.WriteLine(cl.NumeroUser);
                    Console.WriteLine(cl.NomUser);
                    Console.WriteLine(cl.PrenomUser);
                    Console.WriteLine(cl.TelephoneUser);
                    Console.WriteLine(cl.TypePiece);
                }
                else if (choix == 3)
                {
                    if (cl.NumeroUser == cc.NumeroUser)
                    {
                        Console.WriteLine(cc.NumeroGuichet);
                        Console.WriteLine(cc.NumeroCompte);
                        Console.WriteLine(cc.Solde);
                        Console.WriteLine(cc.TypeCompte);

                    }
                    else
                    {
                        Console.WriteLine(ce.NumeroGuichet);
                        Console.WriteLine(ce.NumeroCompte);
                        Console.WriteLine(ce.Solde);
                        Console.WriteLine(ce.TypeCompte);
                        Console.WriteLine(ce.PeriodeVersement);
                    }

                }
                else if (choix == 4)
                {
                    Console.WriteLine("Numero Virement ");
                    vc.NumeroVirement = Console.ReadLine();
                    Console.WriteLine("Montant Virement ");
                    vc.MontantVirement = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Destinataire");
                    vc.Destinataire = Console.ReadLine();
                    vc.NumeroCompte = cc.NumeroCompte;
                    vc.NumeroUser = cl.NumeroUser;
                    cc.Solde = cc.Solde - vc.MontantVirement;

                }
                choix = 0;

            }

        }
    }
}
