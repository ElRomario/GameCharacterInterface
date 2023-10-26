using System;
using HomeWorkGameCharacterInterface.Abstracts;
using HomeWorkGameCharacterInterface;
using HomeWorkGameCharacterInterface.Classes;
using System.Collections.Generic;


namespace HomeWorkGameCharacterInterface
{
    class Program
    {
        static bool show = false;

        static void Main(string[] args)
        {
            StartScreen();
        }
            
             static void StartScreen()
             {
             List<Iobject> inventory = new List<Iobject>{ new KnifeNew(), new KnifeWorn(),
                                                    new SwordWorn(), new SwordNew(),
                                                    new BuffPotionFull(), new BuffPotionHalf(),
                                                    new HealPotionHalf(), new HealPotionFull(),
                                                    new ArmourDiamondNew(), new ArmourDiamondWorn(),
                                                    new ArmourHellstone()};

            do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Clear();

                        Console.WriteLine(" _______  _        _______  _______  _______  _        _______ ");
                        Console.WriteLine("(  ____ \\( \\      (  ___  )(       )(  ___  )( (    /|(  ____ \\");
                        Console.WriteLine("| (    \\/| (      | (   ) || () () || (   ) ||  \\  ( || (    \\/");
                        Console.WriteLine("| (_____ | |      | |   | || || || || (___) ||   \\ | || (_____ ");
                        Console.WriteLine("(_____  )| |      | |   | || |(_)| ||  ___  || (\\ \\) |(_____  )");
                        Console.WriteLine("      ) || |      | |   | || |   | || (   ) || | \\   |      ) |");
                        Console.WriteLine("/\\____) || (____/\\| (___) || )   ( || )   ( || )  \\  |/\\____) |");
                        Console.WriteLine("\\_______)(_______/(_______)|/     \\||/     \\||/    )_)\\_______)");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        if (show == true)
                        {
                            Console.WriteLine("                   -PRESS ENTER TO CONTINUE-");
                        }
                        else Console.WriteLine(" ");
                        show = !show;
                        System.Threading.Thread.Sleep(500);
                    }
                }
                while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                {
                     menu(inventory);
                }

           
            }

            
        static void menu(List<Iobject> inventory)
         {
            System.Console.Clear();


            Console.WriteLine("===Your inventory===");
                      foreach(Iobject item in inventory)
                            {
                                string outPut = item.Equipped == true ? item.Name : "";
                                Console.Write(outPut);
                                if (outPut == "");
                                else { Console.WriteLine(); item.PrintStatus(); };
                            }
                        Console.WriteLine("PRESS ENTER TO GO TO WAREHOUSE");

                   
               
                 while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                  {
                        wareHouse(inventory);
                  }
          }
        
        static void wareHouse(List<Iobject> inventory)
        
        
        {
            System.Console.Clear();
            List<Iobject> stash = new List<Iobject> { new KnifeNew(), new KnifeWorn(),
                                                    new SwordWorn(), new SwordNew(),
                                                    new BuffPotionFull(), new BuffPotionHalf(),
                                                    new HealPotionHalf(), new HealPotionFull(),
                                                    new ArmourDiamondNew(), new ArmourDiamondWorn(),
                                                    new ArmourHellstone()};

            int index = 1;
                

         
                foreach(Iobject item in stash)
                {
                    string outPut = inventory[index - 1].Equipped ? "--Equipped--" : inventory[index -1].Name;
                    Console.Write($"{ index}) ");
                    Console.WriteLine(outPut);
                    index++;
                }
                
                Console.WriteLine("===================================");
                Console.WriteLine("Enter number of item you would like to equip");
                Console.WriteLine("Enter 0 to go back");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > stash.Count || input < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else if(input == 0)
                {
                    menu(inventory);
                }
                else
                {
                    
                    inventory[input - 1].Equipped = true;
                    
                }
            wareHouse(inventory);


            }
            
        
    }
}

