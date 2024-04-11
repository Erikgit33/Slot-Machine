using Slot_Machine.Properties;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace Slot_Machine
{
    public partial class Form1 : Form
    {
        Image[] images = { Resources.watermelon, Resources.bell, Resources.seven, Resources.orange, Resources.grape, Resources.cherry };
        int index1 = 0;
        int index2 = 0;
        int index3 = 0;

        int secondtimer = 0;
        int thirdtimer = 0;

        int spin = 1;
        int spinsleft = 15;
        int ddouble = 0;

        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            label1.Text = "Spins left: " + spinsleft.ToString();
            pictureBox1.Image = images[2];
            pictureBox2.Image = images[2];
            pictureBox3.Image = images[2];
        }

        private void buttonspin_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                if (secondtimer == 1)
                {
                    secondtimer = 0;
                }
                if (thirdtimer == 1)
                {
                    thirdtimer = 0;
                }
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                if (checkBox1.Checked == false)
                {
                    index1 = rng.Next(0, 5);
                }

                if (checkBox2.Checked == false)
                {
                    index2 = rng.Next(0, 5);
                }

                if (checkBox3.Checked == false)
                {
                    index3 = rng.Next(0, 5);
                }

                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;

                timer3.Interval = rng.Next(350, 650);
                timer4.Interval = rng.Next(800, 1200);

                if (ddouble == 1)
                {
                    
                }
                else
                {
                    spinsleft--;
                }
                label1.Text = "Spins left: " + spinsleft.ToString();
            }
            else
            {
                MessageBox.Show("Wait until the machine has stopped!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (pictureBox1.Image == images[5])
                {
                    index1 = -1;
                }
                index1++;
                pictureBox1.Image = images[index1];
            }

            if (checkBox2.Checked == false)
            {
                if (secondtimer == 1)
                {
                    if (pictureBox2.Image == images[5])
                    {
                        index2 = -1;
                    }
                    index2++;
                    pictureBox2.Image = images[index2];
                }
            }

            if (checkBox3.Checked == false)
            {
                if (thirdtimer == 1)
                {
                    if (pictureBox3.Image == images[5])
                    {
                        index3 = -1;
                    }
                    index3++;
                    pictureBox3.Image = images[index3];
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Thread.Sleep(timer1.Interval);

            if (spin == 0)
            {
                spin = 1;
            }
            else
            {
                spin = 0;
            }

            if (spin == 1)
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }

            if (index1 == index2 && index3 == index2 && index1 == index3)
            {
                timer2.Stop();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                if (index1 == 1)
                {
                    if (ddouble == 0)
                    {
                        MessageBox.Show("Jackpot! 5 spins gained!");
                        spinsleft = spinsleft + 5;
                        label1.Text = "Spins left: " + (spinsleft + 5);
                    }
                    else if (ddouble == 1)
                    {
                        MessageBox.Show("Jackpot with double: 10 spins gained!");
                        spinsleft = spinsleft + 10;
                        label1.Text = "Spins left: " + (spinsleft + 10);
                    }
                }
                else if (index1 == 5) 
                {
                    if (ddouble == 0)
                    {
                        MessageBox.Show("Jackpot! 8 spins gained!");
                        spinsleft = spinsleft + 8;
                        label1.Text = "Spins left: " + (spinsleft + 8);
                    }
                    else if (ddouble == 1)
                    {
                        MessageBox.Show("Jackpot with double: 16 spins gained!");
                        spinsleft = spinsleft + 16;
                        label1.Text = "Spins left: " + (spinsleft + 16);
                    }
                }
                else if (index1 == 3)
                {
                    if (ddouble == 0)
                    {
                        MessageBox.Show("Jackpot! 12 spins gained!");
                        spinsleft = spinsleft + 12;
                        label1.Text = "Spins left: " + (spinsleft + 12);
                    }
                    else if (ddouble == 1)
                    {
                        MessageBox.Show("Jackpot with double: 24 spins gained!");
                        spinsleft = spinsleft + 24;
                        label1.Text = "Spins left: " + (spinsleft + 24);
                    }
                }
                else if (index1 == 4)
                {
                    if (ddouble == 0)
                    {
                        MessageBox.Show("Jackpot! 16 spins gained!");
                        spinsleft = spinsleft + 16;
                        label1.Text = "Spins left: " + (spinsleft + 16);
                    }
                    else if (ddouble == 1)
                    {
                        MessageBox.Show("Jackpot with double: 32 spins gained!");
                        spinsleft = spinsleft + 32;
                        label1.Text = "Spins left: " + (spinsleft + 32);
                    }
                }
                else if (index1 == 0)
                {
                    if (ddouble == 0)
                    {
                        MessageBox.Show("Jackpot! 20 spins gained!");
                        spinsleft = spinsleft + 20;
                        label1.Text = "Spins left: " + (spinsleft + 20);
                    }
                    else if (ddouble == 1)
                    {
                        MessageBox.Show("Jackpot with double: 40 spins gained!");
                        spinsleft = spinsleft + 40;
                        label1.Text = "Spins left: " + (spinsleft + 40);
                    }
                }
                else if (index1 == 2)
                {
                    MessageBox.Show("Mega Jackpot! 30 spins gained!");
                    spinsleft = spinsleft + 30;
                    label1.Text = "Spins left: " + (spinsleft + 30);
                    if (ddouble == 1)
                    {
                        MessageBox.Show("Jackpot with double: 60 spins gained!");
                        spinsleft = spinsleft + 60;
                        label1.Text = "Spins left: " + (spinsleft + 60);
                    }
                }
            }

            else if (spinsleft == 0)
            {
                MessageBox.Show("You ran out of spins!");
                Close();
            }

            buttondouble.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            secondtimer = 1;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            thirdtimer = 1;
            timer4.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttondouble_Click(object sender, EventArgs e)
        {
            spinsleft--;
            label1.Text = "Spins left: " + spinsleft.ToString();
            ddouble = 1;
            buttondouble.Enabled = false;
            if (ddouble == 0) 
            {
                ddouble = 1;
                buttondouble.Enabled = true;
            }
        }
    }
}
