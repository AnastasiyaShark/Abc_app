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
    public partial class Begin_game : Form
    {
        public Begin_game()
        {
            InitializeComponent();
        }

      

        private void label2_Click(object sender, EventArgs e)
        {
        
            this.Hide();
            Game game = new Game();
            game.Show();
        }
        //При наезде на надпись меняется цвет
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }
        //При отъезде от надписи меняется цвет
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
        //для передвижения экрана
        Point lastPoint;
        private void Begin_game_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        //для передвижения экрана
        private void Begin_game_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_screan form2 = new Welcome_screan();
            form2.Show();
        }
    }
}
