using System;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class Do10go : Form
    {
        private int howManyDays;
        public Do10go()
        {
            InitializeComponent();
        }

        private void IleDoKoncaMiesiaca_Load(object sender, EventArgs e)
        {
            howManyDays = HowManyDays();
        }

        private int HowManyDays()
        {
            DateTime dat1 = DateTime.Now;
            int day = dat1.Day;
            int month = DateTime.DaysInMonth(dat1.Year, dat1.Month);
            textInfoDay.Text = dat1.ToLongDateString();
            int temp = 0;

            if (day < 10)
            {
                temp = 10-day;
            }
            else
            {
                temp = ((month + 10) - day);
            }

            if (temp > 1)
            {
                textHowManyDays.Text = temp + " dni!";
            }
            else if (temp == 1)
            {
                textHowManyDays.Text = "1 dzień!";
            }

            return temp;
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            decimal temp = myMoney.Value;
            if (checkBoxToday.Checked)
                moneyDay.Text = String.Format("{0:0.0#}", (temp / howManyDays)) + " zł";
            else if (howManyDays - 1 <= 0)
                moneyDay.Text = String.Format("{0:0.0#}", (temp / howManyDays)) + " zł";
            else
                moneyDay.Text = String.Format("{0:0.0#}", (temp / (howManyDays - 1))) + " zł";
        }
    }
}