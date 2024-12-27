using System;
using System.Drawing;
using TriPeaks.CustomControls;

namespace TriPeaks.GameLib
{
    /// <summary>
    /// This class creates all 52 difirent suites for solitaire games
    /// </summary>
    public class Shuffler
    {
        #region Fields & Propertys

        private int[][] suits;
        private int cSuits;
        public int CSuits { get => cSuits; }

        #endregion

        //constructor
        public Shuffler()
        {
            MakeNewDeal();
        }

        #region class methods

        /// <summary>
        /// setup a new deal by regenerate arrays
        /// </summary>
        public void MakeNewDeal()
        {
            //index 14 shows remains suits
            // index 12 shows remains numbers
            suits = new int[4][];
            suits[0] = new int[15];
            suits[1] = new int[15];
            suits[2] = new int[15];
            suits[3] = new int[15];
            cSuits = 3;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    suits[i][j] = j + 1;
                }
                suits[i][13] = 12;
                suits[i][14] = i;
            }
        }

        /// <summary>
        /// return a random unique suite
        /// </summary>
        /// <returns>random unique suite</returns>
        public CardSuits Shuffle()
        {

            Random rand = new Random();
            CardSuits output = new CardSuits();

            int suit = rand.Next(0, cSuits); //suit catagory index
            int index = rand.Next(0, suits[suit][13]); //suit number index


            int value = suits[suit][index]; //suit number
            suits[suit][index] = suits[suit][suits[suit][13]--]; //put the number in last index to current index and reduce the lenght

            if (suits[suit][13] == -1) //if all numbers in suits is chosen so ignore the suite
                suits[suit] = suits[cSuits--];

            //create suits
            if (value > 1 && value < 11)
            {
                output.suitsLabel = value.ToString();
            }
            else if (value == 1)
            {
                output.suitsLabel = "A";
            }
            else if (value == 11)
            {
                output.suitsLabel = "J";

                if (suits[suit][14] == 0 || suits[suit][14] == 1)
                    output.suitsImage = global::TriPeaks.Properties.Resources.RedJack;
                else
                    output.suitsImage = global::TriPeaks.Properties.Resources.BlackJack;
            }
            else if (value == 12)
            {
                output.suitsLabel = "Q";

                if (suits[suit][14] == 0 || suits[suit][14] == 1)
                    output.suitsImage = global::TriPeaks.Properties.Resources.RedQueen;
                else
                    output.suitsImage = global::TriPeaks.Properties.Resources.BlackQueen;
            }
            else if (value == 13)
            {
                output.suitsLabel = "K";

                if (suits[suit][14] == 0 || suits[suit][14] == 1)
                    output.suitsImage = global::TriPeaks.Properties.Resources.RedKing;
                else
                    output.suitsImage = global::TriPeaks.Properties.Resources.BlackKing;
            }

            if (suits[suit][14] == 0)
            {
                if (value < 11)
                    output.suitsImage = global::TriPeaks.Properties.Resources.HeartSuit;

                output.suitsColor = Color.Red;
            }
            else if (suits[suit][14] == 1)
            {
                if (value < 11)
                    output.suitsImage = global::TriPeaks.Properties.Resources.DiamondSuit;

                output.suitsColor = Color.Red;
            }
            else if (suits[suit][14] == 2)
            {
                if (value < 11)
                    output.suitsImage = global::TriPeaks.Properties.Resources.SpadesSuit;

                output.suitsColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(22)))), ((int)(((byte)(20)))));
            }
            else if (suits[suit][14] == 3)
            {
                if (value < 11)
                    output.suitsImage = global::TriPeaks.Properties.Resources.ClubsSuit;

                output.suitsColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(22)))), ((int)(((byte)(20)))));
            }


            output.value = value;

            return output;
        }
        #endregion
    }
}
