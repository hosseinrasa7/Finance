
using FinanceProject.Accounting.BasicInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceProject.Accounting
{
    public partial class Accounting : Telerik.WinControls.UI.RadForm
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

            FrmAccGroup accGroup = new FrmAccGroup();
            accGroup.ShowDialog(this);

        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }
    }
}
