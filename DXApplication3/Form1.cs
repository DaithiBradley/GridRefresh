using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DXApplication3
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static List<Utilities.Users> GlobalUsers;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Shown(object sender, System.EventArgs e)
        {
            GlobalUsers =
            [
                new Utilities.Users() { Id = 1, UserName = "Dave" },
                new Utilities.Users() { Id = 59, UserName = "Darius" },
                new Utilities.Users() { Id = 10, UserName = "Edel" }
            ];


            var dbContext = new Models.BusinessManagerContext();

            dbContext.Leads.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                leadBindingSource1.DataSource = dbContext.Leads.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            gridControl1.DataSource = leadBindingSource1;

            repositoryItemLookUpEdit1.DataSource = GlobalUsers;
            repositoryItemLookUpEdit1.DisplayMember = "UserName";
            repositoryItemLookUpEdit1.ValueMember = "Id";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var t = new RefreshHelper(gridView1, "Id");
            t.SaveViewInfo();
            var dbContext = new Models.BusinessManagerContext();
            leadBindingSource1.DataSource = dbContext.Leads.ToList();

            t.LoadViewInfo();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Stage")
            {
                switch (e.CellValue)
                {
                    case "Closed - Won":
                        Utilities.DrawRoundRectangle(e.Cache, Color.Green, e.Bounds);
                        e.Appearance.ForeColor = Color.White;
                        break;
                    case "Closed - Lost":
                        Utilities.DrawRoundRectangle(e.Cache, Color.DarkGray, e.Bounds);
                        e.Appearance.ForeColor = Color.Black;


                        break;
                    case "Potential Sale":
                        Utilities.DrawRoundRectangle(e.Cache, Color.LightSkyBlue, e.Bounds);
                        e.Appearance.ForeColor = Color.Black;


                        break;
                    case "Expected Booking":
                        Utilities.DrawRoundRectangle(e.Cache, Color.LightGreen, e.Bounds);
                        e.Appearance.ForeColor = Color.Black;

                        break;
                    case "Deferred":
                        Utilities.DrawRoundRectangle(e.Cache, Color.Orange, e.Bounds);
                        e.Appearance.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var r = e.Row as Models.Lead;
            var dbContext = new Models.BusinessManagerContext();
            dbContext.Leads.Update(r);
            dbContext.SaveChanges();
            RefreshData();

        }
    }
}
