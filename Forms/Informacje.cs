using System.Reflection;
using System.Windows.Forms;

namespace ProgramForms.Forms
{
    public partial class Informacje : Form
    {
        public Informacje()
        {
            InitializeComponent();
        }

        private void Informacje_Load(object sender, System.EventArgs e)
        {
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;
            versionText.Text = string.Format("v{0}", appVersion);
        }
    }
}
