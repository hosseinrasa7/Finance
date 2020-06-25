using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace FinanceProject.Accounting.BasicInformation
{
    public partial class AccGroup : Telerik.WinControls.UI.RadForm
    {
        public AccGroup()
        {
            InitializeComponent();
        }

        private void AccGroup_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            // TODO: This line of code loads data into the 'financeDBDataSet.accGeneral' table. You can move, or remove it, as needed.
            this.accGeneralTableAdapter.Fill(this.financeDBDataSet.accGeneral);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            this.Validate();
            this.accGeneralBindingSource.EndEdit();
            this.accGeneralTableAdapter.Update(this.financeDBDataSet);
            MessageBox.Show("ثبت با موفقیت انجام شد");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            accGeneralBindingSource.CancelEdit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accGeneralBindingSource.EndEdit();
            this.accGeneralTableAdapter.Update(this.financeDBDataSet);
            MessageBox.Show("حذف با موفقیت انجام شد");
        }
    }
}
