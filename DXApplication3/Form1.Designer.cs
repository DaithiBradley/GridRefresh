using System.Windows.Forms;

namespace DXApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            leadBindingSource1 = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAname = new DevExpress.XtraGrid.Columns.GridColumn();
            colType = new DevExpress.XtraGrid.Columns.GridColumn();
            colDue = new DevExpress.XtraGrid.Columns.GridColumn();
            colTimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            colComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            colContactId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAssignedTo = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            colMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            colStage = new DevExpress.XtraGrid.Columns.GridColumn();
            colExp = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            colRef = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmailMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            colSource = new DevExpress.XtraGrid.Columns.GridColumn();
            colLeadSeen = new DevExpress.XtraGrid.Columns.GridColumn();
            colActivitiescol = new DevExpress.XtraGrid.Columns.GridColumn();
            colLocale = new DevExpress.XtraGrid.Columns.GridColumn();
            colPo = new DevExpress.XtraGrid.Columns.GridColumn();
            colProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            colLeadArchieveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leadBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItem1, barButtonItem2, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1, skinRibbonGalleryBarItem1, skinPaletteRibbonGalleryBarItem1 });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new System.Drawing.Size(1121, 158);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Refresh";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.ActAsDropDown = true;
            skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem1.Id = 3;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Id = 4;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinRibbonGalleryBarItem1
            // 
            skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            skinRibbonGalleryBarItem1.Id = 5;
            skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            skinPaletteRibbonGalleryBarItem1.Id = 6;
            skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(skinDropDownButtonItem1);
            ribbonPageGroup2.ItemLinks.Add(skinPaletteDropDownButtonItem1);
            ribbonPageGroup2.ItemLinks.Add(skinRibbonGalleryBarItem1);
            ribbonPageGroup2.ItemLinks.Add(skinPaletteRibbonGalleryBarItem1);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = leadBindingSource1;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 158);
            gridControl1.MainView = gridView1;
            gridControl1.MenuManager = ribbonControl1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemLookUpEdit1 });
            gridControl1.Size = new System.Drawing.Size(1121, 514);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // leadBindingSource1
            // 
            leadBindingSource1.DataSource = typeof(Models.Lead);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colAname, colType, colDue, colTimeStamp, colComplete, colContactId, colAssignedTo, colPriority, colCreated, colCreatedBy, colMemo, colValue, colStage, colExp, colPhone, colEmail, colOrg, colRef, colEmailMemo, colSource, colLeadSeen, colActivitiescol, colLocale, colPo, colProfit, colLeadArchieveDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.CustomDrawCell += gridView1_CustomDrawCell;
            gridView1.RowUpdated += gridView1_RowUpdated;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colAname
            // 
            colAname.FieldName = "Aname";
            colAname.Name = "colAname";
            colAname.Visible = true;
            colAname.VisibleIndex = 1;
            // 
            // colType
            // 
            colType.FieldName = "Type";
            colType.Name = "colType";
            colType.Visible = true;
            colType.VisibleIndex = 2;
            // 
            // colDue
            // 
            colDue.FieldName = "Due";
            colDue.Name = "colDue";
            colDue.Visible = true;
            colDue.VisibleIndex = 3;
            // 
            // colTimeStamp
            // 
            colTimeStamp.FieldName = "TimeStamp";
            colTimeStamp.Name = "colTimeStamp";
            colTimeStamp.Visible = true;
            colTimeStamp.VisibleIndex = 4;
            // 
            // colComplete
            // 
            colComplete.FieldName = "Complete";
            colComplete.Name = "colComplete";
            colComplete.Visible = true;
            colComplete.VisibleIndex = 5;
            // 
            // colContactId
            // 
            colContactId.FieldName = "ContactId";
            colContactId.Name = "colContactId";
            colContactId.Visible = true;
            colContactId.VisibleIndex = 6;
            // 
            // colAssignedTo
            // 
            colAssignedTo.ColumnEdit = repositoryItemLookUpEdit1;
            colAssignedTo.FieldName = "AssignedTo";
            colAssignedTo.Name = "colAssignedTo";
            colAssignedTo.Visible = true;
            colAssignedTo.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEdit1
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colPriority
            // 
            colPriority.FieldName = "Priority";
            colPriority.Name = "colPriority";
            colPriority.Visible = true;
            colPriority.VisibleIndex = 8;
            // 
            // colCreated
            // 
            colCreated.FieldName = "Created";
            colCreated.Name = "colCreated";
            colCreated.Visible = true;
            colCreated.VisibleIndex = 9;
            // 
            // colCreatedBy
            // 
            colCreatedBy.FieldName = "CreatedBy";
            colCreatedBy.Name = "colCreatedBy";
            colCreatedBy.Visible = true;
            colCreatedBy.VisibleIndex = 10;
            // 
            // colMemo
            // 
            colMemo.FieldName = "Memo";
            colMemo.Name = "colMemo";
            colMemo.Visible = true;
            colMemo.VisibleIndex = 11;
            // 
            // colValue
            // 
            colValue.FieldName = "Value";
            colValue.Name = "colValue";
            colValue.Visible = true;
            colValue.VisibleIndex = 12;
            // 
            // colStage
            // 
            colStage.FieldName = "Stage";
            colStage.Name = "colStage";
            colStage.Visible = true;
            colStage.VisibleIndex = 13;
            // 
            // colExp
            // 
            colExp.FieldName = "Exp";
            colExp.Name = "colExp";
            colExp.Visible = true;
            colExp.VisibleIndex = 14;
            // 
            // colPhone
            // 
            colPhone.FieldName = "Phone";
            colPhone.Name = "colPhone";
            colPhone.Visible = true;
            colPhone.VisibleIndex = 15;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 16;
            // 
            // colOrg
            // 
            colOrg.FieldName = "Org";
            colOrg.Name = "colOrg";
            colOrg.Visible = true;
            colOrg.VisibleIndex = 17;
            // 
            // colRef
            // 
            colRef.FieldName = "Ref";
            colRef.Name = "colRef";
            colRef.Visible = true;
            colRef.VisibleIndex = 18;
            // 
            // colEmailMemo
            // 
            colEmailMemo.FieldName = "EmailMemo";
            colEmailMemo.Name = "colEmailMemo";
            colEmailMemo.Visible = true;
            colEmailMemo.VisibleIndex = 19;
            // 
            // colSource
            // 
            colSource.FieldName = "Source";
            colSource.Name = "colSource";
            colSource.Visible = true;
            colSource.VisibleIndex = 20;
            // 
            // colLeadSeen
            // 
            colLeadSeen.FieldName = "LeadSeen";
            colLeadSeen.Name = "colLeadSeen";
            colLeadSeen.Visible = true;
            colLeadSeen.VisibleIndex = 21;
            // 
            // colActivitiescol
            // 
            colActivitiescol.FieldName = "Activitiescol";
            colActivitiescol.Name = "colActivitiescol";
            colActivitiescol.Visible = true;
            colActivitiescol.VisibleIndex = 22;
            // 
            // colLocale
            // 
            colLocale.FieldName = "Locale";
            colLocale.Name = "colLocale";
            colLocale.Visible = true;
            colLocale.VisibleIndex = 23;
            // 
            // colPo
            // 
            colPo.FieldName = "Po";
            colPo.Name = "colPo";
            colPo.Visible = true;
            colPo.VisibleIndex = 24;
            // 
            // colProfit
            // 
            colProfit.FieldName = "Profit";
            colProfit.Name = "colProfit";
            colProfit.Visible = true;
            colProfit.VisibleIndex = 25;
            // 
            // colLeadArchieveDate
            // 
            colLeadArchieveDate.FieldName = "LeadArchieveDate";
            colLeadArchieveDate.Name = "colLeadArchieveDate";
            colLeadArchieveDate.Visible = true;
            colLeadArchieveDate.VisibleIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1121, 672);
            Controls.Add(gridControl1);
            Controls.Add(ribbonControl1);
            Name = "Form1";
            Ribbon = ribbonControl1;
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leadBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemLookUpEdit1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private BindingSource leadBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAname;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDue;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn colComplete;
        private DevExpress.XtraGrid.Columns.GridColumn colContactId;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignedTo;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colStage;
        private DevExpress.XtraGrid.Columns.GridColumn colExp;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colRef;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLeadSeen;
        private DevExpress.XtraGrid.Columns.GridColumn colActivitiescol;
        private DevExpress.XtraGrid.Columns.GridColumn colLocale;
        private DevExpress.XtraGrid.Columns.GridColumn colPo;
        private DevExpress.XtraGrid.Columns.GridColumn colProfit;
        private DevExpress.XtraGrid.Columns.GridColumn colLeadArchieveDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

