using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace GOMOKU_19001
{
    public partial class GameWindow : Form
    {

        Color Turn = Color.Red;
        int TurnCount = 0;
        bool computer;
        void changeTurn()
        {
            if (Turn == Color.Red)
                Turn = Color.Blue;
            else
                Turn = Color.Red;
        }

        Cell[,] grid;

        class Cell : Button{
            public Cell(int x, int y)
            {
                xpos = x;
                ypos = y;
            }
            public int xpos, ypos;
        }

        void LoadGrid()
        {
            gameGrid.Controls.Clear();
            grid = new Cell[dimension,dimension];
            Cell myCell;
            for(int ri = 0; ri < dimension; ri++)
            {
                for(int ci = 0; ci < dimension; ci++)
                {
                    myCell = new Cell(ci, ri);
                    myCell.Width = gameGrid.Width / dimension;
                    myCell.Height = gameGrid.Height/ dimension;
                    myCell.Margin = new Padding(0, 0, 0, 0);
                    myCell.BackColor = Color.Gray;
                    myCell.Click += new EventHandler(this.cell_Click);
                    gameGrid.Controls.Add(myCell);
                    grid[myCell.ypos, myCell.xpos] = myCell;
                }
            }
        }

        bool win(Cell thisCell, Color checkColor, int n = 0)
        {
            int winCount = this.winCount;
            winCount-=n;
            int dy, dx;
            int x, y;
            int count = 1;
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy = -1; dx = 1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0 
                & y < dimension && grid[y,x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy *= -1; dx *= -1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            if (count >= winCount)
                return true;

            count = 1;
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy = 0; dx = 1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy *= -1; dx *= -1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            if (count >= winCount)
                return true;

            count = 1;
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy = 1; dx = 1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy *= -1; dx *= -1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            if (count >= winCount)
                return true;

            count = 1;
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy = 1; dx = 0;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            x = thisCell.xpos;
            y = thisCell.ypos;
            dy *= -1; dx *= -1;
            x += dx; y += dy;
            while (x >= 0 && x < dimension && y >= 0
                & y < dimension && grid[y, x].BackColor == checkColor)
            {
                x += dx; y += dy;
                count++;
            }
            if (count >= winCount)
                return true;

            return false;
        }

        void cell_Click(object sender, EventArgs e)
        {
            Cell thisCell = (Cell)sender;
            if (grid[thisCell.ypos, thisCell.xpos].BackColor == Color.Gray)
            {
                thisCell.BackColor = Turn;
                TurnCount++;
                if (win(thisCell, Turn))
                {
                    if(computer)
                        MessageBox.Show("you have won");
                    else
                        MessageBox.Show(Turn + " has won");
                    TurnCount = 0;
                    blueHints = 0;
                    redHints = 0;
                    gameGrid.Controls.Clear();
                    return;
                }
                changeTurn();
                if (TurnCount == dimension * dimension)
                {
                    MessageBox.Show("Game is DRAW!");
                    TurnCount = 0;
                    blueHints = 0;
                    redHints = 0;
                    gameGrid.Controls.Clear();
                    return;
                }
            }
            else
            {
                return;
            }
            if (computer)
            {
                for(int i = 0; i < winCount; i++)
                {
                    for (int ri = 0; ri < dimension; ri++)
                    {
                        for (int ci = 0; ci < dimension; ci++)
                        {
                            if (grid[ri, ci].BackColor == Color.Gray
                                && win(grid[ri, ci], Turn, i))
                            {
                                grid[ri, ci].BackColor = Turn;
                                if (i == 0)
                                {
                                    MessageBox.Show("Computer has won");
                                    TurnCount = 0;
                                    blueHints = 0;
                                    redHints = 0;
                                    gameGrid.Controls.Clear();
                                    return;
                                }
                                TurnCount++;
                                if (TurnCount == dimension * dimension)
                                {
                                    MessageBox.Show("Game is DRAW!");
                                    TurnCount = 0;
                                    blueHints = 0;
                                    redHints = 0;
                                    gameGrid.Controls.Clear();
                                }
                                changeTurn();
                                return;
                            }
                        }
                    }
                    changeTurn();
                    for (int ri = 0; ri < dimension; ri++)
                    {
                        for (int ci = 0; ci < dimension; ci++)
                        {
                            if (grid[ri, ci].BackColor == Color.Gray
                                && win(grid[ri, ci], Turn, i))
                            {
                                changeTurn();
                                grid[ri, ci].BackColor = Turn;
                                TurnCount++;
                                if (TurnCount == dimension * dimension)
                                {
                                    MessageBox.Show("Game is DRAW!");
                                    TurnCount = 0;
                                    blueHints = 0;
                                    redHints = 0;
                                    gameGrid.Controls.Clear();
                                }
                                changeTurn();
                                return;
                            }
                        }
                    }
                    changeTurn();
                }
            }
        }
            
        int winCount = 0, dimension = 0;

        public GameWindow()
        {
            InitializeComponent();
        }

        int blueHints = 0, redHints = 0;
        private void HintButton_Click(object sender, EventArgs e)
        {
            if (Turn == Color.Blue)
            {
                if (blueHints == 3)
                    return;
                blueHints++;
            }
            else
            {
                if (redHints == 3)
                    return;
                redHints++;
            }
            for (int i = 0; i < winCount; i++)
            {
                for (int ri = 0; ri < dimension; ri++)
                {
                    for (int ci = 0; ci < dimension; ci++)
                    {
                        if (grid[ri, ci].BackColor == Color.Gray
                            && win(grid[ri, ci], Turn, i))
                        {
                            grid[ri, ci].BackColor = Color.Yellow;
                            MessageBox.Show("Your Hint");
                            grid[ri, ci].BackColor = Color.Gray;
                            return;
                        }
                    }
                }
                changeTurn();
                for (int ri = 0; ri < dimension; ri++)
                {
                    for (int ci = 0; ci < dimension; ci++)
                    {
                        if (grid[ri, ci].BackColor == Color.Gray
                            && win(grid[ri, ci], Turn, i))
                        {
                            grid[ri, ci].BackColor = Color.Yellow;
                            MessageBox.Show("Your Hint");
                            grid[ri, ci].BackColor = Color.Gray;
                            changeTurn();
                            return;
                        }
                    }
                }
                changeTurn();
            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            TurnCount = 0;
            dimension = 0;
            blueHints = 0;
            redHints = 0;
            if (dim3.Checked)
                dimension = 3;
            else if (dim5.Checked)
                dimension = 5;
            else if (dim8.Checked)
                dimension = 8;
            else if (dim10.Checked)
                dimension = 10;
            else if (dim12.Checked)
                dimension = 12;
            else
            {
                MessageBox.Show("Select a Grid Size");
                return;    
            }
            if(winCountBox.Text == "" ||
                (winCount = Int32.Parse(winCountBox.Text)) <= 2 || winCount > dimension)
            {
                MessageBox.Show("Incorrect Wincount");
                return;
            }
            computer = !TwoPlayer.Checked;
            LoadGrid();
        }
    }
}
