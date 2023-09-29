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

            string[] goal = new string[4];
            string essai = "";
            string Ok;
            string MP;
            string reTry = "oui";
            int win;
            

            while (reTry == "oui")
            {
                Random random = new Random();

                int[] randomColors = new int[4];
                randomColors[0] = random.Next(6);
                randomColors[1] = random.Next(6);
                randomColors[2] = random.Next(6);
                randomColors[3] = random.Next(6);

                for (int i = 0; i < randomColors.Length; i++)
                {
                    if (randomColors[i] == 0)
                    {
                        goal[i] = "g";
                    }
                    else if (randomColors[i] == 1)
                    {
                        goal[i] = "y";
                    }
                    else if (randomColors[i] == 2)
                    {
                        goal[i] = "w";
                    }
                    else if (randomColors[i] == 3)
                    {
                        goal[i] = "r";
                    }
                    else if (randomColors[i] == 4)
                    {
                        goal[i] = "m";
                    }
                    else if (randomColors[i] == 5)
                    {
                        goal[i] = "b";
                    }
                    else if (randomColors[i] == 6)
                    {
                        goal[i] = "c";
                    }
                }

                string finalgoal = goal[0] + goal[1] + goal[2] + goal[3];

                essai = "";
                win = 0;

                Console.WriteLine(goal[0] + goal[1] + goal[2] + goal[3]);

                //welcome text and introdocution to the game
                Console.WriteLine("\n*******************************\nBienvenue sur MasterMind !");
                Console.WriteLine("Couleurs possibles: gywrmbc");
                Console.WriteLine("Devine le code en 4 couleurs.\n*******************************\n");


                for (int numberTry = 1; numberTry <= 11 && win == 0; numberTry++)
                {
                    //if the user win
                    if (essai == finalgoal)
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

                    //shows this code if the user loose after 10 try
                    else if (numberTry == 11 && essai != finalgoal)
                    {
                        Console.WriteLine("\nDommage, vous avez perdu :/. Le code était ");
                        Console.Write("voulez-vous réessayer ?\nMettez oui ou non: ");
                        reTry = Console.ReadLine();

                        while (reTry != "oui" && reTry != "non")
                        {
                            Console.WriteLine("\nVous n'avez pas écrit les mots attendus\nVeuillez écrire oui ou non: ");
                            reTry = Console.ReadLine();
                        }

                    }

                    //do this code while the user doesn't find the goal or do less than 10 try
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