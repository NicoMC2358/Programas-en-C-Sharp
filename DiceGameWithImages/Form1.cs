using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGameWithImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(values())
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\nicom\source\repos\DiceGameWithImages\Dice Images\1.png";
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\nicom\source\repos\DiceGameWithImages\Dice Images\2.png";
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\nicom\source\repos\DiceGameWithImages\Dice Images\3.png";
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\nicom\source\repos\DiceGameWithImages\Dice Images\4.png";
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\nicom\source\repos\DiceGameWithImages\Dice Images\5.png";
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\nicom\source\repos\DiceGameWithImages\Dice Images\6.png";
                    break;
            }

        }
        private int values() 
        {
            Random rand = new Random();
            int random = rand.Next(1, 7);
            return random;
        }
    }
    //By NicoMC :D
}
