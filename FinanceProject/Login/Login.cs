using DataActivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceProject.Login
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide(); 
            mainForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            try { 
            Connection.ConnectionString=
                System.Configuration.ConfigurationManager.ConnectionStrings["FinanceConnection"].ConnectionString;
            }
            catch
            {
                MessageBox.Show("اطلاعات اتصال به درستی وارد نشده است ");
                new ConnectionSetting().ShowDialog();
                return;
            }
           
            if (!DataActivity.Connection.ConnectionChecking())
            {
                MessageBox.Show("اطلاعات اتصال به درستی وارد نشده است ");
                new ConnectionSetting().ShowDialog();
                return;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
