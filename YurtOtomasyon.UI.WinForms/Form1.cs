using Microsoft.Data.SqlClient;

namespace YurtOtomasyon.UI.WinForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DataAccess.Defaults.GetConnectionString());
        }
    }
}
