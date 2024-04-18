using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DXApplication3
{
    public class Utilities
    {
        [TypeConverter(typeof(Users))]
        public sealed class Users : IComparable
        {
            [Category("User Details")]
            [DisplayName("Is User Active")]
            public bool Active { get; set; }

            [Category("User Details")]
            [DisplayName("Working Directory")]
            public string Directory { get; set; }

            [Category("User Details")]
            [DisplayName("Email Address")]
            public string Email { get; set; }

            [Category("User Details")]
            public bool EmailImport { get; set; }

            [Category("User Details")]
            public Decimal FontSize { get; set; }

            [Category("User Details")]
            [DisplayName("User ID Number")]
            [Key]
            public int Id { get; set; }

            [Category("User Details")]
            [DisplayName("Initials")]
            public string Initials { get; set; }

            public string Ip { get; set; }

            [Category("System Options")]
            [DisplayName("Is System Administrator")]
            public bool IsAdmin { get; set; }

            public DateTime LastLogin { get; set; }

            [Category("Tenant")]
            public string Locale { get; set; }

            public int Logged { get; set; }

            public DateTime LoggedOut { get; set; }

            public string LoginName { get; set; }

            [Category("User Details")]
            public bool MultiTenant { get; set; }

            [Category("User Details")]
            [DisplayName("Login Password")]
            public string Password { get; set; }

            public int Screen { get; set; }


            public string Teams { get; set; }

            public bool TempPassword { get; set; }

            public string TenantName { get; set; }

            [Category("User Details")]
            public string Theme { get; set; }

            public string Token
            {
                get
                {
                    var interpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
                    interpolatedStringHandler.AppendFormatted<int>(this.Id);
                    interpolatedStringHandler.AppendLiteral("P");
                    return interpolatedStringHandler.ToStringAndClear();
                }
            }

            public string UserName { get; set; }

            [Category("User Details")]
            [DisplayName("Xero  [Category(\"User Details\")]")]
            public string XeroOrg { get; set; }

            public int ZulipUserId { get; set; }

            public int CompareTo(object obj)
            {
                return obj == null ? 1 : string.CompareOrdinal(this.UserName, (obj as Users).UserName);
            }
        }

        public static void DrawRoundRectangle(GraphicsCache g, Color fillcolor, Rectangle rect)
        {
            using var path = new GraphicsPath();
            var num1 = 6f;
            var x = (float)rect.X;
            var y = (float)rect.Y;
            var num2 = (float)(rect.Width - 1);
            var num3 = (float)(rect.Height - 1);
            var solidBrush = new SolidBrush(fillcolor);
            path.AddLine(x + num1, y, (float)((double)x + (double)num2 - (double)num1 * 2.0), y);
            path.AddArc((float)((double)x + (double)num2 - (double)num1 * 2.0), y, num1 * 2f, num1 * 2f, 270f, 90f);
            path.AddLine(x + num2, y + num1, x + num2, (float)((double)y + (double)num3 - (double)num1 * 2.0));
            path.AddArc((float)((double)x + (double)num2 - (double)num1 * 2.0), (float)((double)y + (double)num3 - (double)num1 * 2.0), num1 * 2f, num1 * 2f, 0.0f, 90f);
            path.AddLine((float)((double)x + (double)num2 - (double)num1 * 2.0), y + num3, x + num1, y + num3);
            path.AddArc(x, (float)((double)y + (double)num3 - (double)num1 * 2.0), num1 * 2f, num1 * 2f, 90f, 90f);
            path.AddLine(x, (float)((double)y + (double)num3 - (double)num1 * 2.0), x, y + num1);
            path.AddArc(x, y, num1 * 2f, num1 * 2f, 180f, 90f);
            path.CloseFigure();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath((Brush)solidBrush, path);
            g.DrawPath(new Pen(Color.Transparent), path);
        }
    }



    public class RefreshHelper
    {
        [Serializable]
        public struct RowInfo
        {
            public object Id;
            public int Level;
        };

        private GridView view;
        private string keyFieldName;
        private ArrayList saveExpList;
        private ArrayList saveSelList;
        private ArrayList saveMasterRowsList;
        private int visibleRowIndex = -1;

        public RefreshHelper(GridView view, string keyFieldName)
        {
            this.view = view;
            this.keyFieldName = keyFieldName;
        }

        public ArrayList SaveExpList
        {
            get { return saveExpList ??= []; }
        }

        public ArrayList SaveSelList
        {
            get { return saveSelList ??= []; }
        }

        public ArrayList SaveMasterRowsList
        {
            get { return saveMasterRowsList ??= []; }
        }

        protected int FindParentRowHandle(RowInfo rowInfo, int rowHandle)
        {
            var result = view.GetParentRowHandle(rowHandle);
            while (view.GetRowLevel(result) != rowInfo.Level && view.IsValidRowHandle(result))
                result = view.GetParentRowHandle(result);
            return result;
        }

        protected void ExpandRowByRowInfo(RowInfo rowInfo)
        {
            var dataRowHandle = view.LocateByValue(0, view.Columns[keyFieldName], rowInfo.Id);
            if (dataRowHandle == GridControl.InvalidRowHandle) return;
            var parentRowHandle = FindParentRowHandle(rowInfo, dataRowHandle);
            view.SetRowExpanded(parentRowHandle, true, false);
        }

        protected int GetRowHandleToSelect(RowInfo rowInfo)
        {
            var dataRowHandle = view.LocateByValue(0, view.Columns[keyFieldName], rowInfo.Id);
            if (dataRowHandle == GridControl.InvalidRowHandle) return dataRowHandle;
            return view.GetRowLevel(dataRowHandle) != rowInfo.Level ? FindParentRowHandle(rowInfo, dataRowHandle) : dataRowHandle;
        }

        protected void SelectRowByRowInfo(RowInfo rowInfo, bool isFocused)
        {
            if (isFocused)
                view.FocusedRowHandle = GetRowHandleToSelect(rowInfo);
            else
                view.SelectRow(GetRowHandleToSelect(rowInfo));
        }

        public void SaveSelectionViewInfo(ArrayList list)
        {
            list.Clear();
            var column = view.Columns[keyFieldName];
            RowInfo rowInfo;
            var selectionArray = view.GetSelectedRows();
            if (selectionArray != null)  // otherwise we have a single focused but not selected row
                foreach (var t in selectionArray)
                {
                    var dataRowHandle = t;
                    rowInfo.Level = view.GetRowLevel(dataRowHandle);
                    if (dataRowHandle < 0) // group row
                        dataRowHandle = view.GetDataRowHandleByGroupRowHandle(dataRowHandle);
                    rowInfo.Id = view.GetRowCellValue(dataRowHandle, column);
                    list.Add(rowInfo);
                }
            rowInfo.Id = view.GetRowCellValue(view.FocusedRowHandle, column);
            rowInfo.Level = view.GetRowLevel(view.FocusedRowHandle);
            list.Add(rowInfo);
        }

        public void SaveExpansionViewInfo(ArrayList list)
        {
            if (view.GroupedColumns.Count == 0) return;
            list.Clear();
            var column = view.Columns[keyFieldName];
            for (var i = -1; i > int.MinValue; i--)
            {
                if (!view.IsValidRowHandle(i)) break;
                if (!view.GetRowExpanded(i)) continue;
                RowInfo rowInfo;
                var dataRowHandle = view.GetDataRowHandleByGroupRowHandle(i);
                rowInfo.Id = view.GetRowCellValue(dataRowHandle, column);
                rowInfo.Level = view.GetRowLevel(i);
                list.Add(rowInfo);
            }
        }

        public void SaveExpandedMasterRows(ArrayList list)
        {
            if (view.GridControl.Views.Count == 1) return;
            list.Clear();
            var column = view.Columns[keyFieldName];
            for (var i = 0; i < view.DataRowCount; i++)
                if (view.GetMasterRowExpanded(i))
                    list.Add(view.GetRowCellValue(i, column));
        }

        public void SaveVisibleIndex()
        {
            visibleRowIndex = view.GetVisibleIndex(view.FocusedRowHandle) - view.TopRowIndex;
        }

        public void LoadVisibleIndex()
        {
            view.MakeRowVisible(view.FocusedRowHandle, true);
            view.TopRowIndex = view.GetVisibleIndex(view.FocusedRowHandle) - visibleRowIndex;
        }

        public void LoadSelectionViewInfo(ArrayList list)
        {
            view.BeginSelection();
            try
            {
                view.ClearSelection();
                for (var i = 0; i < list.Count; i++)
                    SelectRowByRowInfo((RowInfo)list[i], i == list.Count - 1);
            }
            finally
            {
                view.EndSelection();
            }
        }

        public void LoadExpansionViewInfo(ArrayList list)
        {
            if (view.GroupedColumns.Count == 0) return;
            view.BeginUpdate();
            try
            {
                view.CollapseAllGroups();
                foreach (RowInfo info in list)
                    ExpandRowByRowInfo(info);
            }
            finally
            {
                view.EndUpdate();
            }
        }

        public void LoadExpandedMasterRows(ArrayList list)
        {
            view.BeginUpdate();
            try
            {
                view.CollapseAllDetails();
                var column = view.Columns[keyFieldName];
                foreach (var t in list)
                {
                    var rowHandle = view.LocateByValue(0, column, t);
                    view.SetMasterRowExpanded(rowHandle, true);
                }
            }
            finally
            {
                view.EndUpdate();
            }
        }

        public void SaveViewInfo()
        {
            SaveExpandedMasterRows(SaveMasterRowsList);
            SaveExpansionViewInfo(SaveExpList);
            SaveSelectionViewInfo(SaveSelList);
            SaveVisibleIndex();
        }

        public void LoadViewInfo()
        {
            LoadExpandedMasterRows(SaveMasterRowsList);
            LoadExpansionViewInfo(SaveExpList);
            LoadSelectionViewInfo(SaveSelList);
            LoadVisibleIndex();
        }
    }
}
