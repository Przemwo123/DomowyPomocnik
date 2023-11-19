using System;
using System.IO;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    public partial class Notatnik : Form
    {
        private static string stringText = "";
        private static string strFileName = "";
        private static string fileTitle = "*.txt";
        private readonly OpenFileDialog openFileDialog = new OpenFileDialog();
        private readonly SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Notatnik()
        {
            InitializeComponent();
        }

        private void Notatnik_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = stringText;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            stringText = richTextBox1.Text;
        }

        private void BtnNewFile_Click(object sender, EventArgs e)
        {
            if (stringText != "")
            {
                DialogResult dr = MessageBox.Show("Czy chcesz zapisać zmiany?", "Notatnik", MessageBoxButtons.YesNoCancel);

                if (dr == DialogResult.Yes)
                {
                    SaveVile();
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

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Otwórz plik";
            openFileDialog.Filter = "Dokumenty tekstowe|*txt|Wszystkie pliki|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strFileName = openFileDialog.FileName;
                fileTitle = FindFileTitle(strFileName);
                //stringText = File.ReadAllText(strFileName);
                StreamReader read = new StreamReader(File.OpenRead(strFileName));
                stringText = read.ReadToEnd();
                read.Dispose();
                richTextBox1.Text = stringText;
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveVile();
        }

        private void SaveVile()
        {
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

        private string FindFileTitle(string s)
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
