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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color colorX;
        Color colorO;
        string nameX;
        string nameY;


        private void ColorSelect_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Name)
            {
                case "ColorSelectX":
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    textColorX.BackColor = colorDialog1.Color;
                    colorX = colorDialog1.Color;
                    break;
                case "ColorSelectO":
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    textColorO.BackColor = colorDialog1.Color;
                    colorO = colorDialog1.Color;
                    break;
            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextboxX.Text) ||string.IsNullOrEmpty(TextboxO.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie wartości");
                return;
            }

            if(colorX == colorO)
            {
                MessageBox.Show("Kolory nie mogą być te same!");
                return;
            }

            nameX = TextboxX.Text;
            nameY = TextboxO.Text;

            Form2 form = new Form2(colorX, colorO, nameX, nameY);
            form.Show();
        }
    }
}
