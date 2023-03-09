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

                //User input for shuffle choice
                Console.WriteLine("---Shuffle---");
                Console.WriteLine("\n1. Fisher-Yates Shuffle\n" +
                                  "\n2. Riffle Shuffle\n" +
                                  "\n3. No Shuffle\n");

                string choiceMenu = Console.ReadLine();//Declares variable as string
                int choiceShuffle;//Declares variable as an interger
                
                
                
                try
                {
                    choiceShuffle = int.Parse(choiceMenu);//Changes the user input variable to an integer
                    
                    if (choiceShuffle == 0 || choiceShuffle >= 4) 
                    {
                        Console.WriteLine("Invalid Input."); //Exception Handling

                    }

                    else if (choiceShuffle == 1)
                    {
                        //Fisher-Yates Shuffle
                        Console.WriteLine("Fisher-Yates Shuffle chosen");
                        Pack.shuffleCardPack(1);
                    }

                    else if (choiceShuffle == 2)
                    {
                        //Riffle Shuffle
                        Console.WriteLine("Riffle Shuffle chosen");
                        Pack.shuffleCardPack(2);
                    }

                    else if (choiceShuffle == 3) 
                    {
                        //No Shuffle
                        Console.WriteLine("No Shuffle chosen");   
                        Pack.shuffleCardPack(3);
                    }
                }

                catch (FormatException)//Exception Handling - input is not an integer
            {
                Console.WriteLine("Invalid Input.");           
                }

                //User input for how many cards they want to be dealt
                Console.WriteLine("\n---Deal Cards---\n");

                Console.WriteLine("How many cards would you like to deal?");

                int choiceAmount = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (choiceAmount == 0 || choiceAmount >= 52) //Is user input invalid
                    {
                        Console.WriteLine("Invalid Input.");
                    }

                    else if (choiceAmount == 1)
                    {
                        var dealOne = Pack.dealCardOne();
                        dealOne.cardType();//Outputs the card
                    }

                    else if (choiceAmount == 2 || choiceAmount <= 52)
                    {
                        var dealMultiple = Pack.dealCardMulti(choiceAmount);
                        
                    }
                }

                catch (FormatException) //Exception Handling - input is not an integer
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.ReadKey();
            }
        }
}