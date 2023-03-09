using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {   //Fields
        public static List<Card> pack = new List<Card>();
        public static List<Card> dealCard = new List<Card>();
        public static List<Card> cardsDealt = new List<Card>();
        public static List<Card> first = new List<Card>();


        public Pack()
        {
            //Initializing Card Pack
            int number = 1;
            int cardSuit = 1;

            if (cardSuit <= 4)
            {
                pack.Add(new Card(number, cardSuit));
                number++;
                if (number == 14)
                {
                    number = 1;
                    cardSuit++;
                }
            }
        }
        //Shuffling the pack, depending on the type chosen
        //Fisher-Yates Shuffle
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                var random = new System.Random();
                var x = pack.Count;
                //For each item within the unshuffled pack of cards
                for (var i = 0; i < x; i++)
                {
                    //A random card in the deck is picked
                    var y = i + random.Next(x - i);
                    //The chosen card is swapped with the last unshuffled card
                    Card temp = pack[y];
                    pack[y] = pack[i];
                    pack[i] = temp;

                    Console.WriteLine("Shuffle Successful");
                }
                return true;

            }
            //Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                int n = 0;
                while (n < (pack.Count / 2))
                {
                    first.Add(pack[n]);
                    first.Add(pack[n + pack.Count / 2]);
                    n++;
                }
                pack = first;
                Console.WriteLine("Shuffle Successful");
                return true;
            }
            //No Shuffle
            else
            {
                Console.WriteLine("Pack was not shuffled.");
                return true;
            }

        }
        //Deals one card
        public static Card dealCardOne()
        {
            if (pack.Count == 0)
            {
                Console.WriteLine("Deck is empty");
                return null;
            }
            //The front item in the list is removed, added to a different list and the value returned 
            Card firstCard = pack[0];
            pack.RemoveAt(0);
            cardsDealt.Add(firstCard);
            return firstCard;

        }
        //Deals multiple cards depending on the amount chosen
        public static List<Card> dealCardMulti(int amount)
        {
            //Clearing the list so no previous dealt cards appear
            cardsDealt.Clear();
            //Exception Handling, if the pack is empty nothing can happen
            if (pack.Count == 0)
            {
                Console.WriteLine("Deck is empty");
                return null;
            }
            //Exception Handling, if the amount is greater than the cards left, nothing can happen
            else if (pack.Count < amount)
            {
                Console.WriteLine("Cannont deal more cards than is in the deck");
                return null;
            }
            else
            {
                //Firstcard is removed, and each subsiquent int after that
                for (int z = 0; z < amount; z++)
                {
                    Card firstCard = pack[0];
                    pack.RemoveAt(0);
                    cardsDealt.Add(firstCard);
                    firstCard.cardType();
                }
                return cardsDealt;
            }
        }

    }
}
