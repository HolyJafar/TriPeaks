using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TriPeaks.GameLib;
using TriPeaks.CustomControls;
using System.Threading;
using System.Diagnostics;

namespace TriPeaks
{
    /// <summary>
    /// this form added as child form to MainForm
    /// the game is running in this form
    /// </summary>
    public partial class BoardForm : Form
    {
        #region class fields

        private DirectionalGraph BoardGraph; //Stores cards inside the board. connection 
        private Stack<Vertex> undos; //store user moves
        private List<PlayingCard> hints; //when hint button is clicked user posible moves stored in this list
        private int score;
        private int board; //Represents board numbers that solved
        private int hands; //presents how many can times user can restock the pile

        #endregion

        //constructor
        public BoardForm()
        {
            this.hints = new List<PlayingCard>();
            this.TopLevel = false;
            this.hands = 0; //this feature is disable. 
            this.score = 0;
            this.board = -1;
            InitializeComponent();
            InitializeCards();
            NewGame();
        }

        #region class methods

        /// <summary>
        /// setup a new game
        /// </summary>
        private void NewGame()
        {
            undos = new Stack<Vertex>();
            DealCards();
            InitializeGraphEdges();
            UpdateScore(0);
            this.lblBoard.Text = "Board: " + ++board;
        }

        #region Deal Board

        /// <summary>
        /// Give random suites to the cards and Piles
        /// </summary>
        public void DealCards()
        {
            Shuffler deal = new Shuffler();

            this.BoardGraph = new DirectionalGraph(29);

            this.BoardGraph.AddVertex(3); //first vertex in graph is a start point for BST search and Specify the end point of the cards inside the board.

            //shuffling cards and add them to graph
            foreach (Control i in this.pnlBoard.Controls)
            {
                if (i is PlayingCard && !(i is CardsPile))
                {
                    
                    PlayingCard temp = i as PlayingCard;
                    temp.Filp = false;
                    temp.Suits = deal.Shuffle();
                    temp.Visible = true;
                    this.BoardGraph.AddVertex(temp);
                    
                }
            }

            playingCard28.Filp = true;
            playingCard27.Filp = true;
            playingCard26.Filp = true;
            playingCard25.Filp = true;
            playingCard24.Filp = true;
            playingCard23.Filp = true;
            playingCard22.Filp = true;
            playingCard21.Filp = true;
            playingCard20.Filp = true;
            playingCard19.Filp = true;

            this.cardsPileStock.Clear();

            //shuffling stock pile
            for (int i = 0; i < 24; i++)
                this.cardsPileStock.PushCard(deal.Shuffle());

            this.cardsPileWaste.Clear();
            this.cardsPileWaste.PushCard(this.cardsPileStock.PopCard());
        }

        /// <summary>
        /// Add Graph Edges
        /// </summary>
        public void InitializeGraphEdges()
        {
            //Vertex 0 Edges
            this.BoardGraph.AddEdge(3, this.playingCard1);
            this.BoardGraph.AddEdge(3, this.playingCard2);
            this.BoardGraph.AddEdge(3, this.playingCard3);

            //Card1 Edges
            this.BoardGraph.AddEdge(this.playingCard1, this.playingCard4);
            this.BoardGraph.AddEdge(this.playingCard1, this.playingCard5);

            //Card2 Edges
            this.BoardGraph.AddEdge(this.playingCard2, this.playingCard6);
            this.BoardGraph.AddEdge(this.playingCard2, this.playingCard7);

            //Card3 Edges
            this.BoardGraph.AddEdge(this.playingCard3, this.playingCard8);
            this.BoardGraph.AddEdge(this.playingCard3, this.playingCard9);

            //Card4 Edges
            this.BoardGraph.AddEdge(this.playingCard4, this.playingCard10);
            this.BoardGraph.AddEdge(this.playingCard4, this.playingCard11);

            //Card5 Edges
            this.BoardGraph.AddEdge(this.playingCard5, this.playingCard11);
            this.BoardGraph.AddEdge(this.playingCard5, this.playingCard12);

            //Card6 Edges
            this.BoardGraph.AddEdge(this.playingCard6, this.playingCard13);
            this.BoardGraph.AddEdge(this.playingCard6, this.playingCard14);

            //Card7 Edges
            this.BoardGraph.AddEdge(this.playingCard7, this.playingCard14);
            this.BoardGraph.AddEdge(this.playingCard7, this.playingCard15);

            //Card8 Edges
            this.BoardGraph.AddEdge(this.playingCard8, this.playingCard16);
            this.BoardGraph.AddEdge(this.playingCard8, this.playingCard17);

            //Card9 Edges
            this.BoardGraph.AddEdge(this.playingCard9, this.playingCard17);
            this.BoardGraph.AddEdge(this.playingCard9, this.playingCard18);

            //Card10 Edges
            this.BoardGraph.AddEdge(this.playingCard10, this.playingCard19);
            this.BoardGraph.AddEdge(this.playingCard10, this.playingCard20);

            //Card11 Edges
            this.BoardGraph.AddEdge(this.playingCard11, this.playingCard20);
            this.BoardGraph.AddEdge(this.playingCard11, this.playingCard21);

            //Card12 Edges
            this.BoardGraph.AddEdge(this.playingCard12, this.playingCard21);
            this.BoardGraph.AddEdge(this.playingCard12, this.playingCard22);

            //Card13 Edges
            this.BoardGraph.AddEdge(this.playingCard13, this.playingCard22);
            this.BoardGraph.AddEdge(this.playingCard13, this.playingCard23);

            //Card14 Edges
            this.BoardGraph.AddEdge(this.playingCard14, this.playingCard23);
            this.BoardGraph.AddEdge(this.playingCard14, this.playingCard24);

            //Card15 Edges
            this.BoardGraph.AddEdge(this.playingCard15, this.playingCard24);
            this.BoardGraph.AddEdge(this.playingCard15, this.playingCard25);

            //Card16 Edges
            this.BoardGraph.AddEdge(this.playingCard16, this.playingCard25);
            this.BoardGraph.AddEdge(this.playingCard16, this.playingCard26);

            //Card17 Edges
            this.BoardGraph.AddEdge(this.playingCard17, this.playingCard26);
            this.BoardGraph.AddEdge(this.playingCard17, this.playingCard27);

            //Card18 Edges
            this.BoardGraph.AddEdge(this.playingCard18, this.playingCard27);
            this.BoardGraph.AddEdge(this.playingCard18, this.playingCard28);

            this.BoardGraph.AdjacentChange += new GameLib.EventDelegate(BoardGraph_AdjacentChange);
        }

        #endregion

        /// <summary>
        /// update int score and lblScore
        /// </summary>
        /// <param name="n">n is new value to add total score</param>
        private void UpdateScore(int n)
        {
            this.score += n;
            this.lblScore.Text = "Score: " + score;
        }

        /// <summary>
        /// this method return a bool value represent if any move left 
        /// </summary>
        /// <returns>true if there is a move and false if there isnt</returns>
        private bool IsThereAnyMove()
        {
            bool ThereIsMoves = false;

            //check board cards
            foreach (PlayingCard i in this.pnlBoard.Controls)
                if (i.Visible && i.Filp)
                {
                    if (Math.Abs(i.Value - cardsPileWaste.Value) == 1)
                    {
                        ThereIsMoves = true;
                        break;
                    }
                    else if (i.Value == 13 || cardsPileWaste.Value == 13)
                        if (i.Value == 1 || cardsPileWaste.Value == 1)
                        {
                            ThereIsMoves = true;
                            break;
                        }
                }

            //check the pile 
            if (cardsPileStock.Count > 0 || hands > 0)
                ThereIsMoves = true;

            return ThereIsMoves;
        }

        /// <summary>
        /// adjast all components that marked by hints list to default colors
        /// </summary>
        private void DisposeHints()
        {
            foreach (PlayingCard i in hints)
                i.BorderColor = Color.White;

            hints.Clear();
        }

        /// <summary>
        /// store new score in sorted string colloction 
        /// the string colloction saved in apllication default settings properties.
        /// </summary>
        private void SaveHighScores()
        {
            //score<0 are not saved
            if (score <= 0)
            {
                return;
            }

            int i = Properties.Settings.Default.HighScores.Count - 1; //represent new score index in Highscores StringCollection

            while (i >= 0) //find score proper index
            {
                if (Int32.Parse(Properties.Settings.Default.HighScores[i]) > score)
                {
                    break;
                }
                else if (Int32.Parse(Properties.Settings.Default.HighScores[i]) == score)
                {
                    return;
                }
                else
                    i--;
            }

            i++;


            if (Properties.Settings.Default.HighScores.Count <= 7) //grow collection if its possible
                Properties.Settings.Default.HighScores.Add("");


            if (i >= Properties.Settings.Default.HighScores.Count) //check the capacity
                return;


            //shifing data
            for (int x = Properties.Settings.Default.HighScores.Count - 1; x > i; x--)
            {
                Properties.Settings.Default.HighScores[x] = Properties.Settings.Default.HighScores[x - 1];
            }

            //place score in proper index
            Properties.Settings.Default.HighScores[i] = score + "";

            //save the new collection
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        /// <summary>
        /// popup endgame dialog box 
        /// </summary>
        public void EndGame()
        {
            GameDialog dialog = new GameDialog("No More Move!\nYour Score: " + score, true); //The user is asked wants to undo the last move
            dialog.BtnYesText = "Accept";
            dialog.BtnNoText = "Undo last";
            dialog.ShowDialog();

            //if answer is yes so the game is about to end
            if (dialog.Result)
            {
                SaveHighScores();
                MainForm a = this.Parent as MainForm;
                a.SetChildForm(new HighScoresForm());
                a.Controls.Remove(this);
            }
            //ohterwise game could be continue
            else
            {
                BtnUndo_Click(new object(), new EventArgs());
            }
        }

        #endregion

        #region  Buttons hover effect
        /// <summary>
        /// this method called by mouse enter event. used by all buttons.
        /// </summary>
        /// <param name="sender">sender could be any button</param>
        private void Btns_MouseEnter(object sender, EventArgs e)
        {
            Button temp = sender as Button;

            if (temp.Name == "btnExitLevel")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.Exit_State2;
            else if (temp.Name == "btnUndo")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.Undo_State2;
            else if (temp.Name == "ReStock")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.ReStock_State2;
            else if (temp.Name == "btnHint")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.Hint_State2;
        }

        /// <summary>
        /// this method called by mouse leve event. used by all buttons.
        /// </summary>
        /// <param name="sender">sender could be any button</param>
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button temp = sender as Button;

            if (temp.Name == "btnExitLevel")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.Exit;
            else if (temp.Name == "btnUndo")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.Undo;
            else if (temp.Name == "btnReStock")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.ReStock;
            else if (temp.Name == "btnHint")
                temp.BackgroundImage = global::TriPeaks.Properties.Resources.Hint;
        }
        #endregion

        #region Click Events Methods

        /// <summary>
        /// exit the game
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DisposeHints();

            GameDialog dialog = new GameDialog("Do you want to finish the game?\nYour Score: "+score, true);
            dialog.ShowDialog();

            if (dialog.Result)
            {
                SaveHighScores();
                MainForm a = this.Parent as MainForm;
                a.SetChildForm(new HighScoresForm());
                a.Controls.Remove(this);
            }
        }

        /// <summary>
        /// when stock pile clicked tihs method called by event controler 
        /// and push a card form stock pile to waste pile.
        /// </summary>
        private void CardsPileStock_Click(object sender, EventArgs e)
        {
            DisposeHints();

            if (cardsPileStock.Count > 0)
            {
                this.cardsPileWaste.PushCard(this.cardsPileStock.PopCard());
                undos.Push(null);
            }
        }

        /// <summary>
        /// when a card form board cliced event controler calls thid method
        /// and push the card to waste pille if it have conditions.
        /// </summary>
        /// <param name="sender">sender could be any PlayingCard from board</param>
        /// <param name="e">click event</param>
        private void PlayingCards_Click(object sender, EventArgs e)
        {
            DisposeHints();

            PlayingCard clicked = sender as PlayingCard;

            bool condition = false;

            if (Math.Abs(clicked.Value - cardsPileWaste.Value) == 1)
                condition = true;

            else if (clicked.Value == 13 || cardsPileWaste.Value == 13) // check king and ace
                if (clicked.Value == 1 || cardsPileWaste.Value == 1)
                    condition = true;


            if (condition && clicked.Filp) //push card suits to pile and hide it.
            {
                clicked.Visible = false;
                undos.Push(BoardGraph.Find(clicked));
                this.BoardGraph.RemoveVertex(clicked);
                this.cardsPileWaste.PushCard(clicked);
                UpdateScore(10);
            }

            if (!IsThereAnyMove()) //after push the card to pile if there is no move left then game is over
                EndGame();
        }

        /// <summary>
        /// undo user last move
        /// </summary>
        /// <param name="sender">sender is btnUndo</param>
        /// <param name="e">click event</param>
        private void BtnUndo_Click(object sender, EventArgs e)
        {
            DisposeHints();

            if (undos.Count > 0)
            {
                btnReStock.Visible = false;
                UpdateScore(-1);

                if (undos.Peek() != null) //undo moves that come from board to waste pile
                {
                    this.cardsPileWaste.PopCard();
                    this.BoardGraph.AddVertex(undos.Peek());
                    PlayingCard temp = undos.Pop().Value as PlayingCard;
                    temp.Visible = true;
                    UpdateScore(-10);
                }
                else //undo moves that come from stock pile to waste pile
                {
                    this.cardsPileStock.PushCard(this.cardsPileWaste.PopCard());
                    undos.Pop();
                }
            }
        }

        /// <summary>
        /// highlight the cards that could be moved
        /// </summary>
        /// <param name="sender">btnHint</param>
        /// <param name="e">click event</param>
        private void BtnHint_Click(object sender, EventArgs e)
        {
            bool isAnOption = false;

            //check board cards
            foreach (PlayingCard i in this.pnlBoard.Controls)
            {
                if (i.Visible && i.Filp)
                {
                    bool condition = false;

                    if (Math.Abs(i.Value - cardsPileWaste.Value) == 1)
                        condition = true;

                    else if (i.Value == 13 || cardsPileWaste.Value == 13)
                        if (i.Value == 1 || cardsPileWaste.Value == 1)
                            condition = true;


                    if (condition && i.Filp) //highlight card
                    {
                        isAnOption = true;
                        i.BorderColor = Color.Yellow;
                        hints.Add(i);
                    }
                }
            }

            if (!isAnOption && cardsPileStock.Count > 0)//check stock pile
            {
                cardsPileStock.BorderColor = Color.Yellow;
                hints.Add(cardsPileStock);
            }

        }

        /// <summary>
        /// restock the stock pile
        /// </summary>
        /// <param name="sender">btnReStock</param>
        /// <param name="e">click event</param>
        private void BtnReStock_Click(object sender, EventArgs e)
        {
            DisposeHints();

            NewGame();

            hands--;

            this.btnReStock.Visible = false;
        }

        #endregion

        #region other event Methods

        /// <summary>
        /// this method calls when graph vertexes adjacency changed
        /// and check the condition then flip the vertex card
        /// </summary>
        /// <param name="sender">BoardGraph</param>
        /// <param name="e">adjacency changed</param>
        private void BoardGraph_AdjacentChange(Vertex sender, EventArgs e)
        {
            if (sender.AdjacentChilds.Count == 0)
            {

                if (sender.Value is PlayingCard) //if card node child numbers is 0 so should be fliped
                {
                    PlayingCard temp = sender.Value as PlayingCard;
                    temp.Filp = true;
                }
                else if (sender.Value is int) //if first node chileds number is 0 then board is cleard
                {
                    UpdateScore(50);
                    NewGame();
                }
            }
            else if (sender.AdjacentChilds.Count > 0 && sender.Value is PlayingCard) //filp card to back side when card node have chiled
            {
                PlayingCard temp = sender.Value as PlayingCard;
                temp.Filp = false;
            }
            else if (sender.Value is int)// if first node adjacency changed then one peak is cleared
            {
                int temp = int.Parse(sender.Value.ToString());

                if (temp > 0)
                {
                    UpdateScore(5);
                    sender.Value = temp;
                }
            }

        }

        /// <summary>
        /// this method called when stock pile is empty
        /// and call EndGame method if its final round and there is no move left
        /// </summary>
        /// <param name="sender">CardPileStock</param>
        /// <param name="e">empty pile event</param>
        private void CardsPileStockIsEmpty(object sender, EventArgs e)
        {
            if (!IsThereAnyMove())
                EndGame();

            else if (hands > 0)
                this.btnReStock.Visible = true;

        }

        #endregion
    }

}
