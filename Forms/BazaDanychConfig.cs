using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class BazaDanychConfig : Form
    {

        public BazaDanychConfig()
        {
            InitializeComponent();
        }

        private void BazaDanychConfig_Load(object sender, EventArgs e)
        {
            aDB.Text = BazaDanych.dataBaseAdress;
            nDB.Text = BazaDanych.dataBaseName;
            tDB.Text = BazaDanych.dataBaseTableName;
            uDB.Text = BazaDanych.dataBaseUser;
            pDB.Text = BazaDanych.dataBasePassword;
        }

        private void OpenCF(Form f)
        {
            Form af = f;
            af.TopLevel = false;
            af.FormBorderStyle = FormBorderStyle.None;
            af.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(af);
            this.Tag = af;
            //af.BringToFront();
            af.Show();
        }

        private void configDBSave_Click(object sender, EventArgs e)
        {
            BazaDanych.dataBaseAdress = aDB.Text;
            BazaDanych.dataBaseName = nDB.Text;
            BazaDanych.dataBaseTableName = tDB.Text;
            BazaDanych.dataBaseUser = uDB.Text;
            BazaDanych.dataBasePassword = pDB.Text;

            //BazaDanych.statusDB = BazaDanych.StatusConection.ConnectionStart;

            OpenCF(new Forms.BazaDanych());
        }

        private void configDBCancel_Click(object sender, EventArgs e)
        {
            OpenCF(new Forms.BazaDanych());
        }
    }
}
