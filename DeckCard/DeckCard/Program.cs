using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCard
{
     class Program
    {
       
             
        static void Main(string[] args)
        {
            List<string> clubs = Cards("Clubs");
            List<string> diamonds = Cards("Diamond");
            List<string> hearts = Cards("Heart");
            List<string> spades = Cards("Spade");

            List<string> deck=clubs.Concat(diamonds).Concat(hearts).Concat(spades).ToList();
            //deck.ForEach(i => Console.WriteLine(i));

            //creating players
            string[] players = new string[4] { "peter", "Mike", "Rose", "Anna" };

            //getting card from deck
            Random random = new Random();

            foreach (string player in players)
            {
                Console.WriteLine(player);

                Console.ForegroundColor = ConsoleColor.Cyan;
                int card1_index = random.Next(deck.Count);
                string card1 = deck[card1_index];
                deck.Remove(card1);

                int card2_index = random.Next(deck.Count);
                string card2 = deck[card2_index];
                deck.Remove(card2);

                int card3_index = random.Next(deck.Count);
                string card3 = deck[card3_index];
                deck.Remove(card3);

                int card4_index = random.Next(deck.Count);
                string card4 = deck[card4_index];
                deck.Remove(card4);

                int card5_index = random.Next(deck.Count);
                string card5 = deck[card5_index];
                deck.Remove(card5);
                int card6_index = random.Next(deck.Count);
                string card6 = deck[card6_index];
                deck.Remove(card6);
                int card7_index = random.Next(deck.Count);
                string card7 = deck[card7_index];
                deck.Remove(card7);
                int card8_index = random.Next(deck.Count);
                string card8 = deck[card8_index];
                deck.Remove(card8);
                int card9_index = random.Next(deck.Count);
                string card9 = deck[card9_index];
                deck.Remove(card9);

                Console.WriteLine(card1);
                Console.WriteLine(card2);
                Console.WriteLine(card3);
                Console.WriteLine(card4);
                Console.WriteLine(card5);
                Console.WriteLine(card6);
                Console.WriteLine(card7);
                Console.WriteLine(card8);
                Console.WriteLine(card9);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static List<string> Cards(string symbol)
        {
            List<string> cards = new List<string>();
            for(int i=2;i<11;i++)
            {
                cards.Add(symbol+ " "+i);
            }
            cards.Add(symbol + " " + "jack");
            cards.Add(symbol + " " + "Queen");
            cards.Add(symbol + " " + "King");
            cards.Add(symbol + " " + "Ace");
            return cards;
        }
    }
}
