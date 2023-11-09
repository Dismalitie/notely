using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace notely
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

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

        private bool ispinned = false;
        private bool ismin = false;
        private int lasty = 0;
        private bool isvisible = true;

        Form1 form1 = new Form1();

        private void Note_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            if (randomNumber == 1)
            {
                BackColor = Color.FromArgb(227, 149, 26);
                panel1.BackColor = Color.FromArgb(247, 169, 46);
                textBox1.BackColor = panel1.BackColor;
                richTextBox1.BackColor = BackColor;
            }
            if (randomNumber == 2)
            {
                BackColor = Color.FromArgb(120, 43, 178);
                panel1.BackColor = Color.FromArgb(140, 63, 198);
                richTextBox1.BackColor = BackColor;
                textBox1.BackColor = panel1.BackColor;
            }
            if (randomNumber == 3)
            {
                BackColor = Color.FromArgb(43, 178, 120);
                panel1.BackColor = Color.FromArgb(63, 198, 140);
                textBox1.BackColor = panel1.BackColor;
                richTextBox1.BackColor = BackColor;
            }
            if (randomNumber == 4)
            {
                BackColor = Color.FromArgb(185, 27, 25);
                panel1.BackColor = Color.FromArgb(205, 47, 45);
                textBox1.BackColor = panel1.BackColor;
                richTextBox1.BackColor = BackColor;
            }
            lasty = Location.Y;
        }



        private void exit_Click(object sender, EventArgs e)
        {
            form1.notes = form1.notes - 1;
            fade_out.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ispinned == false)
            {
                siticoneDragControl1.SetDrag(nodrag);
                siticoneDragControl2.SetDrag(nodrag);
                pictureBox1.BackgroundImage = Properties.Resources.pin_alt;
                ispinned = true;
            }
            else
            {
                siticoneDragControl1.SetDrag(panel1);
                siticoneDragControl2.SetDrag(textBox1);
                pictureBox1.BackgroundImage = Properties.Resources.pin;
                ispinned = false;
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            if (ispinned == ismin)
            {
                min.BackgroundImage = Properties.Resources.chevron_down;
                Size = new Size(295, 39);
                update.Enabled = false;
                Location = new Point(Location.X, 0);
                ismin = true;
            }
            else
            {
                min.BackgroundImage = Properties.Resources.chevron_up;
                Location = new Point(Location.X, lasty);
                update.Enabled = true;
                Size = new Size(295, 329);
                ismin = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Tick(object sender, EventArgs e)
        {
            lasty = Location.Y;
        }

        private void visibility_Click(object sender, EventArgs e)
        {
            if (isvisible == true)
            {
                if (Opacity != 0.4)
                {
                    Opacity = Opacity - 0.05;
                }
                visibility.BackgroundImage = Properties.Resources.eye;
                isvisible = false;
            }
            else
            {
                if (Opacity != 1)
                {
                    Opacity = Opacity + 0.05;
                }
                visibility.BackgroundImage = Properties.Resources.eye_off;
                isvisible = true;
            }
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
            }
        }
    }
}
