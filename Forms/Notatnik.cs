using System;
using System.Windows.Forms;
using System.IO;

namespace ProgramForms.Forms
{
    public partial class Notatnik : Form
    {
        private static string stringText = "";
        private static string strFileName = "";
        private static string fileTitle = "*.txt";

        public Notatnik()
        {
            InitializeComponent();
        }

        private void Notatnik_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = stringText;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            stringText = richTextBox1.Text;
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            if (stringText != "")
            {
                DialogResult dr = MessageBox.Show("Czy chcesz zapisać zmiany?", "Notatnik", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    saveVile();
                }
                else if (dr == DialogResult.No)
                {
                    stringText = "";
                    strFileName = "";
                    fileTitle = "*.txt";
                    richTextBox1.Text = "";
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Otwórz plik";
            openFileDialog.Filter = "Dokumenty tekstowe|*txt|Wszystkie pliki|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strFileName = openFileDialog.FileName;
                fileTitle = findFileTitle(strFileName);
                //stringText = File.ReadAllText(strFileName);
                StreamReader read = new StreamReader(File.OpenRead(strFileName));
                stringText = read.ReadToEnd();
                read.Dispose();
                richTextBox1.Text = stringText;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveVile();
        }

        private void saveVile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Zapisywanie jako";
            saveFileDialog.Filter = "Dokumenty tekstowe|*txt|Wszystkie pliki|*.*";
            saveFileDialog.FileName = fileTitle;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                strFileName = saveFileDialog.FileName;
                StreamWriter write = new StreamWriter(File.Create(strFileName));

                write.Write(richTextBox1.Text);
                write.Dispose();
            }
        }

        private string findFileTitle(string s)
        {
            string[] words = s.Split('\\');
            string temp = "";

            foreach (var word in words)
            {
                temp = word;
            }

            return temp;
        }
    }
}
