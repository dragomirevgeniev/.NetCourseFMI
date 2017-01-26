using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Shuffle();
            deck.MakeHand();

            Console.WriteLine("Has a pair:" , deck.HasPair());
            Console.WriteLine("Has two pairs:", deck.Has2Pairs());
            Console.WriteLine("Has 3 of a kind:", deck.Has3OfAKind());
            Console.WriteLine("Has 4 of a kind:", deck.Has4OfAKind());
            Console.WriteLine("Has Straight:", deck.HasStraight());
            Console.WriteLine("Has Flush:", deck.HasFlush());
            Console.WriteLine("Has Full House:", deck.HasFullHouse());
        }
    }
}
