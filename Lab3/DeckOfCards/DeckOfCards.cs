// Fig. 8.10: DeckOfCards.cs
// DeckOfCards class represents a deck of playing cards.
using System;

namespace DeckOfCards
{
    public class DeckOfCards
    {
        private Card[] deck; // array of Card objects
        private int currentCard; // index of next Card to be dealt
        private const int NUMBER_OF_CARDS = 52; // constant number of Cards
        private Random randomNumbers; // random number generator
        private int[] faceCounters;
        private int[] suitCounters;
        private Card[] hand;

        // constructor fills deck of Cards
        public DeckOfCards()
        {
            faceCounters = new int[13];
            suitCounters = new int[4];
            hand = new Card[5];

            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six",
         "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            deck = new Card[NUMBER_OF_CARDS]; // create array of Card objects
            currentCard = 0; // set currentCard so deck[ 0 ] is dealt first  
            randomNumbers = new Random(); // create random number generator

            // populate deck with Card objects
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(count % 13, count / 13);
            }
        } // end DeckOfCards constructor

        public Card[] Hand { get; private set; }

        // shuffle deck of Cards with one-pass algorithm
        public void Shuffle()
        {
            // after shuffling, dealing should start at deck[ 0 ] again
            currentCard = 0; // reinitialize currentCard

            // for each Card, pick another random Card and swap them
            for (int first = 0; first < deck.Length; first++)
            {
                // select a random number between 0 and 51 
                int second = randomNumbers.Next(NUMBER_OF_CARDS);

                // swap current Card with randomly selected Card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            } // end for
        } // end method Shuffle

        public void MakeHand()
        {
            for (int i = 0; i < 5; i++)
            {
                hand[i] = DealCard();
            }

            MakeFaceStatistics();
            MakeSuitStatistics();
        }

        private void MakeFaceStatistics()
        {
            for (int i = 0; i < hand.Length; i++)
            {
                if (hand[i] != null)
                {
                    ++faceCounters[hand[i].Face];
                }
            }

            foreach (var item in faceCounters)
            {
                Console.WriteLine(item);
            }
        } // ?
        private void MakeSuitStatistics()
        {
            for (int i = 0; i < hand.Length; i++)
            {
                if (hand[i] != null)
                {
                    ++suitCounters[hand[i].Suit];
                }
            }
        } // ?

        public bool HasPair()
        {
            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (faceCounters[i] == 2)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Has3OfAKind()
        {
            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (faceCounters[i] == 3)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Has4OfAKind()
        {
            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (faceCounters[i] == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Has2Pairs()
        {
            int firstPairIndex = -1;
            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (faceCounters[i] == 2)
                {
                    firstPairIndex = i;
                }
            }

            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (faceCounters[i] == 2 && i != firstPairIndex)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasFlush()
        {
            for (int i = 0; i < suitCounters.Length; i++)
            {
                if (suitCounters[i] == 5)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasStraight()
        {
            int numberOfSequentCards = 1;
            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                else if (faceCounters[i] == faceCounters[i-1])
                {
                    numberOfSequentCards++;
                }
            }

            if (numberOfSequentCards == 5)
            {
                return true;
            }

            return false;    
        }

        public bool HasFullHouse()
        {
            int firstPairIndex = -1;
            int firstPairNumber = -1;
            for (int i = 0; i < faceCounters.Length; i++)
            {
                if (faceCounters[i] == 2 || faceCounters[i] == 3)
                {
                    firstPairIndex = i;
                    firstPairNumber = faceCounters[i];
                }
            }

            for (int i = 0; i < faceCounters.Length; i++)
            {
                if ((faceCounters[i] == 2 || faceCounters[i] == 3) && (i != firstPairIndex && firstPairNumber != faceCounters[i]))
                {
                    return true;
                }
            }

            return false;
        }
        // deal one Card
        public Card DealCard()
        {
            // determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard++]; // return current Card in array
            }
            else return null; // indicate that all Cards were dealt
        } // end method DealCard
    } // end class DeckOfCards
}

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
