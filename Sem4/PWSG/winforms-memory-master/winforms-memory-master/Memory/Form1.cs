using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    

    public partial class Form1 : Form
    {
        private int rows;
        private int columns;
        private Card[,] cards;
        private Card pickedCard;
        private Card secondPickedCard;
        private bool isEnabled = false;

        private int cardsMatched;
        private int totalCards;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartNewGame(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;

            
            ConstructGameTable(Card.PrepareCardValues(rows, columns));
        }

        private void ConstructGameTable(int[,] cardValues)
        {
            gameTable.Controls.Clear();
            gameTable.RowStyles.Clear();
            gameTable.ColumnStyles.Clear();

            gameTable.RowCount = rows;
            float rowHeightPercentage = 100 / rows;
            for (int row = 0; row < rows; row++)
                gameTable.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeightPercentage));


            float columnWidthPercentage = 100 / columns;
            gameTable.ColumnCount = columns;
            for (int column = 0; column < columns; column++)
                gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnWidthPercentage));


            cards = new Card[rows, columns];
            int cardWidth = gameTable.Size.Width / columns,
                cardHeight = gameTable.Size.Height / rows;
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                {
                    Card card = new Card(cardWidth, cardHeight, cardValues[row, column]);
                    cards[row, column] = card;
                    card.Click += HandleCardClick;
                    gameTable.Controls.Add(card.Button, column, row);
                }

            cardsMatched = 0;
            totalCards = rows * columns;
            isEnabled = true;
        }

        private void HandleCardClick(object sender, Card card)
        {
            if (!isEnabled)
                return;

            if (pickedCard != null)
            {
                if (pickedCard.Value == card.Value)
                {
                    // Match
                    pickedCard.Show();
                    card.Show();
                    pickedCard = null;
                    cardsMatched += 2;
                    CheckWinCondition();
                }
                else
                {
                    // No match
                    card.Peek();
                    isEnabled = false;
                    secondPickedCard = card;
                    hideCardsTimer.Enabled = true;
                }
            }
            else
            {
                pickedCard = card;
                card.Peek();
            }
        }

        public void CheckWinCondition()
        {
            if (cardsMatched == totalCards)
            {
                isEnabled = false;
                MessageBox.Show("Congratulations!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void gameTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStart2x2_Click(object sender, EventArgs e)
        {
            StartNewGame(2, 2);
        }

        private void menuStart4x4_Click(object sender, EventArgs e)
        {
            StartNewGame(4, 4);
        }

        private void menuStart6x6_Click(object sender, EventArgs e)
        {
            StartNewGame(6, 6);
        }

        private void menuStart8x8_Click(object sender, EventArgs e)
        {
            StartNewGame(8, 8);
        }

        private void menuStart10x10_Click(object sender, EventArgs e)
        {
            StartNewGame(10, 10);
        }

        private void hideCardsTimer_Tick(object sender, EventArgs e)
        {
            hideCardsTimer.Enabled = false;
            pickedCard.Hide();
            secondPickedCard.Hide();
            pickedCard = null;
            secondPickedCard = null;

            isEnabled = true;
        }
    }
}
