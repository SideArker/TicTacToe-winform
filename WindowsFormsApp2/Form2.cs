using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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


        void CheckForWin()
        {
            if (Socket1.Text == "X" && Socket2.Text == "X" && Socket3.Text == "X" ||
                Socket4.Text == "X" && Socket5.Text == "X" && Socket6.Text == "X" ||
                Socket7.Text == "X" && Socket8.Text == "X" && Socket9.Text == "X" ||
                Socket1.Text == "X" && Socket4.Text == "X" && Socket7.Text == "X" ||
                Socket2.Text == "X" && Socket5.Text == "X" && Socket8.Text == "X" ||
                Socket3.Text == "X" && Socket6.Text == "X" && Socket9.Text == "X" ||
                Socket1.Text == "X" && Socket5.Text == "X" && Socket9.Text == "X" ||
                Socket7.Text == "X" && Socket5.Text == "X" && Socket3.Text == "X")
            {
                MessageBox.Show($"Koniec Gry. Wygrał {nameX}");
                clearArena();
            }
            else if (Socket1.Text == "O" && Socket2.Text == "O" && Socket3.Text == "O" ||
                Socket4.Text == "O" && Socket5.Text == "O" && Socket6.Text == "O" ||
                Socket7.Text == "O" && Socket8.Text == "O" && Socket9.Text == "O" ||
                Socket1.Text == "O" && Socket4.Text == "O" && Socket7.Text == "O" ||
                Socket2.Text == "O" && Socket5.Text == "O" && Socket8.Text == "O" ||
                Socket3.Text == "O" && Socket6.Text == "O" && Socket9.Text == "O" ||
                Socket1.Text == "O" && Socket5.Text == "O" && Socket9.Text == "O" ||
                Socket7.Text == "O" && Socket5.Text == "O" && Socket3.Text == "O")
            {
                MessageBox.Show($"Koniec Gry. Wygrał {nameO}");
                clearArena();
            }
        }


        void clearArena()
        {
            foreach (var element in tableLayoutPanel1.Controls)
            {
                if (element is Button)
                {
                    Button btn = (Button)element;

                    btn.Text = "";
                    btn.ForeColor = Color.Black;
                }
            }
        }


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

                switch (currentTurn)
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
                CheckForWin();

            }
        }
    }
