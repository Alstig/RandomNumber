using System;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateNumber() => labelNumber.Text = random.Next(1, 101).ToString();

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateNumber();
            timer1.Start();
        }
    }
}
