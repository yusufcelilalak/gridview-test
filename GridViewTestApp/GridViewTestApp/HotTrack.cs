using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewTestApp
{
    internal class HotTrack
    {
        private int rowNumber = 0;
        private string columnName = "";
        private static HotTrack _instance;



        private HotTrack() {

        }

        
        public static HotTrack GetInstance()
        {
           
            if (_instance == null)
            {
                _instance = new HotTrack();
            }
            return _instance;
        }

        public int RowNumber { get { return rowNumber; } set { rowNumber = value; } }
        public string ColumnName { get { return columnName; } set { columnName = value; } }
    }
}
