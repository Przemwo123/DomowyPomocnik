using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class BazaDanych : Form
    {
        private static event EventHandler TimerElapsed;

        public static string dataBaseAdress = "127.0.0.1";
        public static string dataBaseName = "test";
        public static string dataBaseTableName = "tabelatest1";
        public static string dataBaseUser = "root";
        public static string dataBasePassword = "";

        public enum StatusConection
        {
            disconnectionDB,
            ConnectionDBProgress,
            ConnectionDBOK,
            incorrectDBaddress,
            invalidLogin,
            invalidNameDB,
            invalidTableDB,
            unknownError,
        }

        private static string unknownError;

        public static StatusConection statusDB = StatusConection.disconnectionDB;
        private delegate void InvokeDelegate();

        private string connectionConf;

        private static MySqlConnection connection;

        private string setConnectionConfig()
        {
            return String.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};", dataBaseAdress, dataBaseName, dataBaseUser, dataBasePassword);
        }

        public BazaDanych()
        {
            TimerElapsed = OnTimerElapsed;
            InitializeComponent();
        }

        private void OnTimerElapsed(object sender, EventArgs e)
        {
            try { BeginInvoke(new InvokeDelegate(UpdateWindowsScreen)); }
            catch { }
        }

        private void BazaDanych_Load(object sender, EventArgs e)
        {
            UpdateWindowsScreen();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (statusDB != StatusConection.ConnectionDBOK)
            {
                connectionConf = setConnectionConfig();
                Thread threadConnect = new Thread(Connection);
                statusDB = StatusConection.ConnectionDBProgress;
                TimerElapsed?.Invoke(null, EventArgs.Empty);
                threadConnect.Start();
            }
            else
            {
                dataGridView1.DataSource = null;
                connection.Close();
                statusDB = StatusConection.disconnectionDB;
                TimerElapsed?.Invoke(null, EventArgs.Empty);
            }
        }

        private void Connection()
        {
            while (Application.AllowQuit && statusDB == StatusConection.ConnectionDBProgress)
            {
                try
                {
                    connection = new MySqlConnection(connectionConf);
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        statusDB = StatusConection.ConnectionDBOK;
                        TimerElapsed?.Invoke(null, EventArgs.Empty);
                    }
                    else
                    {
                        statusDB = StatusConection.disconnectionDB;
                        TimerElapsed?.Invoke(null, EventArgs.Empty);
                    }
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                        case 1042://Nie udało się połączyć z bazą danych.
                            statusDB = StatusConection.incorrectDBaddress;
                            break;
                        case 1045://Nieprawidłowa nazwa użytkownika lub hasło, spróbuj ponownie.
                            statusDB = StatusConection.invalidLogin;
                            break;
                        case 1049://Nieprawidłowa nazwa bazy danych.
                            statusDB = StatusConection.invalidNameDB;
                            break;
                        default:
                            statusDB = StatusConection.unknownError;
                            unknownError = ex.Number.ToString();
                            break;
                    }
                    TimerElapsed?.Invoke(null, EventArgs.Empty);
                    break;
                }
                Thread.Sleep(10);
            }
        }

        private void mySqlCommand()
        {
            string sql = "SELECT * FROM " + dataBaseTableName + ";";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(
                new MySqlCommand(sql, connection));
            DataTable categoryTable = new DataTable();
            try
            {
                dataAdapter.Fill(categoryTable);
            }
            catch
            {
                statusDB = StatusConection.invalidTableDB;
                TimerElapsed?.Invoke(null, EventArgs.Empty);
            }

            dataGridView1.DataSource = categoryTable.DefaultView;
        }

        private void UpdateWindowsScreen()
        {
            btnCon.Visible = true;
            btnCon.Text = "Połącz";
            statusText.ForeColor = Color.FromArgb(204, 0, 0);
            dataBaseConfiguration.Visible = true;

            switch (statusDB)
            {
                case StatusConection.disconnectionDB:
                    statusText.Text = "Niepołączona";
                    break;
                case StatusConection.ConnectionDBProgress:
                    btnCon.Visible = false;
                    dataBaseConfiguration.Visible = false;
                    statusText.Text = "Łączenie...";
                    statusText.ForeColor = Color.FromArgb(255, 187, 0);
                    break;
                case StatusConection.ConnectionDBOK:
                    dataBaseConfiguration.Visible = false;
                    statusText.Text = "Połączona";
                    statusText.ForeColor = Color.FromArgb(0, 190, 0);
                    btnCon.Text = "Rozłącz";
                    mySqlCommand();
                    break;
                case StatusConection.incorrectDBaddress:
                    statusText.Text = "Nie udało się połączyć z bazą danych.";
                    break;
                case StatusConection.invalidLogin:
                    statusText.Text = "Nieprawidłowa nazwa użytkownika lub hasło, spróbuj ponownie.";
                    break;
                case StatusConection.invalidNameDB:
                    statusText.Text = "Nieprawidłowa nazwa bazy danych!";
                    break;
                case StatusConection.invalidTableDB:
                    statusText.Text = "Nie znaleziono tabeli '" + dataBaseTableName + "' w bazie danych!";
                    break;
                case StatusConection.unknownError:
                    statusText.Text = unknownError;
                    break;
            }
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
            af.BringToFront();
            af.Show();
        }

        private void dataBaseConfiguration_Click(object sender, EventArgs e)
        {
            OpenCF(new Forms.BazaDanychConfig());
        }
    }
}
