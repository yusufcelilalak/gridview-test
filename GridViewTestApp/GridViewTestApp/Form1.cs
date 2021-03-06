using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace GridViewTestApp
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        int mode = 3;
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the ExcelDataSource
            excelDataSource1.Fill();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the ExcelDataSource
            excelDataSource2.Fill();


        }

        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {
            GridControl grid = sender as GridControl;
            if (grid == null) return;
            // Get a View at the current point.
            BaseView view = grid.GetViewAt(e.Location);
            if (view == null) return;
            // Retrieve information on the current View element.
            BaseHitInfo baseHI = view.CalcHitInfo(e.Location);
            GridHitInfo gridHI = baseHI as GridHitInfo;
            if (gridHI != null && gridHI.Column !=null)
            {
                HotTrack.GetInstance().RowNumber = gridHI.RowHandle;
                HotTrack.GetInstance().ColumnName = gridHI.Column.ToString();
                
                position.Text = gridHI.RowHandle.ToString() + " : " + gridHI.Column.ToString();
            }
                
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column.FieldName == HotTrack.GetInstance().ColumnName && e.RowHandle == HotTrack.GetInstance().RowNumber)
            {
                e.Appearance.BackColor = Color.Aqua;
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == HotTrack.GetInstance().ColumnName && mode == 2)
            {
                e.DisplayText = "Just Test";
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == HotTrack.GetInstance().ColumnName && mode == 3)
            {
                e.Cache.DrawEllipse(new Pen(Color.Black, 3), new Rectangle(e.Bounds.Location,new Size(10,5)));
            }
        }
    }
}
