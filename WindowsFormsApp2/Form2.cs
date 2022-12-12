using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Random rand = new Random();
        string currentTurn;
        Color currentColor;
         

        Color colorX;
        Color colorO;
        string nameX;
        string nameO;

        public Form2(Color colorX, Color colorO, string nameX, string nameO)
        {
            InitializeComponent();
            this.colorX = colorX;
            this.colorO = colorO;
            this.nameX = nameX;
            this.nameO = nameO;

            int rng = rand.Next(1, 3);

            if (rng == 1)
            {
                currentTurn = "X";
                currentColor = colorX;
                PlayerName.Text = nameX;
                PlayerColor.BackColor = colorX;
            }
            else
            {
                currentTurn = "O";
                currentColor = colorO;
                PlayerName.Text = nameO;
                PlayerColor.BackColor = colorO;
            }

        }

        private void Socket_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!string.IsNullOrEmpty(btn.Text)) return;

            btn.Text = currentTurn;

            switch(currentTurn)
            {
                case "X":
                    btn.Text = currentTurn;
                    btn.ForeColor = currentColor;
                    currentTurn = "O";
                    currentColor = colorO;
                    PlayerName.Text = nameO;
                    PlayerColor.BackColor = colorO;
                    break;
                case "O":
                    btn.Text = currentTurn;
                    btn.ForeColor = currentColor;
                    currentTurn = "X";
                    currentColor = colorX;
                    PlayerName.Text = nameX;
                    PlayerColor.BackColor = colorX;
                    break;
            }

            // Check if win

            


                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                
            }

                for(int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                int controls = tableLayoutPanel1.Controls.Count;

                if()
            }
        }
    }
}
