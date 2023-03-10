using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Fields
        private int _value;
        private int _suit;

        public int Value
        {
            get { return _value; }
            set
            {
                //Exception Handling
                if (value < 1)
                {
                    throw new ArgumentException("The value of a card must be 1, or greater");
                }
                else if (value > 1)
                {
                    throw new ArgumentException("The value of a card must be 13, or less");
                }
                else
                {
                    _value = value;
                }
            }
        }
        public int Suit
        {
            get { return _suit; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The suit of a card must be 1, or greater");
                }
                else if (value > 4)
                {
                    throw new ArgumentException("The suit of a card must be 4, or less");
                }
                else
                {
                    _suit = value;
                }
            }
        }
        //Card Constructor
        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }
        //Methods
        //Each card has a specific type, made up of their value and suit
        public void cardType()
        {
            //Values ranging from 1-13
            var Values = new Dictionary<int, string>()
            {
                {1, "Ace"},
                {2, "2"},
                {3, "3"},
                {4, "4"},
                {5, "5"},
                {6, "6"},
                {7, "7"},
                {8, "8"},
                {9, "9"},
                {10, "10"},
                {11, "Jack"},
                {12, "Queen"},
                {13, "King"}
            };
            //Suits ranging from 1-4
            var Suits = new Dictionary<int, string>()
            {
                {1, "Clubs"},
                {2, "Diamonds"},
                {3, "Hearts"},
                {4, "Spades"}
            };
            Console.WriteLine($"{Values[Value]} of {Suits[Suit]}");
        }
    }
}
