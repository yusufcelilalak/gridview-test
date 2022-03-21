namespace GridViewTestApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo29 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo30 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo31 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo32 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings8 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions8 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings8);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.excelDataSource2 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWindow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.position = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.excelDataSource2;
            this.gridControl1.Location = new System.Drawing.Point(128, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(729, 367);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseMove);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPerson,
            this.colDoor,
            this.colWindow,
            this.colRoom});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // excelDataSource2
            // 
            this.excelDataSource2.FileName = "C:\\Users\\Celil\\Desktop\\Person.xlsx";
            this.excelDataSource2.Name = "excelDataSource2";
            this.excelDataSource2.ResultSchemaSerializable = resources.GetString("excelDataSource2.ResultSchemaSerializable");
            fieldInfo29.Name = "Person";
            fieldInfo29.OriginalName = "Person";
            fieldInfo29.Type = typeof(string);
            fieldInfo30.Name = "Door";
            fieldInfo30.OriginalName = "Door";
            fieldInfo30.Type = typeof(double);
            fieldInfo31.Name = "Window";
            fieldInfo31.OriginalName = "Window";
            fieldInfo31.Type = typeof(double);
            fieldInfo32.Name = "Room";
            fieldInfo32.OriginalName = "Room";
            fieldInfo32.Type = typeof(double);
            this.excelDataSource2.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo29,
            fieldInfo30,
            fieldInfo31,
            fieldInfo32});
            excelWorksheetSettings8.CellRange = null;
            excelWorksheetSettings8.WorksheetIndex = null;
            excelWorksheetSettings8.WorksheetName = "Sheet1";
            excelSourceOptions8.ImportSettings = excelWorksheetSettings8;
            this.excelDataSource2.SourceOptions = excelSourceOptions8;
            // 
            // colPerson
            // 
            this.colPerson.FieldName = "Person";
            this.colPerson.MinWidth = 25;
            this.colPerson.Name = "colPerson";
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 0;
            this.colPerson.Width = 94;
            // 
            // colDoor
            // 
            this.colDoor.FieldName = "Door";
            this.colDoor.MinWidth = 25;
            this.colDoor.Name = "colDoor";
            this.colDoor.Visible = true;
            this.colDoor.VisibleIndex = 1;
            this.colDoor.Width = 94;
            // 
            // colWindow
            // 
            this.colWindow.FieldName = "Window";
            this.colWindow.MinWidth = 25;
            this.colWindow.Name = "colWindow";
            this.colWindow.Visible = true;
            this.colWindow.VisibleIndex = 2;
            this.colWindow.Width = 94;
            // 
            // colRoom
            // 
            this.colRoom.FieldName = "Room";
            this.colRoom.MinWidth = 25;
            this.colRoom.Name = "colRoom";
            this.colRoom.Visible = true;
            this.colRoom.VisibleIndex = 3;
            this.colRoom.Width = 94;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(996, 171);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(100, 23);
            this.position.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 565);
            this.Controls.Add(this.position);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colDoor;
        private DevExpress.XtraGrid.Columns.GridColumn colWindow;
        private DevExpress.XtraGrid.Columns.GridColumn colRoom;
        private System.Windows.Forms.TextBox position;
    }
}

