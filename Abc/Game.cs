using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abc
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            
        }
        //для передвижения экрана
        Point lastPoint;
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //для передвижения экрана
        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //для передвижения слов
        Point lastPointWord;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            checkKoordinate(label1, e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointWord = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            checkKoordinate(label2, e);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointWord = new Point(e.X, e.Y);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            checkKoordinate(label4, e);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointWord = new Point(e.X, e.Y);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            checkKoordinate(label5, e);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointWord = new Point(e.X, e.Y);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            checkKoordinate(label6, e);
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointWord = new Point(e.X, e.Y);
        }

        private void checkKoordinate(Label label, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label.Left += e.X - lastPointWord.X;
               label.Top += e.Y - lastPointWord.Y;
            }
        }

  

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Begin_game form2 = new Begin_game();
            form2.Show();
        }

        private bool checkLocationA(Label label)
        {
            Point new_point = new Point(label.Location.X, label.Location.Y);
            if ( 112 < new_point.X  && 470 > new_point.X && 0 < new_point.Y && 340 > new_point.Y)
            {
                return true;
            }
            return false;
        }

        private bool checkLocationB(Label label)
        {
            Point new_point = new Point(label.Location.X, label.Location.Y);
            if (490 < new_point.X && 862 > new_point.X && 0 < new_point.Y && 340 > new_point.Y)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            bool[] arr =  {checkLocationA(label2),
                           checkLocationA(label5),
                           checkLocationA(label6),
                           checkLocationB(label1),
                           checkLocationB(label4)};

          foreach(bool b in arr)
            {
                if (b.Equals(true))
                {
                    i++;
                }
            }

            MessageBox.Show(i + "/5!");
            this.Hide();
            Begin_game form2 = new Begin_game();
            form2.Show();
            

        }

       
    }
}
