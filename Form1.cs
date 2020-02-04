using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFreriksAssignment3
{
    public partial class TicTacToe : Form
    {
        private bool isX = true;
        private Bitmap currentTile;
        private string currentTag;
        private Bitmap x = CFreriksAssignment3.Properties.Resources.X;
        private Bitmap o = CFreriksAssignment3.Properties.Resources.O;
        private PictureBox[,] Grid;
        private int tileplayed = 0;

        public TicTacToe()
        {
            Grid = new PictureBox[3, 3];
            currentTile = x;
            currentTag = "x";
            InitializeComponent();
            CollectPictureBoxes();
        }

        private void CollectPictureBoxes()
        {
            Grid[0, 0] = pictureBox1;
            Grid[0, 1] = pictureBox2;
            Grid[0, 2] = pictureBox3;

            Grid[1, 0] = pictureBox4;
            Grid[1, 1] = pictureBox5;
            Grid[1, 2] = pictureBox6;

            Grid[2, 0] = pictureBox7;
            Grid[2, 1] = pictureBox8;
            Grid[2, 2] = pictureBox9;
        }

        private void ChangeTile(object Obj, EventArgs e)
        {
            PictureBox ClickedBox = (PictureBox)Obj;
            if(ClickedBox.Tag == "empty" && isX == true)
            {     
                ClickedBox.Image = x;
                ClickedBox.Tag = currentTag;
                currentTag = "o";
                currentTile = o;
                isX = false;
                tileplayed++;
            }
            else if(ClickedBox.Tag == "empty" && isX == false)
            {
                ClickedBox.Image = o;
                ClickedBox.Tag = currentTag;
                currentTag = "x";
                currentTile = x;
                isX = true;
                tileplayed++;
            }

            CollectPictureBoxes();
            HaveWon();
        }

        private void XWin()
        {
            MessageBox.Show("X WON!", "X WINS GAME!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            reset();
        }

        private void OWin()
        {
            MessageBox.Show("O WON!", "O WINS GAME!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            reset();
        }

        private void reset()
        {
            foreach(PictureBox box in GridCollections.Controls)
            {
                
                box.Image = null;
                box.Tag = "empty";
            }
            isX = true;
            currentTag = "x";
            currentTile = x;
            tileplayed = 0;
            CollectPictureBoxes();
        }

        private void HaveWon()
        {
            if(Grid[0,0].Tag == "x" && Grid[0,1].Tag == "x" && Grid[0,2].Tag == "x")
            {
                XWin();
            }
            else if (Grid[1, 0].Tag == "x" && Grid[1, 1].Tag == "x" && Grid[1, 2].Tag == "x")
            {
                XWin();
            }
            else if (Grid[2, 0].Tag == "x" && Grid[2, 1].Tag == "x" && Grid[2, 2].Tag == "x")
            {
                XWin();
            }
            else if (Grid[0, 0].Tag == "x" && Grid[1, 1].Tag == "x" && Grid[2, 2].Tag == "x")
            {
                XWin();
            }
            else if (Grid[0, 2].Tag == "x" && Grid[1, 1].Tag == "x" && Grid[2, 0].Tag == "x")
            {
                XWin();
            }
            else if (Grid[0, 0].Tag == "x" && Grid[1, 0].Tag == "x" && Grid[2, 0].Tag == "x")
            {
                XWin();
            }
            else if (Grid[0, 1].Tag == "x" && Grid[1,1].Tag == "x" && Grid[2, 1].Tag == "x")
            {
                XWin();
            }
            else if (Grid[0, 2].Tag == "x" && Grid[1, 2].Tag == "x" && Grid[2, 2].Tag == "x")
            {
                XWin();
            }

            if (Grid[0, 0].Tag == "o" && Grid[0, 1].Tag == "o" && Grid[0, 2].Tag == "o")
            {
                OWin();
            }
            else if (Grid[1, 0].Tag == "o" && Grid[1, 1].Tag == "o" && Grid[1, 2].Tag == "o")
            {
                OWin();
            }
            else if (Grid[2, 0].Tag == "o" && Grid[2, 1].Tag == "o" && Grid[2, 2].Tag == "o")
            {
                OWin();
            }
            else if (Grid[0, 0].Tag == "o" && Grid[1, 1].Tag == "o" && Grid[2, 2].Tag == "o")
            {
                OWin();
            }
            else if (Grid[0, 2].Tag == "o" && Grid[1, 1].Tag == "o" && Grid[2, 0].Tag == "o")
            {
                OWin();
            }
            else if (Grid[0, 0].Tag == "o" && Grid[1, 0].Tag == "o" && Grid[2, 0].Tag == "o")
            {
                OWin();
            }
            else if (Grid[0, 1].Tag == "o" && Grid[1, 1].Tag == "o" && Grid[2, 1].Tag == "o")
            {
                OWin();
            }
            else if (Grid[0, 2].Tag == "o" && Grid[1, 2].Tag == "o" && Grid[2, 2].Tag == "o")
            {
                OWin();
            }

            if(tileplayed == 9)
            {
                MessageBox.Show("TIED", "GAME TIED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reset();
            }
        }
    }
}
