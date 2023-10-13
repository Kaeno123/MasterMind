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
            string reTry = "oui";
            int win;
            string choice = "";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n*******************************\nBIENVENUE SUR MASTERMIND !");
            Console.WriteLine("*******************************\n");
            Console.Write("1. Mode normal\n2. Mode facile\n3. Quitter\n\nInsérez le chiffre du mode auquel vous souhaitez jouer: ");
            Console.ResetColor();


            while (choice != "1" && choice != "2" && choice !="3")
            {
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    normalmode();
                }
                else if (choice == "2")
                {
                    easymode();
                }
                else if (choice == "3")
                {
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vous n'avez pas insérez les caractères attendus.\nVeuillez recommencer: ");
                    Console.ResetColor();
                }

            }




            void normalmode()
            {
                //clean the console
                Console.Clear();

                //launch of the game
                while (reTry == "oui")
                {
                    //generate 4 colors among 7 randomly
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

                    //the combination that the user must find
                    string finalgoal = goal[0] + goal[1] + goal[2] + goal[3];

                    essai = "";
                    win = 0;

                    //welcome text and introdocution to the game
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Couleurs possibles: gywrmbc");
                    Console.WriteLine("Devine le code en 4 couleurs.\n*******************************\n");
                    Console.ResetColor();


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
                            int Ok = 0;
                            int MP = 0;
                            Console.Write("\nEssai " + numberTry + " : ");

                            //the combination of color that choose the user
                            essai = Console.ReadLine();

                            //table that divide each character of the combination
                            char[] motsepa = new char[essai.Length];

                            for (int i = 0; i < 4; i++)
                            {
                                motsepa[i] = (char)essai[i];
                            }

                            //for color that is in the right position
                            for (int i = 0; i < 4; i++)
                            {
                                if (motsepa[i] == Convert.ToChar(goal[i]))
                                {
                                    Ok = Ok + 1;
                                }

                            }

                            //for bad position
                            for (int i = 0; i < 4; i++)
                            {
                                for (int j = 0; j < goal.Length; j++)
                                {
                                    if (motsepa[i] == Convert.ToChar(goal[j]) && motsepa[j] != Convert.ToChar(goal[j]))
                                    {
                                        MP = MP + 1;
                                    }
                                }
                            }

                            Console.WriteLine("\n=>Ok: " + Ok);
                            Console.WriteLine("Mauvaise position: " + MP);
                        }

                    }
                }
            }
            void easymode()
            {
                //clean the console
                Console.Clear();

                //launch of the game
                while (reTry == "oui")
                {
                    //generate 4 colors among 7 randomly
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

                    //the combination that the user must find
                    string finalgoal = goal[0] + goal[1] + goal[2] + goal[3];

                    essai = "";
                    win = 0;

                    //welcome text and introdocution to the game
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Couleurs possibles: gywrmbc");
                    Console.WriteLine("Devine le code en 4 couleurs.\n*******************************\n");
                    Console.ResetColor();


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
                            Console.WriteLine(finalgoal);

                            int Ok = 0;
                            int MP = 0;
                            Console.Write("\nEssai " + numberTry + " : ");

                            //the combination of color that choose the user
                            essai = Console.ReadLine();

                            //table that divide each character of the combination
                            char[] motsepa = new char[essai.Length];
                            char[] restMotsepa = new char[essai.Length];
                            char[] goalsa = new char[essai.Length];
                            char[] Restgoalsa = new char[essai.Length];


                            for (int i = 0; i < 4; i++)
                            {
                                motsepa[i] = (char)essai[i];
                                goalsa[i] =Convert.ToChar(goal[i]);
                            }

                            //for color that is in the right position
                            for (int i = 0; i < 4; i++)
                            {
                                if (motsepa[i] == Convert.ToChar(goal[i]))
                                {
                                    Ok = Ok + 1;
                                    restMotsepa[i] = 'Z';
                                    goalsa[i] = 'Y';
                                }
                                else
                                {
                                    restMotsepa[i] = motsepa[i];
                                    Restgoalsa[i] = goalsa[i];
                                }

                            }

                            //for bad position
                            for (int i = 0; i < restMotsepa.Length; i++)
                            {
                                for (int j = 0; j < restMotsepa.Length; j++)
                                {
                                    if (restMotsepa[i] == (Restgoalsa[j]) && restMotsepa[j] != (Restgoalsa[j]))
                                    {
                                        MP = MP + 1;
                                    }
                                }
                            }
                            Console.WriteLine("\n=>Ok: " + Ok);
                            Console.WriteLine("Mauvaise position: " + MP);
                        }

                    }
                }
                
            }
        }
    }
} 