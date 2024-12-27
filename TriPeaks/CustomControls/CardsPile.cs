using System;
using System.Collections.Generic;
using System.Drawing;


namespace TriPeaks.CustomControls
{
    //Declare a delegate for events.
    public delegate void EventDelegate(Object sender, EventArgs e);

    /// <summary>
    /// this class implement a custom controler to visualize card piles
    /// </summary>
    public class CardsPile : PlayingCard
    {
        #region Fields
        public event EventDelegate PileIsEmpty; ////Delcare the event that called when pile is empty.

        private Color borderColorHolderState;
        private Color borderColorEmptyState;
        private Color foreColorHolderState;
        private Color foreColorEmptyState;
        private Stack<CardSuits> stock; //store card suits

        #endregion

        #region Propertys
        public int Count => stock.Count;

        public Color BorderColorHolderState { get => borderColorHolderState; set => borderColorHolderState = value; }
        public Color HolderStateForeColor { get => foreColorHolderState; set => foreColorHolderState = value; }
        public Color BorderColorEmptyState { get => borderColorEmptyState; set => borderColorEmptyState = value; }
        public Color ForeColorEmptyState { get => foreColorEmptyState; set => foreColorEmptyState = value; }

        #endregion

        //Constructor
        public CardsPile()
        {
            stock = new Stack<CardSuits>();
            this.Size = new Size(86, 116);
            this.BorderColor = this.borderColorEmptyState;
            this.ForeColor = this.foreColorEmptyState;
            Empty();
        }

        #region Class Methods

        public CardSuits PeekCard() => stock.Peek();

        public void PushCard(PlayingCard card)
        {
            this.PushCard(card.Suits);
        }

        public void PushCard(CardSuits suits)
        {
            stock.Push(suits);

            this.BorderColor = borderColorHolderState;
            this.ForeColor = foreColorHolderState;

            UpdateTop();
        }

        public CardSuits PopCard()
        {
            CardSuits temp;

            if (stock.Count > 0)
            {
                temp = stock.Pop();
                UpdateTop();
            }
            else throw new Exception("stack is empty.");

            return temp;
        }

        public void Clear()
        {
            stock.Clear();
            this.SuitsImage = null;
            this.SuitsLabel = null;
            this.BorderColor = borderColorEmptyState;
            this.ForeColor = foreColorEmptyState;
        }

        public void UpdateTop()
        {
            this.Controls.Clear();

            if (Count > 0)
            {
                CardSuits temp = this.stock.Peek();
                this.SuitsColor = temp.suitsColor;
                this.SuitsLabel = temp.suitsLabel;
                this.SuitsImage = temp.suitsImage;
                this.Value = temp.value;
            }
            else
            {
                Empty();
            }
        }

        private void Empty()
        {
            this.SuitsImage = null;
            this.SuitsLabel = null;
            this.BorderColor = borderColorEmptyState;
            this.ForeColor = foreColorEmptyState;
            PileIsEmpty?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
