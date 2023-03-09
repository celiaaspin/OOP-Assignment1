using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
   
        class Testing
        {
            static void Main(string[] args)
            {
                //Testing pack creation
                Pack deck = new Pack();

                Console.WriteLine("---Shuffle---");
                Console.WriteLine("\n1. Fisher-Yates Shuffle\n" +
                                  "\n2. Riffle Shuffle\n" +
                                  "\n3. No Shuffle\n");

                string choiceMenu = Console.ReadLine();
                int choiceShuffle;
                
                

                try
                {
                    choiceShuffle = int.Parse(choiceMenu);
                    
                    if (choiceShuffle == 0 || choiceShuffle >= 4) 
                    {
                        Console.WriteLine("Invalid Input.");

                    }

                    else if (choiceShuffle == 1)
                    {
                        Console.WriteLine("Fisher-Yates Shuffle chosen");
                        Pack.shuffleCardPack(1);
                    }

                    else if (choiceShuffle == 2)
                    {
                        Console.WriteLine("Riffle Shuffle chosen");
                        Pack.shuffleCardPack(2);
                    }

                    else if (choiceShuffle == 3) 
                    {
                        Console.WriteLine("No Shuffle chosen");   
                        Pack.shuffleCardPack(3);
                    }
                }

                catch (FormatException)
                {
                Console.WriteLine("Invalid Input.");            
                }

                Console.WriteLine("\n---Deal Cards---\n");

                Console.WriteLine("How many cards would you like to deal?");

                int choiceAmount = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (choiceAmount == 0 || choiceAmount >= 52)
                    {
                        Console.WriteLine("Invalid Input.");
                    }

                    else if (choiceAmount == 1)
                    {
                        var dealOne = Pack.dealCardOne();
                        dealOne.cardType();
                    }

                    else if (choiceAmount == 2 || choiceAmount <= 52)
                    {
                        var dealMultiple = Pack.dealCardMulti(choiceAmount);
                        
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.ReadKey();
            }
        }
}