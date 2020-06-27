using FinanceProject.Services;
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
    public partial class FrmAccGroup : Telerik.WinControls.UI.RadForm
    {
        BindingSource bindingSource = new BindingSource();
        AccGroupService accGroupService = new AccGroupService();
        public FrmAccGroup()
        {
            InitializeComponent();
         
            var accGroups = accGroupService.SelectAll();
            bindingSource.DataSource = accGroups;
            bindingNavigator1.BindingSource = bindingSource;
            //txtId.DataBindings.Add(new Binding("Text", bindingSource, "Id", true));
            txtCode.DataBindings.Add(new Binding("Text", bindingSource, "GrpCode", true));
            txtName.DataBindings.Add(new Binding("Text", bindingSource, "GrpDscp", true));
            gridControl1.DataSource = bindingSource;
           
        }

        private void AccGroup_Load(object sender, EventArgs e)
        {


            

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            this.Validate();

            MessageBox.Show("ثبت با موفقیت انجام شد");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            MessageBox.Show("حذف با موفقیت انجام شد");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            accGroupService.Save(new DataActivity.AccGroup { GrpCode = txtCode.Text,GrpDscp = txtName.Text});
            bindingNavigator1.Update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bindingSource.AddNew();
            ActiveControl = txtCode;
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
        }
    }
}
