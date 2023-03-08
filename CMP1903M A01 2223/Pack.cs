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

                for (var i = 0; i < x; i++)
                {
                    var y = i + random.Next(x - i);
                    Card temp = pack[y];
                    pack[y] = pack[i];
                    pack[i] = temp;
                }
                return true;

            }
            //Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                pack.GetRange(0, 1);

                int n = 0;
                int m = 0;

                if (n <= 52)
                {
                    pack[n] = pack[m];
                    n++;
                    m++;
                }
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
        public static Card DealCard()
        {
            
            Card firstCard = pack[0];
            pack.RemoveAt(0);
            cardsDealt.Add(firstCard);
            return firstCard;

        }
        //Deals multiple cards depending on the amount chosen
        public static List<Card> DealCard(int amount)
        {
            cardsDealt.Clear();
            if (pack.Count == 0)
            {
                return null;
            }

            else if (pack.Count < amount)
            {
                return null;
            }

            else
            {
                for (int z = 0; z < amount; z++)
                {
                    Card firstCard = pack[0];
                    pack.RemoveAt(0);
                    cardsDealt.Add(firstCard);
                    firstCard.CardType();
                }
                return cardsDealt;
            }
        }

    }
}
