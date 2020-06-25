using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceProject
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public static bool Flag = true;
        public MainForm()
        {
            InitializeComponent();

            barManager = barManager;
         //   barManager.ItemClick += new ItemClickEventHandler(barManager_ItemClick);
            // Create Radial Menu
            radialMenu = new RadialMenu(barManager);
            radialMenu.AddItems(GetRadialMenuItems(barManager));
        }




        //private void btnShowRadialMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    // Display Radial Menu
        //    if (radialMenu == null) return;
        //    Point pt = this.Location;
        //    pt.Offset(this.Width / 2, this.Height / 2);
        //    radialMenu.ShowPopup(pt);
        //}

        BarItem[] GetRadialMenuItems(BarManager barManager)
        {
            // Create bar items to display in Radial Menu
            BarItem btnCopy = new BarButtonItem(barManager, "سامانه حسابداری");
            btnCopy.ImageOptions.ImageUri.Uri = "Chart;Size16x16";
            btnCopy.ItemClick += new ItemClickEventHandler(btnCopy_ItemClick);

            BarItem btnCut = new BarButtonItem(barManager, "سامانه انبار");
            btnCut.ImageOptions.ImageUri.Uri = "Today;Size16x16";

            BarItem btnDelete = new BarButtonItem(barManager, "سامانه حقوق دستمزد");
            btnDelete.ImageOptions.ImageUri.Uri = "Currency;Size16x16";

            BarItem btnPaste = new BarButtonItem(barManager, "همه چیز");
            btnPaste.ImageOptions.ImageUri.Uri = "Paste;Size16x16";

            BarItem btnExit = new BarButtonItem(barManager, "خروچ از سیستم");
            btnExit.ImageOptions.ImageUri.Uri = "Close;Size16x16";
            btnExit.ItemClick += new ItemClickEventHandler(btnExit_ItemClick);

            // Sub-menu with 3 check buttons
            BarSubItem btnMenuFormat = new BarSubItem(barManager, "مشخصات سیستم");
            BarCheckItem btnCheckBold = new BarCheckItem(barManager, false);
            btnCheckBold.Caption = "مشخصه یک";
            btnCheckBold.ImageOptions.ImageUri.Uri = "Bold;Size16x16";

            BarCheckItem btnCheckItalic = new BarCheckItem(barManager, true);
            btnCheckItalic.Caption = "مشخصه دو";
            btnCheckItalic.ImageOptions.ImageUri.Uri = "Italic;Size16x16";

            BarCheckItem btnCheckUnderline = new BarCheckItem(barManager, false);
            btnCheckUnderline.Caption = "مشخصه سه";
            btnCheckUnderline.ImageOptions.ImageUri.Uri = "Underline;Size16x16";

            BarItem[] subMenuItems = new BarItem[] { btnCheckBold, btnCheckItalic, btnCheckUnderline };
            btnMenuFormat.AddItems(subMenuItems);

            BarItem btnFind = new BarButtonItem(barManager, "سیستم خزانه داری");
            btnFind.ImageOptions.ImageUri.Uri = "Find;Size16x16";

            BarItem btnUndo = new BarButtonItem(barManager, "سیستم قراردادها");
            btnUndo.ImageOptions.ImageUri.Uri = "Undo;Size16x16";

            BarItem btnRedo = new BarButtonItem(barManager, "سیستم دارایی");
            btnRedo.ImageOptions.ImageUri.Uri = "Redo;Size16x16";

            return new BarItem[] { btnCopy, btnCut, btnDelete, btnPaste, btnExit, btnMenuFormat, btnFind, btnUndo, btnRedo };
            
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            var path = new GraphicsPath();
             this.Opacity = 0;
          
            timer1.Start();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Flag)
                return;
            Flag = !Flag;
            if (radialMenu == null) return;
            Point pt = this.Location;
            pt.Offset(this.Width / 2, this.Height / 2);
            radialMenu.ShowPopup(pt);

            radialMenu.Expand();

        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Accounting.Accounting accounting = new Accounting.Accounting();
            accounting.BringToFront();
            this.SendToBack();
            accounting.ShowDialog();
            Flag = !Flag; ;// = FormWindowState.Minimized;
        }
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
