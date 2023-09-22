using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    internal class Program
    {
        /// <summary>
        /// Création du jeu MasterMind sur la console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            List<char> list = new List<char>();

           /* string goal = "grws";*/
            string essai = "";
            string Ok;
            string MP;
            string reTry = "oui";
            int win;


              Random random = new Random();
            int x1 = random.Next(6);
            int x2 = random.Next(6);
            int x3 = random.Next(6);
            int x4 = random.Next(6);


            switch (x1)
            {
                case 0:
                    
                    break;
            }
            switch (x2)
            {
                case 0:
                    break;
            }
            switch (x3)
            {
                case 0:
                    break;
            }
            switch (x4)
            {
                case 0:
                    break;
            }


            while (reTry == "oui")
            {
                essai = "";
                win = 0;
                //texte de Bienvenue et introduction au jeu
                Console.WriteLine("\nBienvenue sur MasterMind !");
                Console.WriteLine("Couleurs possibles: gywrmbc");
                Console.WriteLine("Devine le code en 4 couleurs.\n");

                for (int numberTry = 1; numberTry <= 11 && win == 0; numberTry++)
                {
                    //Si l'utilisateur gagne
                    if (essai == goal)
                    {
                        numberTry = numberTry - 1;
                        Console.WriteLine("\nBravo, vous avez Gagnez en " + numberTry + " essais !! :)");
                        Console.Write("voulez-vous refaire ?\nMettez oui ou non: ");
                        
                        
                        reTry = Console.ReadLine();

                        while (reTry != "oui" && reTry != "non")
                        {

                            Console.WriteLine("\nVous n'avez pas écrit les mots attendus\nVeuillez écrire oui ou non: ");
                            reTry = Console.ReadLine();
                         
                        }
                        win = 1;

                    }

                    //Affiche ce code si l'utilisateur perd après 10 essais
                    else if (numberTry == 11 && essai != goal)
                    {
                        Console.WriteLine("\nDommage, vous avez perdu :/");
                        Console.Write("voulez-vous réessayer ?\nMettez oui ou non: ");
                        reTry = Console.ReadLine();

                        while (reTry != "oui" && reTry != "non")
                        {
                            
                                Console.WriteLine("\nVous n'avez pas écrit les mots attendus\nVeuillez écrire oui ou non: ");
                                reTry = Console.ReadLine();
                            
                        }

                    }

                    //éxécute ce code tant que l'utilisateur ne trouve pas le code ou fait moins de 10 essais
                    else
                    {
                        Console.Write("\nEssai " + numberTry + " : ");
                        essai = Console.ReadLine();
                        Console.WriteLine("\n=>Ok: ");
                        Console.WriteLine("Mauvaise position: ");
                    }

                }
            }

        }
    }
}

 