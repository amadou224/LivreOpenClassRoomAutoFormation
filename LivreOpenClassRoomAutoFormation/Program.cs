using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LivreOpenClassRoomAutoFormation
{
    class Program
    {
        enum semaine
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            
                                 
        }

        #region TP SUR LES BOUCLES  

        static int sommeNbreConse(int a , int b )
        {
            int res = 0;
            Console.WriteLine("La somme des nombres de ces nombres consecutifs est: ");
            for(int i =a; i<=b;i++)
            {
                res = res + i;
            }
            return res;
        }
       static double moyenneListe(List<double>maListe)
       {
            double resultat=0.0;
            int nbreElm = maListe.Count;
            Console.WriteLine("La moyenne de ma liste est :");
            foreach(double i in maListe)
            {
                resultat = resultat + i;
            }
            return resultat/nbreElm;
       }

        static int intesectionDeuxListes()
        {
            List<int> fristListe = new List<int>();
            List<int> secondListe = new List<int>();
            int resultat=0;
            Console.WriteLine("La somme des nombres communs entre deux listes");
            for(int i = 3; i<=100; i+=3)
            {
                fristListe.Add(i);
            }
            for(int i =5; i<=100; i+=5)
            {
                secondListe.Add(i);
            }
            foreach( int k in fristListe)
            {
                foreach(int j in secondListe)
                {
                    if (k==j)
                    {
                        resultat = resultat + k;
                    }
                }
            }
            return resultat;
        }

        #endregion

    }
}
