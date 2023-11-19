using System;
using System.Drawing;
using System.Windows.Forms;

namespace DomowyPomocnik
{
    public partial class Menu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (currentButton == null)
                OpenChildForm(new Forms.Home(), btnHome);
        }

        private Color SelectThemeColor(String _nameBtn)
        {
            string color = ThemeColors.ColorList(_nameBtn);
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btn)
        {
            if (btn != null)
            {
                if (currentButton != (Button)btn)
                {
                    DisableButton();
                    currentButton = (Button)btn;

                    Color color = SelectThemeColor(currentButton.Name);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    panelTitleBar.BackColor = color;
                    panelTitleText.Text = currentButton.Text;
                    iconTitle.Image = currentButton.Image;
                    currentButton.Padding = new Padding(5, 0, 0, 0);
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = panelMenu.BackColor;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    previousBtn.Padding = new Padding(0, 0, 0, 0);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (currentButton == btnSender)
                return;

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Do10go(), sender);
        }

        private void BtnSto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Stoper(), sender);
        }

        private void BtnWea_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pogoda(), sender);
        }

        private void BtnDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BazaDanych(), sender);
        }

        private void BtnNot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Notatnik(), sender);
        }

        private void BtnInf_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Informacje(), sender);
        }
    }
}