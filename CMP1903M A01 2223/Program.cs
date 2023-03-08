using System;
using System.Collections.Generic;
using System.Linq;
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

          //Testing Fisher-Yates Shuffle
          Console.Write("\nFisher-Yates Shuffle\n");
            bool shuffleCompleteFisherYates = Pack.shuffleCardPack(1);
            if (shuffleCompleteFisherYates)
            {
                Console.WriteLine("\nShuffle Successful\n");
            }

            //Testing Riffle Shuffle
            Console.WriteLine("\nRiffle Shuffle\n");
            bool shuffleCompleteRiffle = Pack.shuffleCardPack(2);
            if (shuffleCompleteRiffle)
            {
                Console.WriteLine("\nShuffle Successful\n");
            }

            //Testing No Shuffle
            Console.WriteLine("\nNo Shuffle\n");
            bool shuffleCompleteNoShuffle = Pack.shuffleCardPack(3);
            if (shuffleCompleteNoShuffle)
            {
                Console.WriteLine("\nShuffle Successful\n");
            }

            //Testing one card shuffle
            Console.WriteLine("\nOne Card\n");
            Pack.DealCard().CardType();

            //Testing multiple card deal
            Console.WriteLine("\nMultiple Cards\n");
            Pack.DealCard(3);
            foreach (Card card in Pack.cardsDealt)
            {
                card.CardType();
            }
 

            //Pauses the program
            Console.ReadKey();



        }
    }
}
