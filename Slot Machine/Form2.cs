using Slot_Machine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox6.Image = Resources.seven;
            pictureBox5.Image = Resources.watermelon;
            pictureBox4.Image = Resources.grape;
            pictureBox3.Image = Resources.orange;
            pictureBox2.Image = Resources.cherry;
            pictureBox1.Image = Resources.bell;
        }
    }
}
