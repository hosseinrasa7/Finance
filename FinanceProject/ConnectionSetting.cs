using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceProject
{
    public partial class ConnectionSetting : Telerik.WinControls.UI.RadForm
    {
        public ConnectionSetting()
        {
            InitializeComponent();
        }

        private void ConnectionSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["FinanceConnection"].ConnectionString = 
               string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;User Id = {2};Password = {3}", edtServerName.Text,cboxDatabaseName.Text
                            ,txtUserName.Text,txtPassword.Text);
            config.ConnectionStrings.ConnectionStrings["FinanceConnection"].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void cboxDatabaseName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void cboxDatabaseName_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string ConStr = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;User Id = {2};Password = {3}", edtServerName.Text, "master"
                            , txtUserName.Text, txtPassword.Text);

            DataActivity.DataOperation dataOperation = new DataActivity.DataOperation();
            dataOperation.GetDatabaseList(ConStr);
            cboxDatabaseName.Items.Clear();
            var r = dataOperation.GetDatabaseList(ConStr);
            foreach (var item in r)
            {
                cboxDatabaseName.Items.Add(item);
            }

        }
    }
}
