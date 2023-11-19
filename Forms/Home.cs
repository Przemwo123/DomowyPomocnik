using System;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dateUpdate();
        }

        private void dateUpdate()
        {
            timer1.Start();
            timeText.Text = DateTime.Now.ToLongTimeString();
            dateText.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
