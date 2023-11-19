using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class BazaDanych : Form
    {
        private enum StatusConection
        {
            notConection,
            ConnectionProgress,
            ConnectionOK
        }

        private static StatusConection status = StatusConection.notConection;
        private delegate void InvokeDelegate();

        private string connectionConf =
            "SERVER=127.0.0.1;" +
            "DATABASE=podlewator3000;" +
            "UID=root;" +
            "PASSWORD=;";

        private static MySqlConnection connection;

        public BazaDanych()
        {
            InitializeComponent();
        }

        private void BazaDanych_Load(object sender, EventArgs e)
        {
            switch (status)
            {
                case StatusConection.notConection:
                    DisConnection();
                    break;
                case StatusConection.ConnectionProgress:
                    ConnectionProgress();
                    break;
                case StatusConection.ConnectionOK:
                    ConnectionOK();
                    break;

            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (status == StatusConection.notConection)
            {
                status = StatusConection.ConnectionProgress;
                Thread threadConnect = new Thread(Connection);
                ConnectionProgress();
                threadConnect.Start();
            }
            else if (status == StatusConection.ConnectionOK)
            {
                dataGridView1.DataSource = null;
                connection.Close();
                status = StatusConection.notConection;
                DisConnection();
            }
        }

        private void Connection()
        {
            while (Application.AllowQuit && status == StatusConection.ConnectionProgress)
            {
                try
                {
                    connection = new MySqlConnection(connectionConf);
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        status = StatusConection.ConnectionOK;
                        try
                        {
                            BeginInvoke(new InvokeDelegate(ConnectionOK));
                        }
                        catch { }
                    }
                    else
                    {
                        status = StatusConection.notConection;
                        try
                        {
                            BeginInvoke(new InvokeDelegate(ConnectionError));
                        }
                        catch { }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    status = StatusConection.notConection;
                    try
                    {
                        BeginInvoke(new InvokeDelegate(ConnectionError));
                    }
                    catch { }

                }
                Thread.Sleep(10);
            }
        }

        private void ConnectionProgress()
        {
            btnCon.Visible = false;
            statusText.Text = "Łączenie...";
            statusText.ForeColor = Color.FromArgb(255, 187, 0);
            nameDataBase.Text = "-";
        }

        private void ConnectionOK()
        {
            statusText.Text = "Connection";
            statusText.ForeColor = Color.FromArgb(0, 190, 0);
            btnCon.Visible = true;
            btnCon.Text = "Rozłącz";
            nameDataBase.Text = connection.Database;

            string sql = "SELECT * FROM danearduino";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                new MySqlCommand(sql, connection));
            DataTable categoryTable = new DataTable();
            try
            {
                dataAdapter.Fill(categoryTable);
            }
            catch
            {
                status = StatusConection.notConection;
                DisConnection();
            }

            dataGridView1.DataSource = categoryTable.DefaultView;
        }

        private void ConnectionError()
        {
            statusText.Text = "Brak połączenia";
            statusText.ForeColor = Color.FromArgb(204, 0, 0);
            btnCon.Visible = true;
        }

        private void DisConnection()
        {
            statusText.Text = "Brak połączenia";
            statusText.ForeColor = Color.FromArgb(204, 0, 0);
            btnCon.Text = "Połącz";
            nameDataBase.Text = "-";
        }
    }
}
