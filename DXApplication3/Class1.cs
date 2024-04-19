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
        private struct RowInfo
        {
            public object Id;
            public int Level;
        };

        private ArrayList _saveExpList;
        private ArrayList _saveSelList;
        private ArrayList _saveMasterRowsList;
        private int _visibleRowIndex = -1;
        private readonly GridView _view;
        private readonly string _keyFieldName;

        /// <summary>
        /// NEW NEW NEW
        /// </summary>
        public RefreshHelper(GridView view, string keyFieldName)
        {
            System.Diagnostics.Debug.Print(Guid.NewGuid().ToString() + " " + view.Name);
            _view = view;
            _keyFieldName = keyFieldName;
            var found = _view.Columns.ColumnByFieldName(keyFieldName);

            if (found is null)
            {
                // Logging.LogEvent("Grid Column not found", LogLevel.Warn);
            }
        }

        private ArrayList SaveExpList
        {
            get { return _saveExpList ??= []; }
        }

        private ArrayList SaveSelList
        {
            get { return _saveSelList ??= []; }
        }

        private ArrayList SaveMasterRowsList
        {
            get { return _saveMasterRowsList ??= []; }
        }

        private int FindParentRowHandle(RowInfo rowInfo, int rowHandle)
        {
            var result = _view.GetParentRowHandle(rowHandle);
            while (_view.GetRowLevel(result) != rowInfo.Level && _view.IsValidRowHandle(result))
                result = _view.GetParentRowHandle(result);
            return result;
        }

        private void ExpandRowByRowInfo(RowInfo rowInfo)
        {
            var dataRowHandle = _view.LocateByValue(0, _view.Columns[_keyFieldName], rowInfo.Id);
            if (dataRowHandle == GridControl.InvalidRowHandle) return;
            var parentRowHandle = FindParentRowHandle(rowInfo, dataRowHandle);
            _view.SetRowExpanded(parentRowHandle, true, false);
        }

        private int GetRowHandleToSelect(RowInfo rowInfo)
        {
            var dataRowHandle = _view.LocateByValue(0, _view.Columns[_keyFieldName], rowInfo.Id);
            if (dataRowHandle == GridControl.InvalidRowHandle) return dataRowHandle;
            return _view.GetRowLevel(dataRowHandle) != rowInfo.Level
                ? FindParentRowHandle(rowInfo, dataRowHandle)
                : dataRowHandle;
        }

        private void SelectRowByRowInfo(RowInfo rowInfo, bool isFocused)
        {
            if (isFocused)
                _view.FocusedRowHandle = GetRowHandleToSelect(rowInfo);
            else
                _view.SelectRow(GetRowHandleToSelect(rowInfo));
        }

        private void SaveSelectionViewInfo(ArrayList list)
        {
            list.Clear();
            var column = _view.Columns[_keyFieldName];
            RowInfo rowInfo;
            var selectionArray = _view.GetSelectedRows();
            if (selectionArray != null) // otherwise we have a single focused but not selected row
                foreach (var t in selectionArray)
                {
                    var dataRowHandle = t;
                    rowInfo.Level = _view.GetRowLevel(dataRowHandle);
                    if (dataRowHandle < 0) // group row
                        dataRowHandle = _view.GetDataRowHandleByGroupRowHandle(dataRowHandle);
                    rowInfo.Id = _view.GetRowCellValue(dataRowHandle, column);
                    list.Add(rowInfo);
                }

            rowInfo.Id = _view.GetRowCellValue(_view.FocusedRowHandle, column);
            rowInfo.Level = _view.GetRowLevel(_view.FocusedRowHandle);
            list.Add(rowInfo);
        }

        private void SaveExpansionViewInfo(ArrayList list)
        {
            if (_view.GroupedColumns.Count == 0) return;
            list.Clear();
            var column = _view.Columns[_keyFieldName];
            for (var i = -1; i > int.MinValue; i--)
            {
                if (!_view.IsValidRowHandle(i)) break;
                if (!_view.GetRowExpanded(i)) continue;
                RowInfo rowInfo;
                var dataRowHandle = _view.GetDataRowHandleByGroupRowHandle(i);
                rowInfo.Id = _view.GetRowCellValue(dataRowHandle, column);
                rowInfo.Level = _view.GetRowLevel(i);
                list.Add(rowInfo);
            }
        }

        private void SaveExpandedMasterRows(ArrayList list)
        {
            if (_view.GridControl.Views.Count == 1) return;
            list.Clear();
            var column = _view.Columns[_keyFieldName];
            for (var i = 0; i < _view.DataRowCount; i++)
                if (_view.GetMasterRowExpanded(i))
                    list.Add(_view.GetRowCellValue(i, column));
        }

        private void SaveVisibleIndex()
        {
            _visibleRowIndex = _view.GetVisibleIndex(_view.FocusedRowHandle) - _view.TopRowIndex;
        }

        private void LoadVisibleIndex()
        {
            _view.MakeRowVisible(_view.FocusedRowHandle, true);
            _view.TopRowIndex = _view.GetVisibleIndex(_view.FocusedRowHandle) - _visibleRowIndex;
        }

        private void LoadSelectionViewInfo(ArrayList list)
        {
            _view.BeginSelection();
            try
            {
                _view.ClearSelection();
                for (var i = 0; i < list.Count; i++)
                    SelectRowByRowInfo((RowInfo)list[i], i == list.Count - 1);
            }
            finally
            {
                _view.EndSelection();
            }
        }

        private void LoadExpansionViewInfo(ArrayList list)
        {
            if (_view.GroupedColumns.Count == 0) return;
            _view.BeginUpdate();
            try
            {
                _view.CollapseAllGroups();
                foreach (RowInfo info in list)
                    ExpandRowByRowInfo(info);
            }
            finally
            {
                _view.EndUpdate();
            }
        }

        private void LoadExpandedMasterRows(ArrayList list)
        {
            _view.BeginUpdate();
            try
            {
                _view.CollapseAllDetails();
                var column = _view.Columns[_keyFieldName];
                foreach (var t in list)
                {
                    var rowHandle = _view.LocateByValue(0, column, t);
                    _view.SetMasterRowExpanded(rowHandle, true);
                }
            }
            finally
            {
                _view.EndUpdate();
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
            _saveSelList = null;
            _saveExpList = null;
            _saveMasterRowsList = null;
        }
    }
}
