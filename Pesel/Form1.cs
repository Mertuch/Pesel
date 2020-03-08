using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap MyImageNieok = new Bitmap("nieok.png");
        private Bitmap MyImageOk = new Bitmap("ok.png");


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text!="")
            {
                if (textBox1.Text.Length == 11)
                {
                    int suma = (textBox1.Text[0]-48) * 1 + (textBox1.Text[1] - 48) * 3 + (textBox1.Text[2] - 48) * 7 + (textBox1.Text[3] - 48) * 9 + (textBox1.Text[4] - 48) * 1 + (textBox1.Text[5] - 48) * 3 + (textBox1.Text[6] - 48) * 7 + (textBox1.Text[7] - 48) * 9 + (textBox1.Text[8] - 48) * 1 + (textBox1.Text[9] - 48) * 3;
                    if(10-(suma%10) == textBox1.Text[10]-48)
                    {
                         pictureBox1.Image = (Image)MyImageOk;
                        Debug.WriteLine(suma);
                    }
                    else { pictureBox1.Image = (Image)MyImageNieok;

                        Debug.WriteLine(suma);


                    }
                }
                else { pictureBox1.Image = (Image)MyImageNieok; }

            }
            else {  pictureBox1.Image = (Image)MyImageNieok; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
