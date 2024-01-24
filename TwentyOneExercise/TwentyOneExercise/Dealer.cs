using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneExercise
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\OneDrive\Desktop\Basic_C#_Programs\TwentyOneExercise\TwentyOneExercise\TextFile1.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
                file.Flush();
                file.Close();
            }
            Deck.Cards.RemoveAt(0);
            }
            public void ResetDeck()
            {
                Deck = new Deck();
                Deck.Shuffle();
            }


              
    }
}
