using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceProject.MessageDialogs
{
    public partial class SFrmNotifyDialog : Telerik.WinControls.UI.ShapedForm
    {
        public bool response;
        public string message;
        public SFrmNotifyDialog()
        {
            InitializeComponent();
        }
        public SFrmNotifyDialog(string message, int type)
        {
            InitializeComponent();
            this.message = message;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            response = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            response = false ;
            this.Close();
        }

        private void SFrmNotifyDialog_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.message;
        }
        
    }
}
