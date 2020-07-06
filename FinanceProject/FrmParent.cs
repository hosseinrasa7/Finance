using FinanceProject.Accounting;
using FinanceProject.MessageDialogs;
using FinanceProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace FinanceProject
{
    public partial class FrmParent : RadForm

    {
        public bool btnEditCanExe = true, btnAddCanExe = true, btnSaveCanExe = true, btnDeleteCanExe = true, btnCancelCanExe = true;
        BindingSource bindingSource = new BindingSource();
        // public object DataSource;
        public FrmParent()
        {
            InitializeComponent();
        }
         public FrmParent(object DataSource)
        {
            InitializeComponent();

            bindingSource.DataSource = DataSource;
            bnavMain.BindingSource = bindingSource;
            gcDetail.DataSource = bindingSource;
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {

            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.SimpleButton))
                {
                    ((DevExpress.XtraEditors.SimpleButton)item).Enabled = false;
                }
            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }


        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ورژننرمافزارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFrmNotifyDialog sFrmNotifyDialog = new SFrmNotifyDialog("نرم افزار حسابداری مالی نسخه 1.0.0", 1);
            sFrmNotifyDialog.ShowDialog();

        }

        private void btnSave_MouseUp(object sender, MouseEventArgs e)
        {
            if (!btnSaveCanExe)
                return;
            FrmParent_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SFrmNotifyDialog sFrmNotifyDialog = new SFrmNotifyDialog("آیا از ذخیره اطلاعات فرم مطئمن هستید؟", 1);
            sFrmNotifyDialog.ShowDialog();
            if (!sFrmNotifyDialog.response)
                btnSaveCanExe = false;
            else
                btnSaveCanExe = true;
        }

        private void btnEdit_MouseUp(object sender, MouseEventArgs e)
        {
            if (!btnEditCanExe)
                return;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SFrmNotifyDialog sFrmNotifyDialog = new SFrmNotifyDialog("آیا از حذف اطلاعات جاری مطئمن هستید؟", 1);
            sFrmNotifyDialog.ShowDialog();
            if (!sFrmNotifyDialog.response)
                btnDeleteCanExe = false;
            else
                btnDeleteCanExe = true;
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!btnCancelCanExe)
                return;
            FrmParent_Load(sender, e);
        }

    }
}
