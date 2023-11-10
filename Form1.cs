using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace notely
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int notes = 0;
        Functions f = new Functions();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(0,0);
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.x_alt;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.BackgroundImage = Properties.Resources.x;
        }

        private void min_MouseEnter(object sender, EventArgs e)
        {
            min.BackgroundImage = Properties.Resources.minus_alt;
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.BackgroundImage = Properties.Resources.minus;
        }

        private void plus_MouseEnter(object sender, EventArgs e)
        {
            plus.BackgroundImage = Properties.Resources.plus_alt;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.BackgroundImage = Properties.Resources.plus;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            fade_out.Enabled = true;
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Show();
        }

        private void fade_in_Tick(object sender, EventArgs e)
        {
            if (Opacity != 1)
            {
                Opacity = Opacity + 0.2;
            }
            else
            {
                fade_in.Enabled = false;
            }
        }

        private void fade_out_Tick(object sender, EventArgs e)
        {
            if (Opacity != 0)
            {
                Opacity = Opacity - 0.2;
            }
            else
            {
                this.Hide();
                Application.Exit();
            }
        }
    }
}
